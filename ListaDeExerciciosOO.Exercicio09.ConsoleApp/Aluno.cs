using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio09.ConsoleApp
{
    internal class Aluno
    {
        private int Nota, notasDivididas, totalDasMedias,quantidadeAbsolutadeNotas;
        private int TotalDeNotas = 1;
        private List<int> notas = new List<int>();
        private List<int> mediaNotas = new List<int>();
        public int MediaHarmonica
        {
            private set { }
            get 
            { 
                return CalculaMediaHarmonica();
            }
        }
        public void PegaNotas()
        {
            Console.WriteLine("Nota: ");
            Nota = Convert.ToInt32(Console.ReadLine());
            TotalDeNotas *= Nota;
            notas.Add(Nota);

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
            Console.WriteLine("--------------------------------");
            quantidadeAbsolutadeNotas = notas.Count * TotalDeNotas;
            return quantidadeAbsolutadeNotas / totalDasMedias;

        }            
    }
}
