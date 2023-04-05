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
                Console.WriteLine("Comsumo do carro por Km: ");
                consumo.Gasolinagasta = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kilometragem Inicial");
                consumo.kilometInicial = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kilometragem final");
                consumo.kilometFinal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Resultado: " + consumo.QuantidadeGastaDeGasolina + " Km/L");

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();           
            }
        }

        
    }
}