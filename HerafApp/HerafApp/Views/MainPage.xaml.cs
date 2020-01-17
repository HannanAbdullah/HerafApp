using HerafApp.Resources;
using HerafApp.Views.Customer;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HerafApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public  MainPage()
        {
            InitializeComponent();          
        }




        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (App.language.Equals("ar"))
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                handicraftLogin1.Text = AppResources.login;
                handicraftLogin2.Text = AppResources.handicraft;
                customerLogin1.Text = AppResources.login;
                customerLogin2.Text = AppResources.customer;
                guest.Text = AppResources.guest;
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                handicraftLogin1.Text = AppResources.handicraft;
                handicraftLogin2.Text = AppResources.login;
                customerLogin1.Text = AppResources.customer;
                customerLogin2.Text = AppResources.login;
                guest.Text = AppResources.guest;
            }

            CrossMultilingual.Current.CurrentCultureInfo = new System.Globalization.CultureInfo(App.language);
            AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;
        }

        private void CallButton_Clicked(object sender, EventArgs e)
        {
           
                try
                {
                    PhoneDialer.Open("+966551090110");
                }
                catch (FeatureNotSupportedException ex)
                {
                    // Phone Dialer is not supported on this device.
                }
                catch (Exception ex)
                {
                ;// Other error has occurred.
                }
        }

        [Obsolete]
        private void FacebookButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/BIParks"));
        }

        [Obsolete]
        private void TwitterButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/HananAbdullah_4"));
        }

        [Obsolete]
        private void InstagramButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com/hanoon_a/"));
        }

        private async void HandicraftsLoginButton_Clicked(object sender, EventArgs e)
        {
            App.LogedinUser ="Handicraft";
             await Navigation.PushAsync(new SigninPage());
        }

        private async void CustomersLoginButton_Clicked(object sender, EventArgs e)
        {
            App.LogedinUser = "Customer";
            await Navigation.PushAsync(new SigninPage());

        }

        private async void GuestLoginButton_Clicked(object sender, EventArgs e)
        {
            App.LogedinUser = "Guest";
            await Navigation.PushAsync(new CraftsPage());
        }
    }
}