using TshirtGuy;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tshirt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TshirtPage : ContentPage
    {
        public TshirtPage()
        {
            InitializeComponent();

            var shirt = new TshirtItem();
            BindingContext = shirt;
        }
       
        private async void Cancel_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Save_Clicked(object sender, System.EventArgs e)
        {
            var shirt = new TshirtItem();

            await Navigation.PushAsync(new OrderList());
            var shirtDb = App.Database;
            await shirtDb.SaveItemAsync(shirt);
            await Navigation.PushAsync(new OrderList());
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new OrderList());
        }
    }
}