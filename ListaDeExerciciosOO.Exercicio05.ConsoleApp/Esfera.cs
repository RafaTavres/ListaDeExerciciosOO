using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio05.ConsoleApp
{
    internal class Esfera
    {

        public double raio;
        public double VolumeDaEsfera
        {
            private set { }
            get 
            { 
                return CalculaVolumeDaEsfera(); 
            }
        }

        private double CalculaVolumeDaEsfera()
        {
            return (4 * Math.Round(Math.PI, 2) * Math.Pow(raio, 3)) / 3;
        }
    }
}
