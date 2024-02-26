using System.Runtime.InteropServices.JavaScript;
int main()
{
    ImprimirFrase();
    ImprimirFraseDespedida("João", 25); // Substitui "idade" pela idade real

    return 0;
}

void ImprimirFrase()
{
    Console.WriteLine("Batatas do McDonalds");
    Console.WriteLine("Gelado do Burguer King");
}

void ImprimirFraseDespedida(string nome, int idade)
{
    Console.WriteLine("Olá meu caro " + nome);
    Console.WriteLine("Obrigado, " + nome + " por todo o seu serviço. R.I.P");
    Console.WriteLine("Tu nasceste em " + (DateTime.Now.Year - idade));
}
