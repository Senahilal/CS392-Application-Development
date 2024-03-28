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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

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
            // Get the search query from the text box
            string query = searchTextBox.Text;
            // Create an HTTP request to the Chat GPT API
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"https://api.openai.com/v1/chat/completions"))
            {
                try
                {
                    // Build the JSON body of the request
                    var jsonBody = new
                    {
                        model = "gpt-3.5-turbo",
                        messages = new[]
                        {
                            new { role = "system", content = "You are a helpful assistant who provides suggestions on meals to prepare based on provided criteria." },
                            new { role = "user", content = searchTextBox.Text }
                        }
                    };

                    // Serialize the JSON body
                    string jsonBodyString = JsonConvert.SerializeObject(jsonBody);
                    requestMessage.Content = new StringContent(jsonBodyString);

                    // Set Authorization/Content-Type Headers
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                    requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Asynchronously call the API and await the response
                    HttpResponseMessage resp = await client.SendAsync(requestMessage);

                    // Parse the JSON response
                    JObject data = JObject.Parse(await resp.Content.ReadAsStringAsync());

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
        private void UpdateResultsList(JToken results)
        {
            // Get the response and put it into the result box, while fixing the line endings for windows
            string normalized = Regex.Replace(results["choices"][0]["message"]["content"].ToString(), @"\r\n|\n\r|\n|\r", "\r\n");
            resultBox.Text = normalized;
        }
    }
}
