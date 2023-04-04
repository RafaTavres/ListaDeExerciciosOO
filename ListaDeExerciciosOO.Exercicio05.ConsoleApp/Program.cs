namespace ListaDeExerciciosOO.Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Console.WriteLine("Calculdadora de volume de uma esfera\n------------------");
            while (resposta.ToUpper() != "S")
            {
                Esfera esfera = new Esfera();
                esfera.PegaTamanhoDoRaio();
                Console.WriteLine("" + Math.Round(esfera.VolumeDaEsfera, 2) + " cm³");
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();
            }
        }

       
    }
}