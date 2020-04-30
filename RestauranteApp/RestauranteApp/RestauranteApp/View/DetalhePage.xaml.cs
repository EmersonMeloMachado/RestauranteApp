using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestauranteApp.Model;
using System.Threading.Tasks;
using RestauranteApp.ViewModel;

namespace RestauranteApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhePage : ContentPage
    {
        DetalhePageViewModel viewModel = null;

        #region Constructors

        public DetalhePage(Cardapio cardapio)
        {
            InitializeComponent();

            viewModel = new DetalhePageViewModel();
            viewModel.Cardapio = cardapio;
            BindingContext = viewModel;
        }
        
        #endregion Constructors

        #region Methods

        async Task RotateImageContinously()
        {
            while (true)
            {
                await Imagen_01.RotateTo(360, 5000, Easing.Linear);
                await Imagen_01.RotateTo(0, 0);
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await RotateImageContinously();
        }

        #endregion Methods
    }
}