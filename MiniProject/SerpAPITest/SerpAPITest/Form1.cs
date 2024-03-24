using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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

            string apiKey = "c59cba7a52e840ccf946dd9fe9ab07ef917055952b19c51cfa4e70dfc26c67b8";
            string query = searchTextBox.Text;
            string url = $"https://serpapi.com/search.json?engine=google_shopping&q={Uri.EscapeDataString(query)}&api_key={apiKey}";

            try
            {
                // Asynchronously call the API and await the response
                string responseString = await client.GetStringAsync(url);

                // Parse the JSON response
                JObject data = JObject.Parse(responseString);

                // Assuming 'shopping_results' is part of your JSON response
                var shopping_results = data["shopping_results"];

                // Update UI (ensure execution on UI thread)
                UpdateResultsList(shopping_results);
            }
            catch (Exception ex) // Consider catching more specific exceptions
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                searchButton.Enabled = true; // Re-enable the button
            }
        }
        private void UpdateResultsList(JToken shoppingResults)
        {
            resultsListBox.Items.Clear();

            int resultCount = 0;
            foreach (var result in shoppingResults)
            {
                if (resultCount >= 3) break; // Display only top 3 results

                string title = result["title"].ToString();
                string price = result["price"].ToString();
                string source = result["source"].ToString();

                resultsListBox.Items.Add($"Title: {title}, Price: {price}, Source: {source}");

                resultCount++;
            }
        }
    }
}
