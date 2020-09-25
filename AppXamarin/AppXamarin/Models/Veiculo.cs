using System;
using System.Collections.Generic;
using System.Text;

namespace AppXamarin.Models
{
    public class Veiculo
    {
        public const decimal FREIO_ABS = 800, AR_CONDICIONADO = 1000, MP3_PLAYER = 500;
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco); }
        }

        public bool TemFreioABS { get; set; }
        public bool TemMP3PLAYER { get; set; }
        public bool TemArCondicionado { get; set; }

        public string PrecoTotalFormatado
        {
            get
            {
                return string.Format("Valor Total: {0}", Preco
                   + (TemFreioABS ? FREIO_ABS : 0) + (TemArCondicionado ? AR_CONDICIONADO : 0)
                   + (TemMP3PLAYER ? MP3_PLAYER : 0));
            }
        }
    }
}

