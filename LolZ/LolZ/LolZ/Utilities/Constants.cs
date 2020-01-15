using LolZ.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LolZ.Utilities
{
    public class Constants
    {
        public static string ApiKey = "RGAPI-69da348f-1551-4d13-93b5-6b46d29fbff2";
        public static string RiotPath = ".api.riotgames.com/lol/";
        public static string SummonerNamePath = "summoner/v4/summoners/by-name/";
        public static string ChampionMasteryPath = "champion-mastery/v4/champion-masteries/by-summoner/";
        public static string SummonerProfilePath = "league/v4/entries/by-summoner/";
        public static string ChampionImagePath = "https://ddragon.leagueoflegends.com/cdn/9.24.2/img/champion/";


        public static SummonerDTO Summoner { get; set; }
        public static string Region { get; set; }
        public static string SummonerId { get; set; }
        public static long ChampionId { get; set; }
        public static string ChampionImageUrl { get; set; }
}
}
