using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.ConsoleApp
{
    public class CaixaRetangular
    {
        private double altura;
        private double largura;
        private double comprimento;
        public double VolumeDaCaixa 
        {
            private set { }

            get 
            {
                return CalculaVolumeDaCaixa();
            }
                   
        }

        public void PegaValoresDosComprimentodDaCaixa()
        {
            Console.Write("Comprimento: ");
             comprimento = Convert.ToDouble(Console.ReadLine());
            Console.Write("Largura: ");
             largura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura: ");
             altura = Convert.ToDouble(Console.ReadLine());
            VerificaSeValoresSaoMaioresQue0();
        }
        public double CalculaVolumeDaCaixa()
        {
            return altura * largura * comprimento;
        }
        public void VerificaSeValoresSaoMaioresQue0()
        {
            if (comprimento == 0 || largura == 0 || altura == 0)
            {
                Console.WriteLine("Erro: Números de Medida nao podem ser 0");
                return;
            }
        }

    }
}
