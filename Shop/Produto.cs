namespace Shop;

 class Produto
{
    public int ID;
    public string Nome;
    public double Preco;

    public Produto(int id, string nome, double preco)
    {
        ID = id;
        Nome = nome;
        Preco = preco;
    }

    public void ImprimirDetalhes()
    {
        Console.WriteLine("ID: " +ID);
        Console.WriteLine("Nome:  "+ Nome);
        Console.WriteLine("Preço:  " + Preco);
    }
}