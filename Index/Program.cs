using System;

namespace Index
{
    public class Aluno
    {
        
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Nota { get; set; }

        // Construtor
        public Aluno(string nome, int idade, double nota)
        {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resposta: ");
            Console.WriteLine();

            
            Aluno[] alunos = new Aluno[3];

            // da vals aos elementos no array
            alunos[0] = new Aluno("Marco", 35, 20);
            alunos[1] = new Aluno("Daniel", 45, 10);
            alunos[2] = new Aluno("Joaninha", 55, 0);

            
            string alunome1 = alunos[0].Nome;
            string alunome2 = alunos[1].Nome;
            string alunome3 = alunos[2].Nome;

            // da print aos alunos
            Console.WriteLine("Nome: " + alunome1);
            Console.WriteLine("Nome: " + alunome2);
            Console.WriteLine("Nome: " + alunome3);
        }
    }
}