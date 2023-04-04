namespace ListaDeExerciciosOO.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Console.WriteLine("Calculdadora de volume de uma Caixa Retangular \n------------------");
            while (resposta.ToUpper() != "S")
            {
                CaixaRetangular caixa = new CaixaRetangular();
                caixa.PegaValoresDosComprimentodDaCaixa();
                Console.WriteLine("Volume de " + caixa.VolumeDaCaixa + " m³");
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

            }
        }
    }
}