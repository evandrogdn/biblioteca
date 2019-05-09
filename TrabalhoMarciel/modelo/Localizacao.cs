using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMarciel.modelo
{
    public class Localizacao
    {
        public int loccodigo { get; set; }
        public string locnome { get; set; }

        public string toString() => locnome;
    }
}
