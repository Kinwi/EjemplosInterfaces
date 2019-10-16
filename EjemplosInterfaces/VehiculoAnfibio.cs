using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosInterfaces
{
    class VehiculoAnfibio
    {
        public int MetrosSumergible { get; set; }

        public VehiculoAnfibio(int metroSumergible,string marca,string modelo):base(marca,modelo)
    }
}
