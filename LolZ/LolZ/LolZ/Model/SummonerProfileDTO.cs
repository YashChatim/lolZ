using System;
using System.Collections.Generic;
using System.Text;

namespace LolZ.Model
{
    public class SummonerProfileDTO
    {
        public string SummonerName { get; set; }
        public string QueueType { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string Tier { get; set; }
        public string Rank { get; set; }
        public int LeaguePoints { get; set; }
        public long SummonerLevel { get; set; }
        public string SummonerTierImage { get; set; }
    }
}
