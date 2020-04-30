using Xamarin.Forms;

namespace RestauranteApp.Custom
{
    public class CustomEntry : Entry
    {
        public CustomEntry()
        {
            this.HeightRequest = 50;
        }

        public static readonly BindableProperty EntryBorderColorProperty =
        BindableProperty.Create(
            nameof(BorderColor),
            typeof(Color),
            typeof(CustomEntry),
            Color.Gray);

        public Color BorderColor
        {
            get { return (Color)GetValue(EntryBorderColorProperty); }
            set { SetValue(EntryBorderColorProperty, value); }
        }

        public static readonly BindableProperty CornerRadiusProperty =
        BindableProperty.Create(
            nameof(CornerRadius),
            typeof(double),
            typeof(CustomEntry));

        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty IsSelectedProperty =
        BindableProperty.Create(
            nameof(IsSelected),
            typeof(bool),
            typeof(CustomEntry),
            false,
            BindingMode.TwoWay);

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        public static readonly BindableProperty LineColorProperty =
        BindableProperty.Create(
             nameof(LineColor),
             typeof(Color),
             typeof(CustomEntry),
             Color.White);

        public Color LineColor
        {
            get { return (Color)GetValue(LineColorProperty); }
            set { SetValue(LineColorProperty, value); }
        }

        public static readonly BindableProperty BorderWidthProperty =
        BindableProperty.Create(
           nameof(BorderWidth),
           typeof(int),
           typeof(CustomEntry));

        public int BorderWidth
        {
            get { return (int)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        public static readonly BindableProperty IsCurvedCornersEnabledProperty =
        BindableProperty.Create(
            nameof(IsCurvedCornersEnabled),
            typeof(bool),
            typeof(CustomEntry),
            true);

        public bool IsCurvedCornersEnabled
        {
            get { return (bool)GetValue(IsCurvedCornersEnabledProperty); }
            set { SetValue(IsCurvedCornersEnabledProperty, value); }
        }

        public static readonly BindableProperty IsVisibleBorderProperty =
        BindableProperty.Create(
            nameof(IsVisibleBorder),
            typeof(bool),
            typeof(CustomEntry),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: true);

        public bool IsVisibleBorder
        {
            get { return (bool)GetValue(IsVisibleBorderProperty); }
            set { SetValue(IsVisibleBorderProperty, value); }
        }
    }
}
