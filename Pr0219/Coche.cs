using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr0219
{
    internal class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }


        public String getMarcaYModelo
        {
            get { return Marca + " " + Modelo; }
        }
    }
}
