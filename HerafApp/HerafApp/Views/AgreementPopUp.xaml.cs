using HerafApp.Resources;
using Plugin.Multilingual;
using Rg.Plugins.Popup.Pages;
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
    public partial class AgreementPopUp : PopupPage
    {
        public AgreementPopUp()
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

            pageTitle.Text = AppResources.agreementPopup;
            appPolicy.Text = AppResources.appPolicy;
            appTerms.Text = AppResources.appTerms;
            donotAgreeButton.Text = AppResources.donotAgreeButton;
            agreeButton.Text = AppResources.agreeButton;

            CrossMultilingual.Current.CurrentCultureInfo = new System.Globalization.CultureInfo(App.language);
            AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;
        }

        private async void AgreeButton_Clicked(object sender, EventArgs e)
        {

            if (App.LogedinUser.Equals("Handicraft"))
                HandicraftSignupPage.AgreeCheckbox.IsChecked = true;
             else
             if (App.LogedinUser.Equals("Customer"))
                CustomerSignupPage.AgreeCheckbox.IsChecked = true;

            await PopupNavigation.Instance.PopAsync();

        }

        private async void DonotAgreeButton_Clicked(object sender, EventArgs e)
        {
            if (App.LogedinUser.Equals("Handicraft"))
                HandicraftSignupPage.AgreeCheckbox.IsChecked = false;
            else
             if (App.LogedinUser.Equals("Customer"))
                CustomerSignupPage.AgreeCheckbox.IsChecked = false;

            await PopupNavigation.Instance.PopAsync();
        }
    }
}