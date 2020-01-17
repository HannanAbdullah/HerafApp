using HerafApp.Resources;
using HerafApp.Views.Customer;
using HerafApp.Views.Handicraft;
using Plugin.Multilingual;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HerafApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SigninPage : ContentPage
    {
        public SigninPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (App.language.Equals("ar"))
                this.FlowDirection = FlowDirection.RightToLeft;
            else
                this.FlowDirection = FlowDirection.LeftToRight;

                pageTitle.Text = AppResources.loginPage;
                message.Text = AppResources.loginMessage;
                welcome.Text = AppResources.welcome;
                phoneEntry.Placeholder = AppResources.phoneEntry;
                passwordEntry.Placeholder = AppResources.passwordEntry;
                forgetPassword.Text = AppResources.forgetPassword;
                loginButton.Text = AppResources.loginButton;
                signupButton.Text = AppResources.signupButton;

            CrossMultilingual.Current.CurrentCultureInfo = new System.Globalization.CultureInfo(App.language);
            AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;
        }

        private async void ChangeLanguage_Clicked(object sender, EventArgs e)
        {
            if (App.language.Equals("ar"))
                App.language = "en";
            else
                App.language = "ar";

            await App.Current.MainPage.Navigation.PopAsync();
            await App.Current.MainPage.Navigation.PushAsync(new SigninPage());
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (App.LogedinUser.Equals("Handicraft"))
            {
                await Navigation.PushAsync(new HandicraftMainPage());
            }
            else 
            if (App.LogedinUser.Equals("Customer"))
            {
                await Navigation.PushAsync(new CustomerMainPage());
            }
        }

        private async void SignupButton_Clicked(object sender, EventArgs e)
        {
            if (App.LogedinUser.Equals("Handicraft"))
                await Navigation.PushAsync(new HandicraftSignupPage());
            else
                        if (App.LogedinUser.Equals("Customer"))
                await Navigation.PushAsync(new CustomerSignupPage());
        }

        private async void ShowFprgetPasswordPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgetPasswordPage());
        }
    }
}