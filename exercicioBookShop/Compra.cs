

namespace exercicioBookShop;



public class Compra
{
    private DateTime now;
    private List<Livro> carrinho;
    private decimal valorTotalCompra;

    public Compra(DateTime now, Cliente cliente, List<Livro> carrinho, decimal valorTotalCompra)
    {
        this.now = now;
        Cliente = cliente;
        this.carrinho = carrinho;
        this.valorTotalCompra = valorTotalCompra;
    }

    public Cliente Cliente { get; set; }
    public Livro Livro { get; set; }
    public double Total { get; set; }
    public IEnumerable<Livro> VerCarrinho { get; internal set; }
    public object DataCompra { get; internal set; }
}



