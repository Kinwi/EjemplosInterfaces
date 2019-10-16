using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosInterfaces
{
    class VehiculoTerrestre
    {
        public int Caballos { get; set; }

        public VehiculoTerrestre(int caballos,string marca,string modelo):base(caballos,marca,modelo)
        {
            Caballos = caballos;
        }
    }
}
