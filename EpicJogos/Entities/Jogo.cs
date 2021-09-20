using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpicJogos.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Editora { get; set; }
        public double Preco { get; set; }
    }
}
