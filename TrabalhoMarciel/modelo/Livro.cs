using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMarciel.modelo
{
    public class Livro
    {
        public int livcodigo { get; set; }
        public string livnome { get; set; }
        public int genero { get; set; }
        public int localizacao { get; set;}

        public string toString() => livnome;
    }
}
