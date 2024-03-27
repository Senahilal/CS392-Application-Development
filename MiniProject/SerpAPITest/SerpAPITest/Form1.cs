﻿using System;
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
using static System.Windows.Forms.LinkLabel;

namespace SerpAPITest
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient(); // creating HTTTPS client
        private List<string> links = new List<string>(); // creating list to store links of products
        public Form1()
        {
            InitializeComponent();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            searchButton.Enabled = false; // Prevents multiple clicks

            string apiKey = "c59cba7a52e840ccf946dd9fe9ab07ef917055952b19c51cfa4e70dfc26c67b8"; //super secret API key
            string query = searchTextBox.Text; //getting text from search box
            // url for API endpoint to perform search
            string url = $"https://serpapi.com/search.json?engine=google_shopping&q={Uri.EscapeDataString(query)}&api_key={apiKey}";

            try
            {
                // Asynchronously call the API and await the response
                string responseString = await client.GetStringAsync(url);

                // Parse the JSON response
                JObject data = JObject.Parse(responseString);

                // get shopping results from JObject
                var shopping_results = data["shopping_results"];

                // Update UI
                UpdateResultsList(shopping_results);
            }
            catch (Exception ex) //  catching exceptions
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
            resultsListBox.Items.Clear(); //clear list box

            int resultCount = 0;
            // go over each result
            foreach (var result in shoppingResults)
            {
                if (resultCount >= 7) break; // Display only top 7 results

                string title = result["title"].ToString(); //gettitle of product
                string price = result["price"].ToString(); //get display price
                string link = (string)result["link"]; //get link
                string source = result["source"].ToString();

                resultsListBox.Items.Add($"Title: {title}, Price: {price}, Source: {source}"); 

                resultCount++;
                links.Add(link); //add link to list
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; // Disable the button to prevent multiple clicks

            string apiKey = "c59cba7a52e840ccf946dd9fe9ab07ef917055952b19c51cfa4e70dfc26c67b8"; //super secret API key
            string query = searchTextBox.Text; // get search
            if (!query.ToLower().Contains("seed"))
            {
                query = query + " seed";
            }
            //url for api endpoint
            string url = $"https://serpapi.com/search.json?engine=ebay&_nkw={Uri.EscapeDataString(query)}&ebay_domain=ebay.com&api_key={apiKey}";

            try
            {
                // Asynchronously call the SerpApi eBay search and await the response
                string responseString = await client.GetStringAsync(url);

                // Parse the JSON response
                JObject data = JObject.Parse(responseString);

                // Handle the search results
                var ebayResults = data["organic_results"];
                //update listbox
                UpdateResultsList2(ebayResults);
            }
            catch (Exception ex) //catching exceptions
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                button1.Enabled = true; // Re-enable the button once the operation is complete
            }
        }


        private void UpdateResultsList2(JToken searchResults)
        {
            resultsListBox.Items.Clear();
            int resultCount = 0;

            foreach (var result in searchResults)
            {
                if (resultCount >= 7) break;
                string title = (string)result["title"];
                string link = (string)result["link"];
                string price = "N/A"; // Default if no price is available

                // Check if there's a single price or a range, and format the string accordingly
                if (result["price"]?["raw"] != null)
                {
                    // Single price available
                    price = (string)result["price"]["raw"];
                }
                else if (result["price"]?["from"] != null && result["price"]?["to"] != null)
                {
                    // Price range available
                    string fromPrice = (string)result["price"]["from"]["raw"];
                    string toPrice = (string)result["price"]["to"]["raw"];
                    price = $"from {fromPrice} to {toPrice}";
                }

                // Add the item text to the ListBox
                resultsListBox.Items.Add($"{title}, Price: {price}");
                links.Add(link);
                resultCount++;
            }
        }

        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        // check if any index is selected and that the index of the selected product is less than the length of list link
            if (resultsListBox.SelectedIndex != -1 && resultsListBox.SelectedIndex < links.Count)
            {
            //match selected index with link of selected indec product
                string url = links[resultsListBox.SelectedIndex];
                //open browser with link
                System.Diagnostics.Process.Start("cmd", $"/c start microsoft-edge:{url}");

                // System.Diagnostics.Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Microsoft Edge.lnk", url); // This works for .NET Framework and .NET Core
            }
        }

        private void resultsListBox_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
