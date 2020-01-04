using LolZ.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LolZ.Utilities
{
    public class Constants
    {
        public static string ApiKey = "RGAPI-f1456e57-1250-45a3-be99-3cd2f023ae78";
        public static string RiotPath = ".api.riotgames.com/lol/";
        public static string ChampionMasteryPath = "champion-mastery/v4/champion-masteries/by-summoner/";
        public static string SummonerNamePath = "summoner/v4/summoners/by-name/";


        public static SummonerDTO Summoner { get; set; }
        public static string Region { get; set; }
        public static string SummonerId { get; set; }
        public static long ChampionId { get; set; }
}
}
