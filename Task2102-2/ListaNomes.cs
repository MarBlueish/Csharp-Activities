namespace Task2102_2;

public class ListaNomes
{
    private string[] nomes = new string[5];

    public string this[int index]
    {
        get
        {
            return nomes[index];
            
        }
        set
        {
            nomes[index] = value;
        }
    }
}