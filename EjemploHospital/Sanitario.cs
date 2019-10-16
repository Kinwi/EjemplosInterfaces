using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploHospital
{
    class Sanitario:IPersonalLaboral
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public double SueldoBase { get; set; }
        public int Edad{ get; set; }

        public Sanitario(string dNI, string nombre, double sueldoBase, int edad)
        {
            DNI = dNI;
            Nombre = nombre;
            SueldoBase = sueldoBase;
            Edad = edad;

        }



            public virtual void Mostrar()
            {
            Console.WriteLine($"{DNI}{Nombre} {Edad} {SueldoBase}");

            }

        public bool jubilable()
        {
            if (Edad >= 65)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual double calculaSueldo()
        {
            return SueldoBase;
        }
    }
}
