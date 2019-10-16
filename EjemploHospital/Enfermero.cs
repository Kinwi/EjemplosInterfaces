using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploHospital
{
    class Enfermero:Sanitario
    {

        public int Puesto { get; set; }

        public Enfermero(int puesto,string dni,string nombre,int sueldoBase,int edad):base(dni,nombre,sueldoBase,edad)
        {
            Puesto = puesto;
        }

        public override  double calculaSueldo()
        {
            // 1 .UCI 

            if (Puesto == 1)
            {
                return SueldoBase + 200;
            }

            // NO UCI (EL RESTO DE NUMEROS)
            else
            {
                return SueldoBase;
            }
           

        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($" {Puesto}");
            Console.WriteLine($" Sueldo Final :{calculaSueldo()}");

        }
    }
}
