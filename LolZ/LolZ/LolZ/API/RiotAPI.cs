using LolZ.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace LolZ.API
{
    public class RiotAPI
    {
        public string Key { get; set; }
        public string Region { get; set; }

        public RiotAPI(string region)
        {
            Region = region;
        }

        protected HttpResponseMessage GET(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var result = httpClient.GetAsync(url);
                result.Wait();

                return result.Result;
            }
        }

        protected string GetURI(string path)
        {
            return "https://" + Region + Constants.RiotPath + path + "?api_key=" + Constants.ApiKey;
        }
    }
}
