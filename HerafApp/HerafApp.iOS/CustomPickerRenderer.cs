using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using HerafApp.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Picker), typeof(CustomPickerRenderer))]
namespace HerafApp.iOS
{
    public class CustomPickerRenderer : PickerRenderer
    {

        public CustomPickerRenderer()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.TextAlignment = UITextAlignment.Center;
                UIPickerView pickerView = (UIPickerView)Control.InputView;


                // get the button Done and rewrite the event
                UIToolbar toolbar = (UIToolbar)Control.InputAccessoryView;

                UIBarButtonItem done = new UIBarButtonItem(App.ok, UIBarButtonItemStyle.Done, (object sender, EventArgs click) =>
                {

                    MessagingCenter.Send<Object>(this, "Ok_Clicked");

                });

                UIBarButtonItem cancel = new UIBarButtonItem(UIBarButtonSystemItem.Cancel, (object sender, EventArgs click) =>
                {

                    MessagingCenter.Send<Object>(this, "Cancel_Clicked");
                });


                UIBarButtonItem empty = new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace, null);

                toolbar.Items = new UIBarButtonItem[] { cancel, empty, done };
            }

        }
    }
}