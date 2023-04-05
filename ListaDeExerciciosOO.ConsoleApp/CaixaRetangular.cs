using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.ConsoleApp
{
    public class CaixaRetangular
    {
        public double altura;
        public double largura;
        public double comprimento;
        public double VolumeDaCaixa 
        {
            private set { }

            get 
            {
                return CalculaVolumeDaCaixa();
            }
                   
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
