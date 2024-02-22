namespace ArraysExercicio;

class Program
{
    static void Main(string[] args)
    {
        int[] meuArray = new int[11];
        int[] invertidoArray = new int[11];
        meuArray[0] = 1;
        meuArray[1] = 6;
        meuArray[2] = 44;
        meuArray[3] = 243;
        meuArray[4] = 35;
        meuArray[5] = 143;
        meuArray[6] = 1341;
        meuArray[7] = 54;
        meuArray[8] = 4132;
        meuArray[9] = 231;
        meuArray[10] = 23;

        for (int i = 0; i < meuArray.Length; i++)
        {
            Console.WriteLine(meuArray[i]);
 
        }
        
        //inversao do array
        for (int i = 0; i < meuArray.Length; i++)
        {
            invertidoArray[i] = meuArray[meuArray.Length - 1 - i];
        }
        Console.WriteLine("\nArray Invertido:");
        
        for (int i = 0; i < invertidoArray.Length; i++)
        {
            Console.WriteLine(invertidoArray[i]);
        }
        


        


    }
}