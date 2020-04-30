using Xamarin.Forms;
using RestauranteApp.View;
using RestauranteApp.Model;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RestauranteApp.ViewModel
{
    public class CardapioPageViewModel : BaseViewModel
    {
        private Cardapio _itemSelected;
        public Command<Cardapio> _selectedCommand;
        private ObservableCollection<Cardapio> _cardapio;

        public ObservableCollection<Cardapio> Cardapio
        {
            get { return _cardapio; }
            set { SetProperty(ref _cardapio, value); }
        }
        public Cardapio ItemSelected
        {
            get { return _itemSelected; }
            set { SetProperty(ref _itemSelected, value); }
        }

        private bool _isCarne;
        public bool IsCarne
        {
            get { return _isCarne; }
            set { SetProperty(ref _isCarne, value); }
        }

        private bool _isFrango;
        public bool IsFrango
        {
            get { return _isFrango; }
            set { SetProperty(ref _isFrango, value); }
        }

        private bool _isMassa;
        public bool IsMassa
        {
            get { return _isMassa; }
            set { SetProperty(ref _isMassa, value); }
        }

        private bool _isPeixe;
        public bool IsPeixe
        {
            get { return _isPeixe; }
            set { SetProperty(ref _isPeixe, value); }
        }

        private bool _isPorcoes;
        public bool IsPorcoes
        {
            get { return _isPorcoes; }
            set { SetProperty(ref _isPorcoes, value); }
        }

        public Command<Cardapio> SelectedCommand => _selectedCommand ?? (_selectedCommand = new Command<Cardapio>(async (cardapio) => await SelectedCommandExecute(cardapio)));
        private async Task SelectedCommandExecute(Cardapio cardapio)
        {
            await App.Current.MainPage.Navigation.PushAsync(new DetalhePage(cardapio), true);
        }

        public CardapioPageViewModel()
        {
            CarregarCardapio();
        }

        private void CarregarCardapio()
        {
            Cardapio = new ObservableCollection<Cardapio>(new List<Cardapio>
            {
                new Cardapio { Foto = "contra_file_pure.png", Nome = "CONTRA FILÉ COM PURE", Avaliacao = 5, Culinaria = "CARNE" },
                new Cardapio { Foto = "costela_caipira.png", Nome = "COSTELA CAIPIRA", Avaliacao = 5, Culinaria = "CARNE" },
                new Cardapio { Foto = "picanha.png", Nome = "PICANHA", Avaliacao = 5, Culinaria = "CARNE" },
                new Cardapio { Foto = "frango_com_pure.png", Nome = "FRANGO COM PURÊ", Avaliacao = 5, Culinaria = "FRANGO" },
                new Cardapio { Foto = "frango_com_tomate_seco.png", Nome = "FRANGO COM TOMATE SECO", Avaliacao = 5, Culinaria = "FRANGO" },
                new Cardapio { Foto = "frango_light.png", Nome = "FRANGO LIGHT", Avaliacao = 5, Culinaria = "FRANGO" },
                new Cardapio { Foto = "pene_ao_alho_e_oleo.png", Nome = "PENE AO ALHO E ÓLEO", Avaliacao = 5, Culinaria = "MASSA" },
                new Cardapio { Foto = "pene_com_frango.png", Nome = "PENE COM FRANGO", Avaliacao = 5, Culinaria = "MASSA" },
                new Cardapio { Foto = "pene_com_frango_milanesa.png", Nome = "PENE COM FRANGO A MILANESA", Avaliacao = 5, Culinaria = "MASSA" },
                new Cardapio { Foto = "pene_integral.png", Nome = "PENE INTEGRAL", Avaliacao = 5, Culinaria = "MASSA" },
                new Cardapio { Foto = "talharim_ao_molho_2_queijos.png", Nome = "TALHARIM AO MOLHO 2 QUEIJOS", Avaliacao = 5, Culinaria = "MASSA" },
                new Cardapio { Foto = "tilapia_empanada.png", Nome = "TILÁPIA EMPANADA", Avaliacao = 5, Culinaria = "PEIXE" },
                new Cardapio { Foto = "medalhao_com_frango.png", Nome = "MEDALHÃO COM FRANGO", Avaliacao = 5, Culinaria = "PORCÕES" },
                new Cardapio { Foto = "tilapias_com_fritas.png", Nome = "TILÁPIA COM FRITAS", Avaliacao = 5, Culinaria = "PORCÕES" },
                new Cardapio { Foto = "coxinha_molho.png", Nome = "COXINHA COM MOLHO BARBECUE", Avaliacao = 5, Culinaria = "PORCÕES" }
            });
        }
    }
}
