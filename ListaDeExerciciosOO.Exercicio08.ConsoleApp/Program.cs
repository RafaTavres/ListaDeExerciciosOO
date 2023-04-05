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

                Console.Write("Raio: ");
                lataDeOleo.raio = Convert.ToDouble(Console.ReadLine());
                Console.Write("Altura: ");
                lataDeOleo.altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Volume de " + lataDeOleo.Volume + "m³");
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }
        }
    }
}