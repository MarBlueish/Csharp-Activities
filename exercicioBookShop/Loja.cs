using System;
using System.Collections.Generic;
using System.IO;
namespace exercicioBookShop;



public class Loja
{
    public List<Livro> LivrosDisponiveis { get; set; }

    public Loja()
    {
        LivrosDisponiveis = new List<Livro>();
    }


}

