namespace Task2102_3;

class Program
{
    static void Main(string[] args)
    {
        string caminhoArquivo = "C:\\";

        using (StreamWriter escritor = new StreamWriter(caminhoArquivo))
        {
            escritor.WriteLine("Olá, mundo");
            escritor.WriteLine("Este é um arquivo de texto que estamos a testar para escrever um ficheiro txt");
        }
        Console.WriteLine("Ficheiro escrito com sucesso");
        Console.WriteLine("AGORA VAMOS LER O FICHEIRO QUE ACABAMOS DE CRIAR");

        using (StreamReader leitor = new StreamReader(caminhoArquivo))
        {
            string linha;
            while((linha = leitor.ReadLine()) != null)
            {
                Console.WriteLine(linha);
                
            }
        }
    }
}