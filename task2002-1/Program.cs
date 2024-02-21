namespace task2002;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        
        //add elementos
        
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);
        // Inserir um element numa pos espec.

        numeros.Insert(1, 15);

        bool contem15 = numeros.Contains(15);

        int posicao20 = numeros.IndexOf(20);
        
        //ordenar lista
        
        numeros.Sort();
        
        //remover
        
        numeros.RemoveAt(2);

        numeros.Remove(10);

        int tamanho = numeros.Count();

        for (int i = 0; i < numeros.Count; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

    }
}