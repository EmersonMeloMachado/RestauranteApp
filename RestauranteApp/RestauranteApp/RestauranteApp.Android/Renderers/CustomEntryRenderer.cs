using Android.Util;
using Xamarin.Forms;
using Android.Content;
using RestauranteApp.Custom;
using Android.Graphics.Drawables;
using RestauranteApp.Droid.Renderers;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace RestauranteApp.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        CustomEntry element;

        public CustomEntryRenderer(Context context) : base(context)
        { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            if (e.NewElement != null)
            {
                element = (CustomEntry)Element;

                if (element.IsCurvedCornersEnabled)
                {
                    var _gradientBackground = new GradientDrawable();
                    _gradientBackground.SetShape(ShapeType.Rectangle);
                    _gradientBackground.SetColor(element.BackgroundColor.ToAndroid());

                    _gradientBackground.SetStroke(element.BorderWidth, element.BorderColor.ToAndroid());

                    _gradientBackground.SetCornerRadius(
                        DpToPixels(this.Context,
                            System.Convert.ToSingle(element.CornerRadius)));

                    Control.SetBackground(_gradientBackground);
                }

                Control.CompoundDrawablePadding = 25;
                Control.SetPadding(
                    (int)DpToPixels(this.Context, System.Convert.ToSingle(5)),
                    Control.PaddingTop,
                    (int)DpToPixels(this.Context, System.Convert.ToSingle(5)),
                    Control.PaddingBottom);
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control == null) return;

            if (e.PropertyName == CustomEntry.IsSelectedProperty.PropertyName)
                UpdateBorders(element);
        }

        void UpdateBorders(CustomEntry element)
        {
            GradientDrawable shape = new GradientDrawable();
            shape.SetShape(ShapeType.Rectangle);
            shape.SetCornerRadius(1);

            shape.SetStroke(2, Android.Graphics.Color.LightGray);
            this.Control.SetBackground(shape);
        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}