using HerafApp.Resources;
using Plugin.Multilingual;
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
    public partial class ChangePasswordPage : ContentPage
    {
        public ChangePasswordPage()
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

                pageTitle.Text = AppResources.changePasswordPage;
                message.Text = AppResources.changePasswordMessage;
                passwordEntry.Placeholder = AppResources.passwordEntry;
                confirmPasswordEntry.Placeholder = AppResources.confirmPassword;
                resetPassword.Text = AppResources.changePassword;

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
            await App.Current.MainPage.Navigation.PushAsync(new ChangePasswordPage());
        }

        private async void ResetPasswordButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();

        }
    }
}