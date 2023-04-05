using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio04.ConsoleApp
{
    internal class ConsumoGasolina
    {
        public double Gasolinagasta, kilometInicial, kilometFinal;
        public double QuantidadeGastaDeGasolina
        {
            private set { }
            get 
            {
                return CalculaConsumoDeGasolina();
            }
        }

        private double CalculaConsumoDeGasolina()
        {
            return Gasolinagasta / (kilometFinal - kilometInicial);
        }
    }
}
