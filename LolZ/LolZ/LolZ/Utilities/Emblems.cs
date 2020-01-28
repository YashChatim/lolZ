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
                case "IRON": result = "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/32/Season_2019_-_Iron_Trim.png/revision/latest/scale-to-width-down/120?cb=20181203181632"; break;
                case "BRONZE": result = "https://vignette.wikia.nocookie.net/leagueoflegends/images/3/30/Season_2019_-_Bronze_Trim.png/revision/latest/scale-to-width-down/120?cb=20181203181628"; break;
                case "SILVER": result = "https://vignette.wikia.nocookie.net/leagueoflegends/images/c/c3/Season_2019_-_Silver_Trim.png/revision/latest/scale-to-width-down/120?cb=20181203181635"; break;
                case "GOLD": result = "https://vignette.wikia.nocookie.net/leagueoflegends/images/4/4b/Season_2019_-_Gold_Trim.png/revision/latest/scale-to-width-down/120?cb=20181203181631"; break;
                case "PLATINUM": result = "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f8/Season_2019_-_Platinum_Trim.png/revision/latest/scale-to-width-down/120?cb=20181203181634"; break;
                case "DIAMOND": result = "https://vignette.wikia.nocookie.net/leagueoflegends/images/d/d2/Season_2019_-_Diamond_Trim.png/revision/latest/scale-to-width-down/120?cb=20181203181630"; break;
                case "MASTER": result = "https://vignette.wikia.nocookie.net/leagueoflegends/images/f/f2/Season_2019_-_Master_Trim.png/revision/latest/scale-to-width-down/120?cb=20181203181633"; break;
                case "GRANDMASTER": result = "https://vignette.wikia.nocookie.net/leagueoflegends/images/8/83/Season_2019_-_Grandmaster_Trim.png/revision/latest/scale-to-width-down/120?cb=20181203181632"; break;
                case "CHALLENGER": result = "https://vignette.wikia.nocookie.net/leagueoflegends/images/d/d3/Season_2019_-_Challenger_Trim.png/revision/latest/scale-to-width-down/120?cb=20181203181629"; break;
                default: result = "https://vignette.wikia.nocookie.net/leagueoflegends/images/d/de/Season_2019_-_Default_Trim.png/revision/latest/scale-to-width-down/120?cb=20181203181630"; break;
            }
            return result;
        }
    }
}
