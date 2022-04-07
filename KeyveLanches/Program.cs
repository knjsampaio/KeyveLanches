using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

public class Lanche
{
    public string Nome;
    public int Codigo;
    public double Preco;

    public Lanche(string nome, int codigo, double preco)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;

    }
}

    
    

namespace KeyveLanches
{
    class Program
    {
        static void Main(string[] args)

        {

            int quantidade = 0;
            int codigo1 = 0;
            double total = 0;

            Lanche l1 = new Lanche("mistoquente", 1, 5.50);
            Lanche l2 = new Lanche("cheeseSalada", 2, 12.50);
            Lanche l3 = new Lanche("cheeseCalab", 3, 14.50);

            Console.WriteLine("CARDÁPIO");
            Console.WriteLine();

            Console.WriteLine("{0} {1} {2}", l1.Codigo,l1.Nome,l1.Preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("{0} {1} {2}", l2.Codigo, l2.Nome, l2.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0} {1} {2}", l3.Codigo, l3.Nome, l3.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("PEDIDO");
            Console.WriteLine();

            Console.WriteLine("Insira o código do lanche: ");
            codigo1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantas unidades?");
            quantidade = Convert.ToInt32(Console.ReadLine());

            if (codigo1 == 1)
            {
                total = (quantidade * l1.Preco);
                Console.WriteLine("Você escolheu {0} unidade de {1}. Total: R${2}", quantidade, l1.Nome, total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo1 == 2)
            {
                total = (quantidade * l2.Preco);
                Console.WriteLine("Você escolheu {0} unidade de {1}. Total: R${2}", quantidade, l2.Nome, total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo1 == 3)
            {
                total = (quantidade * l3.Preco);
                Console.WriteLine("Você escolheu {0} unidade de {1}. Total: R${2}", quantidade, l3.Nome, total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Produto inexistente!");
            }
                Console.ReadKey();
        }
    }
}
