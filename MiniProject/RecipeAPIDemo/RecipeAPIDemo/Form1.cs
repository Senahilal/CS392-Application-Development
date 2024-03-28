using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace SerpAPITest
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            searchButton.Enabled = false; // Prevents multiple clicks

            string apiKey = "key-goes-here";
            // Get the search query out of the text box
            string query = searchTextBox.Text;
            // Create a new HTTP request to the Spoonacular API, and fill in the query parameters
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"https://api.spoonacular.com/recipes/findByIngredients?&ingredients={Uri.EscapeDataString(query)}&number=3&sort=popularity"))
            {
                try
                {
                    // Add the API key in a request header
                    requestMessage.Headers.Add("x-api-key", apiKey);
                    // Asynchronously call the API and await the response
                    HttpResponseMessage resp = await client.SendAsync(requestMessage);

                    // Parse the JSON response
                    JArray data = JArray.Parse(await resp.Content.ReadAsStringAsync());

                    // Update UI (ensure execution on UI thread)
                    UpdateResultsList(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    searchButton.Enabled = true; // Re-enable the button
                }
            }

        }
        private void UpdateResultsList(JToken recipeResults)
        {
            // Clear the results list
            resultsListBox.Items.Clear();

            // Loop over the results and add each recipe to the results box
            int resultCount = 0;
            foreach (var result in recipeResults)
            {
                string title = result["title"].ToString();
                string missedIngredientCount = result["missedIngredientCount"].ToString();
                string likes = result["likes"].ToString();

                resultsListBox.Items.Add($"Title: {title}, Missing Ingredients: {missedIngredientCount}, Likes: {likes}");

                resultCount++;
            }
        }
    }
}
