using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Windows;
using Microsoft.Win32;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;



namespace PlantIdDemo
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "P5FcqhEN8MNUfl6uz7QhGlY7nfOCsavHM8H0J4b1tvDjmJaLEg"; // Replace with your API key
        private const string ApiEndpoint = "https://plant.id/api/v3/identification";
        

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 'basil-pl.png' is in the application's current directory
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "basil-pl.png");
            try
            {
                string plantName = await IdentifyPlant(imagePath);
                // MessageBox.Show($"The plant in the image is: {plantName}", "Plant Identified");
                label1.Text = ExtractCommonNames(plantName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
  
        private async Task<string> IdentifyPlant(string imagePath)
        {
            // Convert image to base64
            string base64Image = ImageToBase64(imagePath);

            // Your API key should be correctly placed here
            string apiKey = "P5FcqhEN8MNUfl6uz7QhGlY7nfOCsavHM8H0J4b1tvDjmJaLEg";

            // Create the HttpClient and HttpRequestMessage
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://plant.id/api/v3/identification?details=common_names");

            // Add the API key to the request header
            request.Headers.Add("Api-Key", apiKey);

            // Create the JSON payload with the base64 encoded image
            string jsonPayload = "{\"images\": [\"data:image/jpeg;base64," + base64Image + "\"]}";
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            try
            {
                // Send the request to the API
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode(); // Throws if not 2xx

                // Read the response as a string
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonResponse);
                return jsonResponse;
            }
            catch (Exception ex)
            {
                // Handle any exceptions here, such as a non-success status code
                Console.WriteLine($"Exception caught: {ex.Message}");
                return null; // Or however you wish to handle this
            }
        }

        private string ImageToBase64(string imagePath)
        {
            // Read the file into a byte array
            byte[] imageArray = System.IO.File.ReadAllBytes(imagePath);
            // Convert byte array to base64 string
            return Convert.ToBase64String(imageArray);
        }

        private string ExtractCommonNames(string jsonResponse)
        {
            // Parse the JSON response to a JObject
            JObject responseObject = JObject.Parse(jsonResponse);

            // Navigate to the first suggestion within the classification results
            JToken firstSuggestion = responseObject["result"]?["classification"]?["suggestions"]?.FirstOrDefault();

            // If there's a suggestion, get the common names
            if (firstSuggestion != null)
            {
                // Access the details and then the common names
                JArray commonNamesArray = (JArray)firstSuggestion["details"]?["common_names"];
                if (commonNamesArray != null && commonNamesArray.Count > 0)
                {
                    return commonNamesArray[0]?.ToString();
                }
            }

            return "Common names not found";
        }


        private string ExtractFirstPlantName(string jsonResponse)
        {
            JObject responseObject = JObject.Parse(jsonResponse);
            JArray suggestions = (JArray)responseObject["result"]["classification"]["suggestions"];

            if (suggestions != null && suggestions.Count > 0)
            {
                JObject firstSuggestion = (JObject)suggestions.First;
                if (firstSuggestion["name"] != null)
                {
                    return firstSuggestion["name"].ToString();
                }
            }

            return "Name not found";
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // 'lettuce.png' is in the application's current directory Napa-Cabbage-scaled.png
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lettuce.jpg");
            try
            {
                string plantName = await IdentifyPlant(imagePath);
                // MessageBox.Show($"The plant in the image is: {plantName}", "Plant Identified");
                label2.Text = ExtractCommonNames(plantName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            // 'Napa-Cabbage-scaled.png' is in the application's current directory Napa-Cabbage-scaled.png
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Napa-Cabbage-scaled.png");
            try
            {
                string plantName = await IdentifyPlant(imagePath);
                // MessageBox.Show($"The plant in the image is: {plantName}", "Plant Identified");
                label3.Text = ExtractCommonNames(plantName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
