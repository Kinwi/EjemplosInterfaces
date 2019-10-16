using System;
using System.Collections.Generic;

namespace EjemploHospital
{
    class Program
    {
        static void Main(string[] args)
        {

            Medico m1 = new Medico("Cirujano", 200, "45820597C", "Raul", 2578.67, 33);
            Medico m2 = new Medico("Traumatologo", 500, "76520597C", "Pedro", 2578.67, 33);
            Enfermero e1 = new Enfermero(1, "76520597C","Raul",1565,35);
            Enfermero e2 = new Enfermero(1, "76520597C", "Manoli", 1565, 48);
            Enfermero e3 = new Enfermero(2, "67820597C", "Juan", 1565, 67);

            List<Sanitario> sanitarios = new List<Sanitario>();
            sanitarios.Add(m1);
            sanitarios.Add(m2);
            sanitarios.Add(e1);
            sanitarios.Add(e2);
            sanitarios.Add(e3);


            foreach (Sanitario sanitario in sanitarios)
            {

                sanitario.Mostrar();


            }

            foreach (Sanitario sanitario in sanitarios)
            {

                sanitario.SueldoBase = sanitario.SueldoBase * 1.01;     

            }

            foreach (Sanitario sanitario in sanitarios)
            {

                sanitario.Mostrar();
            }


            foreach (Sanitario sanitario in sanitarios)
            {
                if (sanitario.jubilable())
                {
                    sanitario.Mostrar();
                }
                adsad
            }



        }
    }
}
