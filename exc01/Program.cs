using exc01.Models;
using System;

namespace exc01
{
    class Program
    {
        static void Main()
        {
            Cliente cliente = new Cliente()
            {
                Nome = "Jorge",
                Endereco = new Endereco("Centro", "240C")
            };

            Cliente[] clientes = new Cliente[3];
            clientes[0] = new Cliente()
            {
                Nome = "Jessica",
                Endereco = new Endereco("Argentina", "123")
            };

            clientes[1] = new Cliente();
            clientes[2] = new Cliente();

            Venda venda = new Venda();
            venda.produto[0] = "Banana";
            venda.produto[1] = "Maça";
            venda.produto[2] = "Pera";
            venda.produto[3] = "Uva";
            venda.produto[4] = "Ameixa";

            Console.WriteLine($"Cliente: {cliente.Nome}");
            Console.WriteLine("Endereco: " + cliente.Endereco.Rua + cliente.Endereco.Numero + "\n");
            Console.WriteLine("Produtos Vendidos: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(venda.produto[i]);
            }

            Console.ReadKey();
        }
    }
}
