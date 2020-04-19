using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace XamarinFormsDemo.Control
{
    class UpdateWebContentsDataCovid19
    {
        public UpdateWebContentsDataCovid19()
        {

        }       

        public async void DownloadFreshCovid19Data()
        {
            var client = new HttpClient();
            Console.WriteLine("dlp Try to get data");
            HttpResponseMessage responseMessage = await client.GetAsync("https://bing.com/covid/data");
            responseMessage.EnsureSuccessStatusCode();
            string responsHtml = await responseMessage.Content.ReadAsStringAsync();
            var lenOfResponse = responsHtml.Length;
            Console.WriteLine("dlp Download data has been done {0}", lenOfResponse.ToString());
        }
    }
   
}
