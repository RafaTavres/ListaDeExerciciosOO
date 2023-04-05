namespace ListaDeExerciciosOO.Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Console.WriteLine("Conversor de temperatura em graus Fahrenheit para graus Celsius\n------------------");
            while (resposta.ToUpper() != "S")
            {        
                Temperatura temperatura = new Temperatura();
                Console.Write("-------------\nTemperatura em F°: ");
                temperatura.fahrenheint = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Temperatura em C°: " + Math.Round(temperatura.Celsiu, 4) + "C°\n-------------");
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();
            }
        }
    }
}