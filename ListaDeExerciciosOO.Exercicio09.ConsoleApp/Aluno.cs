using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio09.ConsoleApp
{
    internal class Aluno
    {
        public int Nota, notasDivididas, totalDasMedias,quantidadeAbsolutadeNotas;
        public int TotalDeNotas = 1;
        public List<int> notas = new List<int>();
        public List<int> mediaNotas = new List<int>();
        public int MediaHarmonica
        {
            private set { }
            get 
            { 
                return CalculaMediaHarmonica();
            }
        }
        private void CalculaMediaNotas()
        {
            foreach (var nota in notas)
            {
                notasDivididas = TotalDeNotas / nota;
                mediaNotas.Add(notasDivididas);
            }
        }
        private int CalculaTOtalDeMedias()
        {
            foreach (var medias in mediaNotas)
            {
                totalDasMedias += medias;
            }
            return totalDasMedias;

        }
        public int CalculaMediaHarmonica()
        {
            CalculaMediaNotas(); 
            CalculaTOtalDeMedias();
            quantidadeAbsolutadeNotas = notas.Count * TotalDeNotas;
            return quantidadeAbsolutadeNotas / totalDasMedias;

        }            
    }
}
