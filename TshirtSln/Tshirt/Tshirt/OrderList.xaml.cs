using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tshirt;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TshirtGuy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderList : ContentPage
    {
        public List<TshirtItem> tshirtItems;
        public OrderList()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var shirtss = App.Database;
            tshirtItems = await shirtss.GetTshirtItemAsync();
            BindingContext = this;
        }
    }
}