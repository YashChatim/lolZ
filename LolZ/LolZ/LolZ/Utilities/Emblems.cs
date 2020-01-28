using System;
using System.Collections.Generic;
using System.Text;

namespace LolZ.Utilities
{
    public class Emblems
    {
        public static string EmblemsAccordingToRanks()
        {
            string result;
            switch (Constants.SummonerTier)
            {
                case "IRON": result = Constants.SummonerTierImageStartPath + "3/32/Season_2019_-_Iron_Trim.png/" + Constants.SummonerTierImageEndPath + "32"; break;
                case "BRONZE": result = Constants.SummonerTierImageStartPath + "3/30/Season_2019_-_Bronze_Trim.png/" + Constants.SummonerTierImageEndPath + "28"; break;
                case "SILVER": result = Constants.SummonerTierImageStartPath + "c/c3/Season_2019_-_Silver_Trim.png/" + Constants.SummonerTierImageEndPath + "35"; break;
                case "GOLD": result = Constants.SummonerTierImageStartPath + "4/4b/Season_2019_-_Gold_Trim.png/" + Constants.SummonerTierImageEndPath + "31"; break;
                case "PLATINUM": result = Constants.SummonerTierImageStartPath + "f/f8/Season_2019_-_Platinum_Trim.png/" + Constants.SummonerTierImageEndPath + "34"; break;
                case "DIAMOND": result = Constants.SummonerTierImageStartPath + "d/d2/Season_2019_-_Diamond_Trim.png/" + Constants.SummonerTierImageEndPath + "30"; break;
                case "MASTER": result = Constants.SummonerTierImageStartPath + "f/f2/Season_2019_-_Master_Trim.png/" + Constants.SummonerTierImageEndPath + "33"; break;
                case "GRANDMASTER": result = Constants.SummonerTierImageStartPath + "8/83/Season_2019_-_Grandmaster_Trim.png/" + Constants.SummonerTierImageEndPath + "32"; break;
                case "CHALLENGER": result = Constants.SummonerTierImageStartPath + "d/d3/Season_2019_-_Challenger_Trim.png/" + Constants.SummonerTierImageEndPath + "29"; break;
                default: result = Constants.SummonerTierImageStartPath + "d/de/Season_2019_-_Default_Trim.png/" + Constants.SummonerTierImageEndPath + "30"; break;
            };
            return result;
        }
    }
}
