using System;
using System.Collections.Generic;
using System.Text;

namespace LolZ.Model
{
    public class ChampionMasteryDTO
    {
        public long ChampionId { get; set; }
        public int ChampionLevel { get; set; }
        public int ChampionPoints { get; set; }
        public bool ChestGranted { get; set; }
    }
}
