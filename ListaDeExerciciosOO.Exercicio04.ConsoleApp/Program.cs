namespace ListaDeExerciciosOO.Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Console.WriteLine("Calculdadora de consumo de combustível por Km\n------------------");
            while (resposta.ToUpper() != "S")
            {
                ConsumoGasolina consumo = new ConsumoGasolina();
                consumo.PegaOsDadosDoUsuario();

                Console.WriteLine("Resultado: " + consumo.QuantidadeGastaDeGasolina + " Km/L");

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();
            }
        }

        
    }
}