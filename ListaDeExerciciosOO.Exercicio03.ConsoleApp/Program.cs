namespace ListaDeExerciciosOO.Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Console.WriteLine("Calculdadora de volume de um cilindro\n------------------");
            while (resposta.ToUpper() != "S")
            {
                Cilindro cilindro = new Cilindro();
                Console.Write("Raio: ");
                cilindro.raio = Convert.ToDouble(Console.ReadLine());
                Console.Write("Altura: ");
                cilindro.altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Volume de " + cilindro.Volume + "m³");
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }
        }      
    }
}