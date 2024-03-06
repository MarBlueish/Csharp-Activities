using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace exercicioBookShop;



class Program
{
    public static List<Livro> listaLivros = new List<Livro>
    {
        new Livro { Id = 1, Nome = "Como ficar rico com uma venda", Preco = 10000.0, Stock = 1},
        new Livro { Id = 2, Nome = "Harry Potter e o extintor", Preco = 85.0, Stock = 53},
        new Livro { Id = 3, Nome = "Livros dos Afogados", Preco = 55.0, Stock = 53},
        new Livro { Id = 4, Nome = "Biografia de Douglas - Sem cortes", Preco = 22.0, Stock = 10344},
        new Livro { Id = 5, Nome = "Os amigos de Harry Potter", Preco = 11.0, Stock = 41},
        new Livro { Id = 6, Nome = "O Código do Programador Feliz", Preco = 30.0, Stock = 0},
        new Livro { Id = 7, Nome = "Viagem ao Centro do Código", Preco = 42.0, Stock = 2},
        new Livro { Id = 8, Nome = "A Arte de Depurar", Preco = 18.0, Stock = 59213},
        new Livro { Id = 9, Nome = "Poesia das Linhas de Código", Preco = 25.0, Stock = 532},
        new Livro { Id = 10, Nome = "Aventuras em Bits e Bytes", Preco = 36.0, Stock = 4630245}
    };

    static void Main(string[] args)
    {
        int numero;
        Console.WriteLine("Digite o nome do cliente:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o NIF do cliente (9 dígitos):");
        string nif = Console.ReadLine();

       
        while (true)
        {
            Console.WriteLine("Insira a opção desejada:");
            Console.WriteLine("0 - Procurar Livro");
            Console.WriteLine("1 - Mostrar Livros");
            Console.WriteLine("2 - Comprar um Livro");
            Console.WriteLine("3 - Ver o meu carrinho");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero))
            {
                switch (numero)
                {
                    case < 0:
                        Console.WriteLine("A sair do programa...");
                        return; 
                    case 0:
                        Console.WriteLine("Opção 0 selecionada - Procurar Livro");
                        break;
                    case 1:
                        Console.WriteLine("Opção 1 selecionada - Mostrar Livros");
                        MostrarListaItens(listaLivros);
                        break;
                    case 2:
                        Console.WriteLine("Opção 2 selecionada - Comprar um livro");
                        CompraItem(listaLivros);
                        break;
                    case 3: 
                        Console.WriteLine("Opção 3 selecionada - Ver o meu carrinho");
                        VerCarrinho(listaLivros);
                        
                        break;
                    default:
                        Console.WriteLine($"Número inserido: {numero}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }
    }

    public static void CompraItem(List<Livro> listaLivro)
    {
        Console.WriteLine("Insira o ID do item que quer comprar");
        if (int.TryParse(Console.ReadLine(), out int idItem))
        {
            var itemComprado = listaLivro.FirstOrDefault(item => item.Id == idItem);
            if (itemComprado != null)
            {
                Console.WriteLine($"Item '{itemComprado.Nome}' comprado por {itemComprado.Preco:C}");
                listaLivro.Remove(itemComprado);
            }
            else
            {
                Console.WriteLine("Item não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um ID válido.");
        }
    }

    public static void MostrarListaItens(List<Livro> listaLivros)
    {
        Console.WriteLine("Lista de Livros Disponíveis:");
        foreach (var livro in listaLivros)
        {
            Console.WriteLine($"ID: {livro.Id}, Nome: {livro.Nome}, Preço: {livro.Preco:C}");
            
        }
    }

    public static void VerCarrinho(List<Livro> carrinho)
    {
        Console.WriteLine("Itens no Carrinho:");
        if (carrinho.Count > 0)
        {
            foreach (var livro in carrinho)
            {
                Console.WriteLine($"ID: {livro.Id}, Nome: {livro.Nome}, Preço: {livro.Preco:C}, Stock: {livro.Stock}");
            }
        }
        else
        {
            Console.WriteLine("O carrinho está vazio.");
        }

    }
}