using System;
using System.Collections.Generic;
using System.Text;
using LolZ.API;
using LolZ.Utilities;

namespace LolZ.Controller
{
    public class MainController
    {
        public bool GetSummoner(string summonerName)
        {
            SummonerAPI summonerAPI = new SummonerAPI(Constants.Region);
            var summoner = summonerAPI.GetSummonerByName(summonerName);
            Constants.Summoner = summoner;

            return summoner != null;
        }
    }
}
