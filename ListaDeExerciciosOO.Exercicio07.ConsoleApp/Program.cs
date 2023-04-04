namespace ListaDeExerciciosOO.Exercicio07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Console.WriteLine("Salário do vendedor\n------------------");
            while (resposta.ToUpper() != "S")
            {
                Salario salario = new Salario();
                salario.PegaDadosDoUsuario();
                Console.WriteLine("Salario Final: " + salario.SalarioTotal);
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

            }
        }
    }
}