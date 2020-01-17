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
using LolZ.ViewModel;

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

            if (summonerProfile.Count == 0)
            {
                await DisplayAlert(Constants.SummonerName.ToUpper(), Constants.SummonerName.ToUpper() + " hasn't played in 2020" , "Search again");
                await Navigation.PushAsync(new MainPage());
                return;
            }

            else
            {
                for (int i = 0; i < summonerProfile.Count; i++)
                {
                    summonerProfile[i].SummonerLevel = Constants.SummonerLevel;
                }
                summonerProfileListView.ItemsSource = summonerProfile;
            }
        }
    }
}