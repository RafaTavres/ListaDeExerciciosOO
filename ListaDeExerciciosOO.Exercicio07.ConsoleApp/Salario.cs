using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio07.ConsoleApp
{
    internal class Salario
    {
        public double salarioBase, QuantidadeVendida, Porcentagem;
        public double SalarioTotal
        {
            private set { }
            get 
            { 
              return CalculaSalarioTotalDOVendedor(); 
            }
        }

        private double CalculaSalarioTotalDOVendedor()
        {
            double Perncentual = Porcentagem / 100;
            return salarioBase + QuantidadeVendida * Perncentual;

        }
    }
}
