using System.ComponentModel.DataAnnotations;

namespace ApiPassagem.Models
{
    public class Passagem
    {
        [Key]
        public int codigo { get; set; }

        public string partida { get; set; }

        public string chegada { get; set; }

        public string data { get; set; }

        public string passageiros { get; set; }
    }
}
