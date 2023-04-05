namespace ListaDeExerciciosOO.Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Console.WriteLine("Programa para calcular a média ponderada de duas provas realizadas por um aluno\n------------------");
            while (resposta.ToUpper() != "S")
            {
                Aluno media = new Aluno();
                Console.WriteLine("Nota da Prova 1: ");
                media.prova1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Peso da Prova 1: ");
                media.PesodaProva1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nota da Prova 2: ");
                media.prova2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Peso da Prova 2: ");
                media.PesodaProva2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultado: " + media.MediaPonderada);
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }
        }    
    }
}