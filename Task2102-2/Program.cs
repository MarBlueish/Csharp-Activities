namespace Task2102_2;

class Program
{
    static void Main(string[] args)
    {
        ListaNomes lista = new ListaNomes();

        lista[0] = "João";
        lista[1] = "Maria";
        lista[2] = "Pedro";
        
        Console.WriteLine(lista[1]);
    }
}