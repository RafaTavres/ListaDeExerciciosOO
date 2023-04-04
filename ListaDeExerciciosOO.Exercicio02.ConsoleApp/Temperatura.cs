using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio02.ConsoleApp
{
    internal class Temperatura
    {
        private double fahrenheint;
        public double Celsiu 
        {
            private set
            { }
            get
            {
                return TransformaFahrenheintEmCelsiu();
            }
        }

        public double PegaFahrenheintDoUsuario()
        {
            Console.Write("-------------\nTemperatura em F°: ");
            fahrenheint = Convert.ToDouble(Console.ReadLine());
            return fahrenheint;
        }
        private double TransformaFahrenheintEmCelsiu()
        {
            return (fahrenheint - 32) / 1.8;
        }
    }
}
