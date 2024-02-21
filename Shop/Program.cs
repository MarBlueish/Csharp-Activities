using System;
using System.Collections.Generic;



namespace Shop;



class Program
{
    static void Main(string[] args)
    {
        List<Produto> listaProdutos = new List<Produto>();

        Produto produto1 = new Produto(1, "Camisa", 29.99);
        listaProdutos.Add(produto1);
        
        Produto produto2 = new Produto(2, "Calças", 59.99);
        listaProdutos.Add(produto2);

        foreach (Produto produto in listaProdutos)
        {
           produto.ImprimirDetalhes();
           Console.WriteLine();
        }
        
        Console.WriteLine("Total de Produtos:" + listaProdutos.Count);
        // pedir input ao user
        
        Console.WriteLine("Insira o nome do Produto a procurar");
        string resposta = Console.ReadLine();
        Console.WriteLine("Escolheu " + resposta);
        
        

        Produto produtoEncontrado = listaProdutos.Find(p => p.Nome == resposta);

        if (produtoEncontrado != null)
        {
            Console.WriteLine("Produto encontrado " + produtoEncontrado.Nome);
            
        }
        else
        {
            Console.WriteLine("Produto não encontrado");
        }
        

    }
}