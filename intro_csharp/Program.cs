using System.ComponentModel.Design;
using System.Reflection;

namespace intro_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprime uma mensagem na consola
            Console.WriteLine("Hello, World!");

            //Tipo de dado inteiro
            int numeroInteiro = 42;
            Console.WriteLine("Número Inteiro: * " + numeroInteiro);

            //Tipo de dado ponto flutuante(double)
            double numeroPontoFlutuante = 3.34;
            Console.WriteLine("Número ponto flutuante(double): " + numeroPontoFlutuante);

            //Tipo de dado ponto flutuante(float)
            float numeroPontoFlutuanteFloat = 2.71573827f;
            Console.Write("Número ponto flutuante (float) " + numeroPontoFlutuanteFloat);

            //Tipo de dado caracter
            char caracter = 'A';
            Console.WriteLine("Caracter " + caracter);

            //Tipo de dado booleano
            bool verdadeiroOuFalso = true;
            Console.WriteLine("Booleano " + verdadeiroOuFalso);

            //Tipo de dados em cadeira de caracteres(string)
            string texto = "Isto é uma string";
            Console.WriteLine("String: " + texto);

            //Exemplo de Casting

            //Casting Implicito de int para double
            double castImplicito = numeroInteiro;
            Console.WriteLine("Casting Implicito (double para int): " + castImplicito);

            //Casting explicito de double para int(pode resultar em perda de dados)
            int castExplicito = (int)numeroPontoFlutuante;
            Console.WriteLine("Casting Explicito (double para int): " + castExplicito);

            //Exemplo de um for loop que imprime números de 1 a 5
            Console.WriteLine("Exemplo de um loop For:");

            for (int i = 1; i<= 5; i++)
            {
                Console.WriteLine(i);
            }

            //Exercicio 1 - Soma e Subtração:

            int var1 = 35;
            int var2 = 74;

            Console.WriteLine("O resultado da soma é " + (var1 + var2));
            Console.WriteLine("O resultado da subtracao é " + (var2 - var1));

            //Exercicio 2

            float var3 = 25.35365f;
            float var4 = 915.359302f;

            Console.WriteLine("O resultado da multiplicacao é " + (var3 * var4));
            Console.WriteLine("O resultado da divisão é " + (var4 / var3));

            Console.WriteLine("O resultado da soma é " + (var1 + var2));
            Console.WriteLine("O resultado da subtracao é " + (var2 - var1));

            //Exercicio 3

            int var5;
            int var6;
            int var7;
            int resultado_var;

            Console.WriteLine("Insira um dos primeiros 3 números");
            var5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número");
            var6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número");
            var7 = int.Parse(Console.ReadLine());

            resultado_var = (var5 + var6 + var7) / 3;

            Console.WriteLine("O resultado é " + resultado_var);


            //Exercicio 3 em array

            int var8;
            int var9;
            int var10;
            int medium;

            int[] array1 = new int[3];


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insira o " + (i+1) + "número");
                array1[0] = int.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i< 3; i++)
            {
                
                Console.WriteLine("A média é" +medium)
            }
            









            //Exercicio 4

            //int valor1;
            //int valor2;

            //Console.WriteLine("Indique um valor");
            //valor1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tabuada do " + valor1);

            //while (valor1 >= 0)
            //{

            //}











        }
    }
}
