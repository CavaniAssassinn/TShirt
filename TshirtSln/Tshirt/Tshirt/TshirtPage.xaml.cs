using TshirtGuy;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tshirt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TshirtPage : ContentPage
    {
//////////public TshirtItem shirt { get; set; }
        public TshirtPage()
        {
            InitializeComponent();

            var shirt = new TshirtItem();
            BindingContext = shirt;
        }



        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
         {
             var tGen = new TshirtItem();
             string boom = tGen.Adrress; 

         }

        private async void Cancel_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Save_Clicked(object sender, System.EventArgs e)
        {
            var shirt = BindingContext as TshirtItem;
            var tshirtDb = App.Database;

            await tshirtDb.SaveItemAsync(shirt);
            await Navigation.PushAsync(new TshirtPage());

        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new OrderList());
        }
    }
}