using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteApp.Model
{
    public class Cardapio
    {
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string Culinaria { get; set; }
        public double? Avaliacao { get; set; }
        public string Nota
        {
            get { return Avaliacao.HasValue ? Avaliacao.Value.ToString("N1") : string.Empty; }
        }
    }
}
