using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio02.ConsoleApp
{
    internal class Temperatura
    {
        public double fahrenheint;
        public double Celsiu 
        {
            private set
            { }
            get
            {
                return TransformaFahrenheintEmCelsiu();
            }
        }
        private double TransformaFahrenheintEmCelsiu()
        {
            return (fahrenheint - 32) / 1.8;
        }
    }
}
