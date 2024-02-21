using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace task2102_4;

class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa{Nome="João", Idade = 25},
            new Pessoa{Nome = "Maria", Idade = 35},
            new Pessoa{Nome = "Carlos", Idade = 55}
        };
        
        // caminho arquivo binario

        string caminhoArquivo = "C:\\pessoas.bin";
        
        //serializar a lista de objetos para o arquivo binario
        using (FileStream arquivo = File.Create(caminhoArquivo))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(arquivo,pessoas);
            
        }
        
        Console.WriteLine("Lista de pessoas serializadas foi armazenado com sucesso!");
        
        // leitura de um file escrito em binario

        List<Pessoa> pessoaDesserializadas;
        using (FileStream arquivo = File.OpenRead(caminhoArquivo))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            pessoaDesserializadas = (List<Pessoa>)formatter.Deserialize(arquivo);
        }
        Console.WriteLine("Lista de pessoas deserializadas");

        foreach (Pessoa pessoa in pessoaDesserializadas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
            
        }

    }
}