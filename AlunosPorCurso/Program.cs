using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosPorCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cod;
            string nome;
            Aluno aluno;
            HashSet<Aluno> A = new HashSet<Aluno>();
            HashSet<Aluno> B = new HashSet<Aluno>();
            HashSet<Aluno> C = new HashSet<Aluno>();

            Console.WriteLine("Digite quantos alunos possuem o curso A:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os dados do " + i + "° aluno:");
                Console.Write("Código: ");
                cod = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                aluno = new Aluno(cod, nome);
                A.Add(aluno);
            }

            Console.WriteLine();
            Console.WriteLine("Digite quantos alunos possuem o curso B:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os dados do " + i + "° aluno:");
                Console.Write("Código: ");
                cod = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                aluno = new Aluno(cod, nome);
                B.Add(aluno);
            }

            Console.WriteLine();
            Console.WriteLine("Digite quantos alunos possuem o curso C:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os dados do " + i + "° aluno:");
                Console.Write("Código: ");
                cod = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                aluno = new Aluno(cod, nome);
                C.Add(aluno);
            }
        }
    }
}
