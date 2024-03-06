namespace DelegatesNcallbacks;

// definiçao de como e o delegate a nivel de estrutura, neste caso devolve um int e tem um unico parametro int
delegate int NumberChanger(int n);

class Program
{
    class TestDelegate
    {
        public static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            //Instancias dos delegates
            NumberChanger nc1 = new NumberChanger(AddNum);

            NumberChanger nc2 = new NumberChanger(MultNum);
            // chamar os metodos a partir dos delegates
            nc1(25);
            Console.WriteLine("Valor de Numero: {0}", getNum());
            nc2(5);
            Console.WriteLine("Valor de Numero: {0}", getNum());
            Console.ReadKey();
            


        }
    }
}