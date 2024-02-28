namespace Classes_Abstratas;

class Program
{
    static void Main(string[] args)
    {
        Cão cão = new Cão();
        cão.Comer();
        cão.valor++;
        
        Gato gato = new Gato();
        gato.Comer();
        gato.valor++;
        
    }

    abstract class Animal
    {
        public int valor;

        public abstract string Comer();
        
    }

    class Cão : Animal
    {
        public override string Comer()
        {
            return "Sou um Cão";
        }
    }

    class Gato : Animal
    {
        public override string Comer()
        {
            return "Sou um gato";
        }
    }
}