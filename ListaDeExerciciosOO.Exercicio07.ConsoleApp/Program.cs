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
                Console.Write("-------------\nSalario base: ");
                salario.salarioBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de dinheiro das Vendas:: ");
                salario.QuantidadeVendida = Convert.ToDouble(Console.ReadLine());
                Console.Write("Percentual ganho sobre as vendas: ");
                salario.Porcentagem = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Salario Final: " + salario.SalarioTotal);
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

            }
        }
    }
}