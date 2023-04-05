using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio10.ConsoleApp
{
    internal class Aluno
    {
        public int prova1, prova2, PesodaProva1, PesodaProva2;
        public int MediaPonderada
        {
            private set { }
            
            get 
            { 
                return CalculaMediaPonderada();
            }
        }

        private int CalculaMediaPonderada()
        {
           return ((prova1 * PesodaProva1) + (prova2 * PesodaProva2)) / (PesodaProva1 + PesodaProva2);

        }
    }
}
