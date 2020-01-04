using LolZ.Model;
using LolZ.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LolZ.API
{
    public class SummonerAPI : RiotAPI
    {
        public SummonerAPI(string region) : base(region) { }

        public SummonerDTO GetSummonerByName(string summonerName)
        {
            string path = Constants.SummonerNamePath + summonerName;

            var response = GET(GetURI(path));
            string context = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(context);
            }

            else { return null; }
        }
    }

}
