using HerafApp.Resources;
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
    public partial class CustomerSignupPage : ContentPage
    {
        public static CheckBox AgreeCheckbox;

        public CustomerSignupPage()
        {
            InitializeComponent();
            AgreeCheckbox = new CheckBox();
            AgreeCheckbox = agreeCheckbox;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            PopupNavigation.Instance.PushAsync(new AgreementPopUp());

            if (App.language.Equals("ar"))
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                agreement.Margin = new Thickness(0, 10, -10, 10);
                cityPicker.FlowDirection = FlowDirection.RightToLeft;

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                agreement.Margin = new Thickness(-10, 10, 0, 10);
                cityPicker.FlowDirection = FlowDirection.LeftToRight ;
            }
            App.cancel = AppResources.cancel;
            App.ok = AppResources.ok;
            pageTitle.Text = AppResources.customerSignupPage;
            customerInfo.Text = AppResources.userInfo;
            userName.Placeholder = AppResources.userName;
            email.Placeholder = AppResources.email;
            phoneEntry.Placeholder = AppResources.phoneEntry;
            password.Placeholder = AppResources.passwordEntry;
            confirmPassword.Placeholder = AppResources.confirmPassword;
            cityPicker.Title = AppResources.cityPicker;
            monthPicker.Title = AppResources.monthPicker;
            yearPicker.Title = AppResources.yearPicker;
            visaCard.Text = AppResources.visaCard;
            visaUserName.Placeholder = AppResources.visaUserName;
            visaCardNumber.Placeholder = AppResources.visaCardNumber;
            signupButton.Text = AppResources.signupButton;
            agreement.Text = AppResources.agreement;
            mandatoryUserInfo.Text = AppResources.mandatory;
            mandatoryVisaCard.Text = AppResources.notMandatory;


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
            await App.Current.MainPage.Navigation.PushAsync(new CustomerSignupPage());
        }

        private async void SignupButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new SigninPage());
        }

        private void ShowAgreementPopup_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new AgreementPopUp());
        }


    }
}