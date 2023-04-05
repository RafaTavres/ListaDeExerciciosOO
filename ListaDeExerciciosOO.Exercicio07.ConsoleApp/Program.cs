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
                Vendedor vendedor = new Vendedor();
                Console.Write("-------------\nSalario base: ");
                vendedor.salarioBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de dinheiro das Vendas:: ");
                vendedor.QuantidadeVendida = Convert.ToDouble(Console.ReadLine());
                Console.Write("Percentual ganho sobre as vendas: ");
                vendedor.Porcentagem = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Salario Final: " + vendedor.SalarioTotal);
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

            }
        }
    }
}