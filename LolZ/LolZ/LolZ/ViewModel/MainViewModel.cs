using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using LolZ.API;
using LolZ.Utilities;

namespace LolZ.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string region, summonerName;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public string Region
        {
            get { return region; }
            set { region = value; Constants.Region = value; NotifyPropertyChanged("Region"); }
        }

        public string SummonerName
        {
            get { return summonerName; }
            set { summonerName = value; NotifyPropertyChanged("SummonerName"); }
        }

        public bool GetSummoner(string summonerName)
        {
            SummonerAPI summonerAPI = new SummonerAPI(Constants.Region);
            var summoner = summonerAPI.GetSummonerByName(summonerName);
            Constants.Summoner = summoner;

            return summoner != null;
        }
    }
}
