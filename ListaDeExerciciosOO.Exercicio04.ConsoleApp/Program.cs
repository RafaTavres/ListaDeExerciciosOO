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
                Viagem viagem = new Viagem();
                Console.WriteLine("Comsumo do carro por Km: ");
                viagem.Gasolinagasta = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kilometragem Inicial");
                viagem.kilometInicial = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kilometragem final");
                viagem.kilometFinal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Resultado: " + viagem.QuantidadeGastaDeGasolina + " Km/L");

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();           
            }
        }

        
    }
}