namespace aulach03;

class Program
{
    float CalcularVolume(float raio)
    {
        float volume = (4.0f / 3) * (float)Math.PI * (float)Math.Pow(raio, 3);
        return volume;
    }                            

    static void Main(string[] args)
    {
        Program programa = new Program();
        
        
        Console.WriteLine(programa.CalcularVolume(4.0f));

        float resultado = programa.CalcularVolume(3.0f);
        Console.WriteLine(resultado);
    }
}