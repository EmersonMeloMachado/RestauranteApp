using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;
using RestauranteApp.ViewModel;
using System.Collections.Generic;

namespace RestauranteApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardapioPage : ContentPage
    {
        bool _achou = true;
        public CardapioPage()
        {
            InitializeComponent();
            BindingContext = new CardapioPageViewModel();
        }

        private async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            if (_achou)
            {
                Tipo1.IsVisible = true;
                Tipo2.IsVisible = true;
                await Task.WhenAll(new List<Task>
                {
                    stack.LayoutTo(new Rectangle(stack.Bounds.X, stack.Bounds.Y, stack.Bounds.Width, 100), 300, Easing.CubicOut),
                    lCardapio.TranslateTo(0, lCardapio.HeightRequest = 110, 300, Easing.CubicOut)
                });

                _achou = false;
            }
            else
            {
                Tipo1.IsVisible = false;
                Tipo2.IsVisible = false;
                await Task.WhenAll(new List<Task>
                {
                    stack.LayoutTo(new Rectangle(stack.Bounds.X,stack.Bounds.Y, stack.Bounds.Width, 0), 300, Easing.CubicIn),
                    lCardapio.TranslateTo(0, lCardapio.HeightRequest = 0, 600, Easing.CubicOut)
                });
                _achou = true;
            }
        }

        private void txtPesquisa_Unfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisa.Text))
                lblLupa.TranslateTo(0, 0, 1500, Easing.SinIn);
        }

        private void txtPesquisa_Focused(object sender, FocusEventArgs e)
        {
            lblLupa.TranslateTo(txtPesquisa.Width, 0, 1500, Easing.SinIn);
        }
    }
}