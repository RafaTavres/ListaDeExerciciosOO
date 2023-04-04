using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio04.ConsoleApp
{
    internal class ConsumoGasolina
    {
        private double Gasolinagasta, kilometInicial, kilometFinal;
        public double QuantidadeGastaDeGasolina
        {
            private set { }
            get 
            {
                return CalculaConsumoDeGasolina();
            }
        }

        public void PegaOsDadosDoUsuario()
        {
            Console.WriteLine("Comsumo do carro por Km: ");
            Gasolinagasta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilometragem Inicial");
            kilometInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilometragem final");
            kilometFinal = Convert.ToDouble(Console.ReadLine());
        }
        private double CalculaConsumoDeGasolina()
        {
            return Gasolinagasta / (kilometFinal - kilometInicial);
        }
    }
}
