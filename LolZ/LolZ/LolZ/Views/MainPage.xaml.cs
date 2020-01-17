using LolZ.Utilities;
using LolZ.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LolZ
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainViewModel mainViewModel;

        public MainPage()
        {
            mainViewModel = new MainViewModel();
            InitializeComponent();

            this.BindingContext = mainViewModel;
        }

        private async void summonerProfileButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mainViewModel.Region) || string.IsNullOrEmpty(mainViewModel.SummonerName))
            {
                await DisplayAlert("Warning!!!", "Region or SummonerName field is empty", "Retry");
                return;
            }

            else if (mainViewModel.GetSummoner(mainViewModel.SummonerName))
            {
                Constants.SummonerName = mainViewModel.SummonerName;
                Constants.SummonerId = Constants.Summoner.Id;
                await Navigation.PushAsync(new SummonerProfilePage());
            }

            else { await DisplayAlert("Warning!!!", "Summoner not found", "Retry"); }
        }

        private async void championMasteryButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mainViewModel.Region) || string.IsNullOrEmpty(mainViewModel.SummonerName))
            {
                await DisplayAlert("Warning!!!", "Region or SummonerName field is empty", "Retry");
                return;
            }

            else if (mainViewModel.GetSummoner(mainViewModel.SummonerName))
            {
                Constants.SummonerId = Constants.Summoner.Id;
                await Navigation.PushAsync(new ChampionMasteryPage());
            }

            else { await DisplayAlert("Warning!!!", "Summoner not found", "Retry"); }
        }
    }
}
