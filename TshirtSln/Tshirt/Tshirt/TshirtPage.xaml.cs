using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            new NavigationPage(new MainPage());
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tGen = new TshirtItem();
            string boom = tGen.Adrress; 
            
        }
    }
}