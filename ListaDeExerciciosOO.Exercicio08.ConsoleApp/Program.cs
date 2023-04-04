namespace ListaDeExerciciosOO.Exercicio08.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Console.WriteLine("Calculdadora de volume de uma Lata de óleo\n------------------");
            while (resposta.ToUpper() != "S")
            {
                LataDeOleo lataDeOleo = new LataDeOleo();
                lataDeOleo.PegaValorDosLadosDoUsuario();
                Console.WriteLine("Volume de " + lataDeOleo.Volume + "m³");
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }
        }
    }
}