using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio08.ConsoleApp
{
    internal class LataDeOleo
    {
        private double raio, altura;
        public double Volume
        {
            private set { }
            get
            {
                return CalculaVolumeDoCilindro();
            }
        }

        public void PegaValorDosLadosDoUsuario()
        {
            Console.Write("Raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
        }
        private double CalculaVolumeDoCilindro()
        {
            return Math.Round(Math.PI, 2) * Math.Pow(raio, 2) * altura;
        }
    }
}
