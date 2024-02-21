namespace task2002_2;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //expressoes lambda
        Func<int, int> dobrar = num => num * 2;
        //utilizaçao da expressao lambda
        int resultado = dobrar(5);
        Console.WriteLine(resultado);

        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, };

        List<int> pares = numeros.Where(num => num % 2 == 0).ToList();

        foreach (int numpPares in pares)
        {
            Console.WriteLine(numpPares);
        }

        Func<int, int> calcularQuadrado = num =>
        {
            int quadrado = num * num;
            return quadrado;
        };

        int resultado2 = calcularQuadrado(4);
        Console.WriteLine(resultado);
    }
}