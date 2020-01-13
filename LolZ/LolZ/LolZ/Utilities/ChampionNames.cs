﻿using LolZ.Model;
using System;
using System.Collections.Generic;
using System.Text;
using LolZ.Utilities;

namespace LolZ.Utilities
{
    public class ChampionNames
    {
        public static string ChampionNamesAccordingToChampionId()
        {
            string result;
            switch(Constants.ChampionId)
            {
                case 266: result = "Aatrox"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Aatrox.png"; break;
                case 412: result = "Thresh"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Thresh.png"; break;
                case 23: result = "Tryndamere"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Tryndamere.png"; break;
                case 79: result = "Gragas"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Gragas.png"; break;
                case 69: result = "Cassiopeia"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Cassiopeia.png"; break;
                case 136: result = "Aurelion Sol"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "AurelionSol.png"; break;
                case 13: result = "Ryze"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Ryze.png"; break;
                case 78: result = "Poppy"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Poppy.png"; break;
                case 14: result = "Sion"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Sion.png"; break;
                case 1: result = "Annie"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Annie.png"; break;
                case 202: result = "Jhin"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Jhin.png"; break;
                case 43: result = "Karma"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Karma.png"; break;
                case 111: result = "Nautilus"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Nautilus.png"; break;
                case 240: result = "Kled"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Kled.png"; break;
                case 99: result = "Lux"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Lux.png"; break;
                case 103: result = "Ahri"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Ahri.png"; break;
                case 2: result = "Olaf"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Olaf.png"; break;
                case 112: result = "Viktor"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Viktor.png"; break;
                case 34: result = "Anivia"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Anivia.png"; break;
                case 27: result = "Singed"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Singed.png"; break;
                case 86: result = "Garen"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Garen.png"; break;
                case 127: result = "Lissandra"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Lissandra.png"; break;
                case 57: result = "Maokai"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Maokai.png"; break;
                case 25: result = "Morgana"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Morgana.png"; break;
                case 28: result = "Evelynn"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Evelynn.png"; break;
                case 105: result = "Fizz"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Fizz.png"; break;
                case 74: result = "Heimerdinger"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Heimerdinger.png"; break;
                case 238: result = "Zed"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Zed.png"; break;
                case 68: result = "Rumble"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Rumble.png"; break;
                case 82: result = "Mordekaiser"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Mordekaiser.png"; break;
                case 37: result = "Sona"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Sona.png"; break;
                case 96: result = "Kog'Maw"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "KogMaw.png"; break;
                case 55: result = "Katarina"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Katarina.png"; break;
                case 117: result = "Lulu"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Lulu.png"; break;
                case 22: result = "Ashe"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Ashe.png"; break;
                case 30: result = "Karthus"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Karthus.png"; break;
                case 12: result = "Alistar"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Alistar.png"; break;
                case 122: result = "Darius"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Darius.png"; break;
                case 67: result = "Vayne"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Vayne.png"; break;
                case 110: result = "Varus"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Varus.png"; break;
                case 77: result = "Udyr"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Udyr.png"; break;
                case 89: result = "Leona"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Leona.png"; break;
                case 126: result = "Jayce"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Jayce.png"; break;
                case 134: result = "Syndra"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Syndra.png"; break;
                case 80: result = "Pantheon"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Pantheon.png"; break;
                case 92: result = "Riven"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Riven.png"; break;
                case 121: result = "Kha'Zix"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Khazix.png"; break;
                case 42: result = "Corki"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Corki.png"; break;
                case 268: result = "Azir"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Azir.png"; break;
                case 51: result = "Caitlyn"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Caitlyn.png"; break;
                case 76: result = "Nidalee"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Nidalee.png"; break;
                case 85: result = "Kennen"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Kennen.png"; break;
                case 3: result = "Galio"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Galio.png"; break;
                case 45: result = "Veigar"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Veigar.png"; break;
                case 432: result = "Bard"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Bard.png"; break;
                case 150: result = "Gnar"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Gnar.png"; break;
                case 90: result = "Malzahar"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Malzahar.png"; break;
                case 104: result = "Graves"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Graves.png"; break;
                case 254: result = "Vi"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Vi.png"; break;
                case 10: result = "Kayle"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Kayle.png"; break;
                case 39: result = "Irelia"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Irelia.png"; break;
                case 64: result = "Lee Sin"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "LeeSin.png"; break;
                case 420: result = "Illaoi"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Illaoi.png"; break;
                case 60: result = "Elise"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Elise.png"; break;
                case 106: result = "Volibear"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Volibear.png"; break;
                case 20: result = "Nunu"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Nunu.png"; break;
                case 4: result = "Twisted Fate"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "TwistedFate.png"; break;
                case 24: result = "Jax"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Jax.png"; break;
                case 102: result = "Shyvana"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Shyvana.png"; break;
                case 429: result = "Kalista"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Kalista.png"; break;
                case 36: result = "Dr. Mundo"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "DrMundo.png"; break;
                case 427: result = "Ivern"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Ivern.png"; break;
                case 131: result = "Diana"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Diana.png"; break;
                case 223: result = "Tahm Kench"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "TahmKench.png"; break;
                case 63: result = "Brand"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Brand.png"; break;
                case 113: result = "Sejuani"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Sejuani.png"; break;
                case 8: result = "Vladimir"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Vladimir.png"; break;
                case 154: result = "Zac"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Zac.png"; break;
                case 421: result = "Rek'Sai"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "RekSai.png"; break;
                case 133: result = "Quinn"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Quinn.png"; break;
                case 84: result = "Akali"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Akali.png"; break;
                case 163: result = "Taliyah"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Taliyah.png"; break;
                case 18: result = "Tristana"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Tristana.png"; break;
                case 120: result = "Hecarim"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Hecarim.png"; break;
                case 15: result = "Sivir"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Sivir.png"; break;
                case 236: result = "Lucian"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Lucian.png"; break;
                case 107: result = "Rengar"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Rengar.png"; break;
                case 19: result = "Warwick"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Warwick.png"; break;
                case 72: result = "Skarner"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Skarner.png"; break;
                case 54: result = "Malphite"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Malphite.png"; break;
                case 157: result = "Yasuo"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Yasuo.png"; break;
                case 101: result = "Xerath"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Xerath.png"; break;
                case 17: result = "Teemo"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Teemo.png"; break;
                case 75: result = "Nasus"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Nasus.png"; break;
                case 58: result = "Renekton"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Renekton.png"; break;
                case 119: result = "Draven"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Draven.png"; break;
                case 35: result = "Shaco"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Shaco.png"; break;
                case 50: result = "Swain"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Swain.png"; break;
                case 91: result = "Talon"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Talon.png"; break;
                case 40: result = "Janna"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Janna.png"; break;
                case 115: result = "Ziggs"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Ziggs.png"; break;
                case 245: result = "Ekko"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Ekko.png"; break;
                case 61: result = "Orianna"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Orianna.png"; break;
                case 114: result = "Fiora"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Fiora.png"; break;
                case 9: result = "Fiddlesticks"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Fiddlesticks.png"; break;
                case 31: result = "Cho'Gath"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Chogath.png"; break;
                case 33: result = "Rammus"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Rammus.png"; break;
                case 7: result = "LeBlanc"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Leblanc.png"; break;
                case 16: result = "Soraka"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Soraka.png"; break;
                case 26: result = "Zilean"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Zilean.png"; break;
                case 56: result = "Nocturne"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Nocturne.png"; break;
                case 222: result = "Jinx"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Jinx.png"; break;
                case 83: result = "Yorick"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Yorick.png"; break;
                case 6: result = "Urgot"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Urgot.png"; break;
                case 203: result = "Kindred"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Kindred.png"; break;
                case 21: result = "Miss Fortune"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "MissFortune.png"; break;
                case 62: result = "Wukong"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "MonkeyKing.png"; break;
                case 53: result = "Blitzcrank"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Blitzcrank.png"; break;
                case 98: result = "Shen"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Shen.png"; break;
                case 201: result = "Braum"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Braum.png"; break;
                case 5: result = "Xin Zhao"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "XinZhao.png"; break;
                case 29: result = "Twitch"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Twitch.png"; break;
                case 11: result = "Master Yi"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "MasterYi.png"; break;
                case 44: result = "Taric"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Taric.png"; break;
                case 32: result = "Amumu"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Amumu.png"; break;
                case 41: result = "Gangplank"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Gangplank.png"; break;
                case 48: result = "Trundle"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Trundle.png"; break;
                case 38: result = "Kassadin"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Kassadin.png"; break;
                case 161: result = "Vel'Koz"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Velkoz.png"; break;
                case 143: result = "Zyra"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Zyra.png"; break;
                case 267: result = "Nami"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Nami.png"; break;
                case 59: result = "Jarvan IV"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "JarvanIV.png"; break;
                case 81: result = "Ezreal"; Constants.ChampionImageUrl = Constants.ChampionImagePath + "Ezreal.png"; break;
                default: result = "New champion"; Constants.ChampionImageUrl = "https://apprecs.org/ios/images/app-icons/256/21/564582433.jpg"; break;
            };
            return result;
        }
    }
}