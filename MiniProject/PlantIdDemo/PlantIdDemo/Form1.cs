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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            string imagePath = openFileDialog.FileName;
            try
            {
                string plantName = await IdentifyPlant(imagePath);
                MessageBox.Show($"The plant in the image is: {plantName}", "Plant Identified");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
        private async Task<string> IdentifyPlant(string imagePath)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Api-Key", ApiKey);

                var content = new MultipartFormDataContent();
                var imageContent = new ByteArrayContent(File.ReadAllBytes(imagePath));
                imageContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("image/jpeg");
                content.Add(imageContent, "images", "image.jpg");

                var response = await client.PostAsync(ApiEndpoint, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Failed to identify plant. Status code: {response.StatusCode}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                return ExtractPlantName(responseContent);
            }
        }

        private string ExtractPlantName(string jsonResponse)
        {
            // You may need to use a JSON parsing library like Newtonsoft.Json for more complex JSON parsing
            // For this simple example, we'll just extract the plant name directly
            int startIndex = jsonResponse.IndexOf("\"name\":") + "\"name\":".Length;
            int endIndex = jsonResponse.IndexOf("\"", startIndex);
            return jsonResponse.Substring(startIndex, endIndex - startIndex);
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
