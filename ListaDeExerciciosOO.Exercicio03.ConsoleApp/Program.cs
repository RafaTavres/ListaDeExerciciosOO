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
                cilindro.PegaValorDosLadosDoUsuario();
                Console.WriteLine("Volume de " + cilindro.Volume + "m³");
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }
        }      
    }
}