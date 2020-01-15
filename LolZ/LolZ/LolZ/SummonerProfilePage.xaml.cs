using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LolZ.Utilities;
using LolZ.Model;

namespace LolZ
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SummonerProfilePage : ContentPage
    {
        public SummonerProfilePage()
        {
            InitializeComponent();
            GetSummonerProfile(Constants.Region, Constants.RiotPath, Constants.SummonerProfilePath, Constants.SummonerId, Constants.ApiKey);
        }

        public async void GetSummonerProfile(string region, string riotPath, string summonerProfilePath, string summonerId, string apiKey)
        {
            HttpClient httpClient = new HttpClient();
            var request = "https://" + region + riotPath + summonerProfilePath + summonerId + "/?api_key=" + apiKey;
            var response = await httpClient.GetStringAsync(request);

            var summonerProfile = JsonConvert.DeserializeObject<List<SummonerProfileDTO>>(response);

            summonerProfileListView.ItemsSource = summonerProfile;
        }
    }
}