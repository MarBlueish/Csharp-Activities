using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace exercicioBookShop;


class Program
{
    static List<Cliente> credenciais = new List<Cliente>();
    static List<Livro> carrinho = new List<Livro>();
    
    public static List<Livro> listaLivros = new List<Livro>
    {
        new Livro { Id = 1, Nome = "Como ficar rico com uma venda", Preco = 10000.0, Stock = 1 },
        new Livro { Id = 2, Nome = "Harry Potter e o extintor", Preco = 85.0, Stock = 53 },
        new Livro { Id = 3, Nome = "Livros dos Afogados", Preco = 55.0, Stock = 53 },
        new Livro { Id = 4, Nome = "Biografia de Douglas - Sem cortes", Preco = 22.0, Stock = 10344 },
        new Livro { Id = 5, Nome = "Os amigos de Harry Potter", Preco = 11.0, Stock = 41 },
        new Livro { Id = 6, Nome = "O Código do Programador Feliz", Preco = 30.0, Stock = 0 },
        new Livro { Id = 7, Nome = "Viagem ao Centro do Código", Preco = 42.0, Stock = 2 },
        new Livro { Id = 8, Nome = "A Arte de Depurar", Preco = 18.0, Stock = 59213 },
        new Livro { Id = 9, Nome = "Poesia das Linhas de Código", Preco = 25.0, Stock = 532 },
        new Livro { Id = 10, Nome = "Aventuras em Bits e Bytes", Preco = 36.0, Stock = 4630245 }
    };


