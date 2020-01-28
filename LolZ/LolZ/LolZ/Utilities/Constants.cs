using LolZ.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LolZ.Utilities
{
    public class Constants
    {
        public static string ApiKey = "RGAPI-7d1b7767-8ad9-45d2-911d-470b19158a55";
        public static string RiotPath = ".api.riotgames.com/lol/";
        public static string SummonerNamePath = "summoner/v4/summoners/by-name/";
        public static string ChampionMasteryPath = "champion-mastery/v4/champion-masteries/by-summoner/";
        public static string SummonerProfilePath = "league/v4/entries/by-summoner/";
        public static string ChampionImagePath = "https://ddragon.leagueoflegends.com/cdn/9.24.2/img/champion/";
        public static string SummonerTierImageStartPath = "https://vignette.wikia.nocookie.net/leagueoflegends/images/";
        public static string SummonerTierImageEndPath = "revision/latest/scale-to-width-down/120?cb=201812031816";


        public static SummonerDTO Summoner { get; set; }
        public static string SummonerName { get; set; }
        public static string Region { get; set; }
        public static long SummonerLevel { get; set; }
        public static string SummonerId { get; set; }
        public static long ChampionId { get; set; }
        public static string ChampionImageUrl { get; set; }
        public static string SummonerTier { get; set; }
}
}
