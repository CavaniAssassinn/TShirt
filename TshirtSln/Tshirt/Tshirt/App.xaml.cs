using System;
using System.IO;
using Xamarin.Forms;

namespace Tshirt
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
          //  DependencyService.Register<Storage>();
            MainPage = new NavigationPage (new MainPage());
        }
        static DatabaseTshirt database;
        public static DatabaseTshirt Database
        {
            get
            {
                if (Database == null)
                {
                    database = new DatabaseTshirt(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }
        public int boom { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
