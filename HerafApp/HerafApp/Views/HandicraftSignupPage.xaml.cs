﻿using HerafApp.Resources;
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
    public partial class HandicraftSignupPage : ContentPage
    {
        public static CheckBox AgreeCheckbox = new CheckBox() ;

        public HandicraftSignupPage()
        {
            InitializeComponent();
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
            }
            else
            { 
                this.FlowDirection = FlowDirection.LeftToRight;
                agreement.Margin = new Thickness(-10, 10, 0, 10);
            }

            pageTitle.Text = AppResources.handicraftSignupPage;
            handicraftInfo.Text = AppResources.userInfo;
            mandatoryUserInfo.Text = AppResources.mandatory;
            userName.Placeholder = AppResources.userName;
            email.Placeholder = AppResources.email;
            phoneEntry.Placeholder = AppResources.phoneEntry;
            password.Placeholder = AppResources.passwordEntry;
            confirmPassword.Placeholder = AppResources.confirmPassword;
            instagram.Placeholder = AppResources.instagram;
            cityPicker.Title = AppResources.cityPicker;
            visaCard.Text = AppResources.visaCard;
            mandatoryVisaCard.Text = AppResources.mandatory;
            visaUserName.Placeholder = AppResources.visaUserName;
            visaCardNumber.Placeholder = AppResources.visaCardNumber;
            bankCard.Text = AppResources.bankCard;
            mandatoryBankCard.Text = AppResources.mandatory;
            bankUserName.Placeholder = AppResources.visaUserName;
            iban.Placeholder = AppResources.iban;
            signupButton.Text = AppResources.signupButton;
            bankName.Placeholder = AppResources.bankName;
            agreement.Text = AppResources.agreement;

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
            await App.Current.MainPage.Navigation.PushAsync(new HandicraftSignupPage( ));
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