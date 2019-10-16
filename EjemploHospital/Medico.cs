using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploHospital
{
    class Medico:Sanitario
    {

        public string Especialidad { get; set; }
        public int NumeroPacientes { get; set; }

        public Medico(string especialidad, int numeroPacientes,string dni, string nombre,double sueldoBase,int edad):base(dni,nombre,sueldoBase,edad)
        {
            Especialidad = especialidad;
            NumeroPacientes = numeroPacientes;
        }

        public override double calculaSueldo()
        {

            return SueldoBase + (NumeroPacientes * 1.20);
            
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"{Especialidad}   {NumeroPacientes}");
        }
    }
}
