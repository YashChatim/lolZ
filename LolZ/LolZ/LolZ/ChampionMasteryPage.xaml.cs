using LolZ.Model;
using LolZ.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LolZ
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChampionMasteryPage : ContentPage
    {
        public ChampionMasteryPage()
        {
            InitializeComponent();
            GetChampionMastery(Constants.Region, Constants.RiotPath, Constants.ChampionMasteryPath, Constants.SummonerId, Constants.ApiKey);
        }

        private async void GetChampionMastery(string region, string riotPath, string championMasteryPath, string summonerId, string apiKey)
        {
            HttpClient httpClient = new HttpClient();
            var request = "https://" + region + riotPath + championMasteryPath + summonerId + "/?api_key=" + apiKey;
            var response = await httpClient.GetStringAsync(request);

            var championMastery = JsonConvert.DeserializeObject<List<ChampionMasteryDTO>>(response);
            championMasteryListView.ItemsSource = championMastery;
        }
    }
}