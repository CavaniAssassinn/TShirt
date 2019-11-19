using System;
using System.ComponentModel;
using Xamarin.Forms;
namespace Tshirt
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
       
            private async void TshirtOrder_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TshirtPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TshirtPage());
        }

        
    }
}
