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
                media.PegaDadosDoUsuario();
         
                Console.WriteLine("Resultado: " + media.MediaPonderada);

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }
        }    
    }
}