using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio02.ConsoleApp
{
    internal class TemperaturaFahrenheit
    {
        public double fahrenheint;
        public double ValorEmCelsiu 
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
