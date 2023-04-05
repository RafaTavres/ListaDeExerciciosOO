namespace ListaDeExerciciosOO.Exercicio09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Aluno mediaHarmonica = new Aluno();
            Console.WriteLine("Calculadadora para média harmônica das notas de um Aluno\n------------------");
            while (resposta.ToUpper() != "S")
            {
                Console.WriteLine("Nota: ");
                mediaHarmonica.Nota = Convert.ToInt32(Console.ReadLine());
                mediaHarmonica.TotalDeNotas *= mediaHarmonica.Nota;
                mediaHarmonica.notas.Add(mediaHarmonica.Nota);
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();
            }
            Console.WriteLine("resultado : " + mediaHarmonica.MediaHarmonica);
        }
    }
}