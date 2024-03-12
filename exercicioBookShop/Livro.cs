namespace exercicioBookShop;

public class Livro
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Stock { get; set; }
    public object Titulo { get; internal set; }
}

