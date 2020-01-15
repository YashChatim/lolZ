using LolZ.Controller;
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
        MainController mainController;
        MainViewModel mainViewModel;

        public MainPage()
        {
            mainController = new MainController();
            mainViewModel = new MainViewModel();
            InitializeComponent();

            this.BindingContext = mainViewModel;
        }

        private async void championMasteryButton_Clicked(object sender, EventArgs e)
        {
            if (mainController.GetSummoner(mainViewModel.SummonerName))
            {
                Constants.SummonerId = Constants.Summoner.Id;
                await Navigation.PushAsync(new ChampionMasteryPage());
            }

            else { await DisplayAlert("Alert", "You have been alerted", "Not found"); }            
        }

        private async void summonerProfileButton_Clicked(object sender, EventArgs e)
        {
            if (mainController.GetSummoner(mainViewModel.SummonerName))
            {
                Constants.SummonerId = Constants.Summoner.Id;
                await Navigation.PushAsync(new SummonerProfilePage());
            }

            else { await DisplayAlert("Alert", "You have been alerted", "Not found"); }
        }
    }
}
