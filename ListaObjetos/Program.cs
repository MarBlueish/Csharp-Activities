using System;
using System.Collections.Generic;

namespace ListaObjetos
{
    class Program
    {
        public static List<Aluno> alunos = new List<Aluno>();

        static void Main(string[] args)
        {
            alunos.Add(new Aluno { Nome = "João", Idade = 13, Nota = 11.2f });
            alunos.Add(new Aluno { Nome = "Silva", Idade = 12, Nota = 17.2f });
            alunos.Add(new Aluno { Nome = "Silveira", Idade = 14, Nota = 19.1f });
            alunos.Add(new Aluno { Nome = "Sandro", Idade = 13, Nota = 20f });
            alunos.Add(new Aluno { Nome = "Cassandra", Idade = 12, Nota = 9f });

            MediaDaNota(); // Chame o método aqui
        }

        static void MediaDaNota()
        {
            float somadasNotas = 0;

            foreach (var aluno in alunos)
            {
                somadasNotas += aluno.Nota;
            }

            float mediaNota = somadasNotas / alunos.Count;

            Console.WriteLine("A media das notas dos alunos é: " + mediaNota);
        }
    }

    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Nota { get; set; }
    }
}