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
            Key = "RGAPI-f1456e57-1250-45a3-be99-3cd2f023ae78";
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
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }
    }
}
