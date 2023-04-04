using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio10.ConsoleApp
{
    internal class Aluno
    {
        private int prova1, prova2, PesodaProva1, PesodaProva2;
        public int MediaPonderada
        {
            private set { }
            
            get 
            { 
                return CalculaMediaPonderada();
            }
        }


        public void PegaDadosDoUsuario()
        {
            Console.WriteLine("Nota da Prova 1: ");
            prova1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Peso da Prova 1: ");
            PesodaProva1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nota da Prova 2: ");
            prova2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Peso da Prova 2: ");
            PesodaProva2 = Convert.ToInt32(Console.ReadLine());
        }
        private int CalculaMediaPonderada()
        {
           return ((prova1 * PesodaProva1) + (prova2 * PesodaProva2)) / (PesodaProva1 + PesodaProva2);

        }
    }
}
