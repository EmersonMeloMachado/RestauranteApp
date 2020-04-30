using RestauranteApp.Model;

namespace RestauranteApp.ViewModel
{
    public class DetalhePageViewModel : BaseViewModel
    {
        private Cardapio _cardapio;

        public Cardapio Cardapio
        {
            get { return _cardapio; }
            set { SetProperty(ref _cardapio, value); }
        }

        public DetalhePageViewModel()
        {

        }
    }
}
