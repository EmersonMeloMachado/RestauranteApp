using UIKit;
using System;
using CoreGraphics;
using Xamarin.Forms;
using RestauranteApp.Custom;
using RestauranteApp.iOS.Renderers;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace RestauranteApp.iOS.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control == null || this.Element == null) return;
            if (this.Element != null)
            {
                var view = (CustomEntry)Element;

                Control.LeftView = new UIView(new CGRect(0f, 0f, 9f, 20f));
                Control.LeftViewMode = UITextFieldViewMode.Always;
                Control.KeyboardAppearance = UIKeyboardAppearance.Dark;
                Control.ReturnKeyType = UIReturnKeyType.Done;
                Control.Layer.CornerRadius = Convert.ToSingle(view.CornerRadius);
                Control.Layer.BorderColor = view.BorderColor.ToCGColor();
                Control.Layer.BorderWidth = view.BorderWidth;
                Control.ClipsToBounds = true;

                if (view.IsVisibleBorder == false)
                {
                    this.Control.LeftView = new UIView(new CGRect(0, 0, 8, this.Control.Frame.Height));
                    this.Control.RightView = new UIView(new CGRect(0, 0, 8, this.Control.Frame.Height));
                    this.Control.LeftViewMode = UITextFieldViewMode.Always;
                    this.Control.RightViewMode = UITextFieldViewMode.Always;

                    this.Control.BorderStyle = UITextBorderStyle.None;
                    this.Element.HeightRequest = 30;
                }
            }
        }
    }
}