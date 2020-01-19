using HerafApp.Views;
using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HerafApp
{
    public partial class App : Application
    {
        public static string language = CultureInfo.CurrentCulture.Name.Substring(0, 2);
        public static string LogedinUser="Guest";

        public App()
        {
            InitializeComponent();
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#C7B299");
            ((NavigationPage)Application.Current.MainPage).BarTextColor= Color.FromHex("#5C6E58");
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