    static void Main(string[] args)
    {
        string adminuser = "admin";
        string adminpass = "admin";
        int choiceAdmin, numero;

        bool loggedIn = false;
        bool isAdmin = false;

        while (true)
        {
            if (!loggedIn)
            {
                Console.WriteLine("Bem-vindo a BookShop DM");
                Console.WriteLine("Já está registado na nossa plataforma? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta == "s")
                {
                    Console.WriteLine("Confirme os seus dados de entrada");
                    Console.WriteLine("Indique o seu nome");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o seu nif:");
                    string nif = Console.ReadLine();
                    Console.WriteLine("Indique a sua password");
                    string password = Console.ReadLine();
                    Console.WriteLine("Aguarde um momento...");

                    foreach (var cliente in credenciais)
                    {
                        if (cliente.Nome == nome && cliente.NIF == nif && cliente.password == password)
                        {
                            Console.WriteLine("Login efetuado com sucesso!");
                            loggedIn = true;
                            isAdmin = cliente.Nome == adminuser && cliente.password == adminpass;
                            break;
                        }
                    }

                    if (!loggedIn)
                    {
                        Console.WriteLine("Credenciais inválidas. Tente novamente ou registe-se.");
                    }
                }
                else if (resposta == "n")
                {
                    Console.WriteLine("Indique o seu nome para registo");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Indique o seu nif para registo:");
                    string nif = Console.ReadLine();
                    Console.WriteLine("Indique a sua password de registo");
                    string password = Console.ReadLine();
                    // Adiciona o novo cliente à lista de credenciais
                    credenciais.Add(new Cliente { Nome = nome, NIF = nif, password = password });
                    Console.WriteLine("Registo efetuado com sucesso. Faça login para continuar.");
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
            else
            {
                if (isAdmin)
                {
                    Console.WriteLine("Bem-vindo ao modo administrador.");
                    Console.WriteLine("1 - Mostrar Utilizadores");
                    Console.WriteLine("2 - Eliminar Utilizadores");
                    Console.WriteLine("3 - Ver Lista de Livros");
                    Console.WriteLine("4 - Editar Stock dos Livros");
                    Console.WriteLine("5 - Mudar Preço dos Livros");
                    Console.WriteLine("6 - Adicionar Livros");

                    if (int.TryParse(Console.ReadLine(), out choiceAdmin))
                    {
                        switch (choiceAdmin)
                        {
                            case 1:
                                Console.WriteLine("Mostrar Utilizadores:");
                                MostrarUsers(credenciais);
                                break;
                            case 2:
                                Console.WriteLine("Eliminar Utilizadores:");
                                DeleteUser(credenciais);
                                break;
                            case 3:
                                Console.WriteLine("Ver Lista de Livros:");
                                MostrarListaItens(listaLivros);
                                break;
                            case 4:
                                Console.WriteLine("Editar Stock dos Livros:");
                                EditaStock(listaLivros);
                                break;
                            case 5:
                                Console.WriteLine("Mudar Preço dos Livros:");
                                MudarPrecoLivros(listaLivros);
                                break;
                            case 6:
                                Console.WriteLine("Adicionar Livros:");
                                AdicionarLivros(listaLivros);
                                break;
                            case 0:
                                Console.WriteLine("A sair do modo admin...");
                                isAdmin = false; // volta ao inicio
                                break;
                            default:
                                Console.WriteLine("Opção inválida");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inválido, por favor escolha uma das opções acima");
                    }
                }
                else
                {

                    Console.WriteLine("Utilizador autenticado. Insira a opção desejada ou '0' para sair:");
                    Console.WriteLine("1 - Procurar Livro");
                    Console.WriteLine("2 - Mostrar Livros");
                    Console.WriteLine("3 - Comprar um Livro");
                    Console.WriteLine("4 - Ver o meu carrinho");
                    Console.WriteLine("0 - Sair");

                    string input = Console.ReadLine();

                    if (int.TryParse(input, out numero))
                    {
                        switch (numero)
                        {
                            case 0:
                                Console.WriteLine("A sair do programa...");
                                return;
                            case 1:
                                Console.WriteLine("1- Procurar Livro");
                                //logica para procurar livros
                                break;
                            case 2:
                                Console.WriteLine("2- Mostrar Livros");
                                MostrarListaItens(listaLivros);
                                break;
                            case 3:
                                Console.WriteLine("3- Comprar um livro");
                                CompraItem(listaLivros);
                                break;
                            case 4:
                                Console.WriteLine("4- Ver o meu carrinho");
                                VerCarrinho();
                                break;

                            default:
                                Console.WriteLine($"Número inserido: {numero}");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, insira uma opção válida.");
                    }
                }
            }
        }
    }

    static void CompraItem(List<Livro> listaLivros)
    {
        Console.WriteLine("Insira o ID do item que quer comprar");

        if (int.TryParse(Console.ReadLine(), out int idItem))
        {
            var itemComprado = listaLivros.FirstOrDefault(item => item.Id == idItem && item.Stock > 0);

            if (itemComprado != null)
            {
                Console.WriteLine($"Item '{itemComprado.Nome}' comprado por {itemComprado.Preco:C}");
                carrinho.Add(itemComprado); // Adiciona o item ao carrinho
                itemComprado.Stock--;
            }
            else
            {
                Console.WriteLine("Item não encontrado ou sem stock disponível.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um ID válido.");
        }
    }

    static void MostrarListaItens(List<Livro> listaLivros)
    {
        Console.WriteLine("Lista de Livros Disponíveis:");
        foreach (var Livro in listaLivros)
        {
            Console.WriteLine(
                $"ID: {Livro.Id}, Nome: {Livro.Nome}, Preço: {Livro.Preco:C}, Stock: {Livro.Stock}");
        }
    }

    static void VerCarrinho()
    {
        Console.WriteLine("Itens no Carrinho:");

        if (carrinho.Count > 0)
        {
            int carrinho_count = 0;
            foreach (var livro in carrinho)
            {
                Console.WriteLine(
                    $"ID: {livro.Id}, Nome: {livro.Nome}, Preço: {livro.Preco:C}"); // retorna 
                    carrinho_count++;
            }

            Console.WriteLine($"Tem {carrinho_count} items no carrinho");
        }
        else
        {
            Console.WriteLine("O carrinho está vazio.");
        }
    }

    static void MostrarUsers(List<Cliente> clientes)
    {
        Console.WriteLine("Lista de users:");
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, NIF: {cliente.NIF}");
        }
    }

    static void DeleteUser(List<Cliente> clientes)
    {
        Console.WriteLine("Insira o NIF do user a eliminar:");
        string nifEliminar = Console.ReadLine();

        var clienteEliminar =
            clientes.FirstOrDefault(cliente =>
                cliente.NIF ==
                nifEliminar); // expressao vai comparar diretamente, caso algum seja compativel, vai eliminar esse mesmo

        if (clienteEliminar != null)
        {
            clientes.Remove(clienteEliminar);
            Console.WriteLine("User removido com sucesso");
        }
        else
        {
            Console.WriteLine($"User nao encontrado");
        }
    }

    static void MudarPrecoLivros(List<Livro> livros)
    {
        Console.WriteLine("Insira o ID do livro a editar o preço:");
        if (int.TryParse(Console.ReadLine(), out int idLivro))
        {
            var livroEditar = livros.FirstOrDefault(livro => livro.Id == idLivro);

            if (livroEditar != null)
            {
                Console.WriteLine($"Livro selecionado: {livroEditar.Nome}, Preço atual: {livroEditar.Preco:C}");
                Console.WriteLine("Insira o novo preço:");
                if (decimal.TryParse(Console.ReadLine(), out decimal novoPreco))
                {
                    livroEditar.Preco = (double)novoPreco;
                    Console.WriteLine($"Preço do livro {livroEditar.Nome} atualizado para {novoPreco:C}.");
                }
                else
                {
                    Console.WriteLine("Valor inválido para o preço. A operação foi cancelada.");
                }
            }
            else
            {
                Console.WriteLine("Livro nao encontrado");
            }
        }
        else
        {
            Console.WriteLine("ID inserido nao existe");
        }
    }

    static void AdicionarLivros(List<Livro> livros)
    {
        Console.WriteLine("Insira o novo livro:");
        Console.WriteLine("Nome:");
        string nomeLivro = Console.ReadLine();
        Console.WriteLine("Preço:");
        if (decimal.TryParse(Console.ReadLine(), out decimal precoLivro))
        {
            Console.WriteLine("Stock:");
            if (int.TryParse(Console.ReadLine(), out int stockLivro))
            {
                int novoId = livros.Count + 1;
                Livro novoLivro = new Livro
                    { Id = novoId, Nome = nomeLivro, Preco = (double)precoLivro, Stock = stockLivro };
                livros.Add(novoLivro);
                Console.WriteLine("Livro adicionado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor impossivel de ser inserido, operaçao foi concluida ssem sucesso");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido para o preço. A operação foi cancelada.");
        }
    }

    static void EditaStock(List<Livro> listaLivros)
    {
        Console.WriteLine("Insira o ID do livro para editar o stock:");

        if (int.TryParse(Console.ReadLine(), out int idLivro))
        {
            var livroParaEditar = listaLivros.FirstOrDefault(livro => livro.Id == idLivro);

            if (livroParaEditar != null)
            {
                Console.WriteLine($"Livro selecionado: {livroParaEditar.Nome}, Stock atual: {livroParaEditar.Stock}");
                Console.WriteLine("Defina o novo valor de stock:");

                if (int.TryParse(Console.ReadLine(), out int novoStock))
                {
                    livroParaEditar.Stock = novoStock;
                    Console.WriteLine("Stock atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Valor impossivel para stock, operaçao concluida sem sucesso");
                }
            }
            else
            {
                Console.WriteLine("Livro não foi encontrado.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido, operaçao concluida sem sucesso");
        }
    }
}
        