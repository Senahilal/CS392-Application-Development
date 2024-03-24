using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace youtubetest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var search = new Search();
            // Execute the search and get the result
            Google.Apis.YouTube.v3.Data.SearchListResponse result = await search.RunAsync(textBox1.Text); // Use the text from textBox1 as the search query.

            string videoId = null;
            // Loop through the search results to find the first video and get its VideoId
            foreach (var searchResult in result.Items)
            {
                if (searchResult.Id.Kind == "youtube#video")
                {
                    videoId = searchResult.Id.VideoId;
                    break; // Exit the loop once the first video ID is found
                }
            }

            // Prepare the HTML content with the video ID inserted into the iframe source
            string html = $"<html><head>" +
                          "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>" +
                           $"</head><body><iframe id='video' src='https://www.youtube.com/embed/{videoId}' width={webBrowser1.Size.Width-20} height={webBrowser1.Size.Height-20} frameborder='0' allowfullscreen></iframe>" + "</body></html>";

            // Set the DocumentText property of the webBrowser1 control to the HTML content
            webBrowser1.DocumentText = html;
        }


    }
    internal class Search
    {
        public async Task<Google.Apis.YouTube.v3.Data.SearchListResponse> RunAsync(string searchQuery) // Accept the search query as a parameter.
        {
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "", // Make sure to replace this with your actual API key.
                    ApplicationName = this.GetType().ToString()
                });

                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = searchQuery; // Use the searchQuery parameter for the search.
                searchListRequest.MaxResults = 1;

                var searchListResponse = await searchListRequest.ExecuteAsync();

                return searchListResponse;

               
            }
            catch (AggregateException ex)
            {
                // This catch block can be expanded as needed to handle specific exceptions.
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                return null;
            }
        }
    }

}

