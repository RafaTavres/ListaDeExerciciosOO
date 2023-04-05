using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio03.ConsoleApp
{
    internal class Cilindro
    {
        public double raio, altura;
        public double Volume
        {
            private set { }
            get 
            {
                return CalculaVolumeDoCilindro(); 
            }
        }

        private double CalculaVolumeDoCilindro()
        {
            return Math.Round(Math.PI, 2) * Math.Pow(raio, 2) * altura;
        }
    }
}
