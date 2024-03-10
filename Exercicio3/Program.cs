namespace Exercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int salarioMinimo = 200;
            const int faixaSalarial = 100;
            int[] faixasSalariais = new int[9] { 299, 399, 499, 599, 699, 799, 899, 999, 999999 };
            int[] contagemVendedores = new int[faixasSalariais.Length];

            Console.Write("Digite o número de vendedores: ");
            int numeroVendedores = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroVendedores; i++)
            {
                Console.Write($"Digite as vendas brutas do vendedor {i + 1}: ");
                double vendasBrutas = double.Parse(Console.ReadLine());

                double salario = salarioMinimo + (vendasBrutas * 0.09);

                int posicaoLista = (int)Math.Floor((salario - salarioMinimo) / faixaSalarial);

                if (posicaoLista >= 9)
                {
                    posicaoLista = 8;
                }
                contagemVendedores[posicaoLista]++;
            }

            Console.WriteLine("\n**Resultados:**");
            for (int i = 0; i < faixasSalariais.Length; i++)
            {
                Console.WriteLine($"Faixa salarial: R${salarioMinimo + (i * faixaSalarial)} - R${faixasSalariais[i]}: {contagemVendedores[i]} vendedores");
            }
        }
    }
}