namespace Heritages;

class Program
{

    public class Animal
    {
        public virtual void Comer()
        {
            Console.WriteLine("Sou um animal e estou a comer");
        }

        public void Lavar()
        {
            Console.WriteLine("Sou um animal e estou a lavar-me");
        }
    }

    public class Cão : Animal
    {
        public override void Comer()
        {
            Console.WriteLine("Eu sou um cão e estou a comer");
        }

        public void Ladrar()
        {
            Console.WriteLine("Sou um cão e ladro");
        }
    }

    public class Gato : Animal
    {
        public override void Comer()
        {
            Console.WriteLine("Sou um gato e estou a comer");
        }

        public void Miar()
        {
            Console.WriteLine("Sou um gato e estou a miar");
        }
    }

    public class PastorAlemão : Cão
    {
        public void ChamarPastorAlemao()
        {
            Console.WriteLine("Chamar Pastor alemão");
        }
    }
        
        
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Comer();
        animal.Lavar();
        Console.WriteLine("---------------------------------------------------------");
        Cão cão = new Cão();
        cão.Comer();
        cão.Lavar();
        cão.Ladrar();
        Console.WriteLine("---------------------------------------------------------");
        PastorAlemão alemão = new PastorAlemão();
        alemão.Ladrar();
        alemão.ChamarPastorAlemao();

        Console.WriteLine("---------------------------------------------------------");
        Gato gato = new Gato();
        gato.Comer();
        gato.Lavar();
        gato.Miar();
        Console.WriteLine("---------------------------------------------------------");
        
        
        
    }
}