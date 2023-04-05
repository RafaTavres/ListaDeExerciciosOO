namespace ListaDeExerciciosOO.Exercicio06.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Console.WriteLine("Conversor de temperatura em graus Celsius  para graus Fahrenheit \n------------------");
            while (resposta.ToUpper() != "S")
            {
                Temperatura temperatura = new Temperatura();
                Console.Write("-------------\nTemperatura em F°: ");
                temperatura.celsiu = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Temperatura em C°: " + Math.Round(temperatura.Farenheint, 4) + "C°\n-------------");
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();
            }
        }
    }
}