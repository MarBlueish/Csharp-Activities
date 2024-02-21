namespace task2002_3;

class Program
{
    static void Main(string[] args)
    {
        int diaDaSemana = 3;
        string nomeDia;


        switch (diaDaSemana)
        {
            case 1:
                nomeDia = "Segunda-Feira";
                break;
            case 2:
                nomeDia = "Terça-Feira";
                break;
            case 3:
                nomeDia = "Quarta-Feira";
                break;
            case 4:
                nomeDia = "Quinta-Feira";
                break;
            case 5:
                nomeDia = "Sexta-Feira";
                break;
            case 6:
                nomeDia = "Sábado";
                break;
            default:
                nomeDia = "Valor Inválido";
                break;
        }
        Console.WriteLine("O dia da semana é "+nomeDia);
    }
}