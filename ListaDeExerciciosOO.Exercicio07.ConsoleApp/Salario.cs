using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio07.ConsoleApp
{
    internal class Salario
    {
        private double salarioBase, QuantidadeVendida, Porcentagem;
        public double SalarioTotal
        {
            private set { }
            get 
            { 
              return CalculaSalarioTotalDOVendedor(); 
            }
        }

        public void PegaDadosDoUsuario()
        {
            Console.Write("-------------\nSalario base: ");
            salarioBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade de dinheiro das Vendas:: ");
            QuantidadeVendida = Convert.ToDouble(Console.ReadLine());
            Console.Write("Percentual ganho sobre as vendas: ");
            Porcentagem = Convert.ToDouble(Console.ReadLine());
        }
        private double CalculaSalarioTotalDOVendedor()
        {
            double Perncentual = Porcentagem / 100;
            return salarioBase + QuantidadeVendida * Perncentual;

        }
    }
}
