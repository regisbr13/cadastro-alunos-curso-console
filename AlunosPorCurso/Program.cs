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

            int opcao = 1;
            while (opcao != 5)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Quantidade de alunos por curso:");
                Console.WriteLine("2 - Quantidade total de alunos:");
                Console.WriteLine("3 - Listar alunos por curso:");
                Console.WriteLine("4 - Listar total de alunos:");
                Console.WriteLine("5 - Para sair.");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (opcao == 1)
                {
                    int opcao2 = 1;
                    while (opcao2 != 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite o curso desejado:");
                        Console.WriteLine("1 - A");
                        Console.WriteLine("2 - B");
                        Console.WriteLine("3 - C");
                        Console.WriteLine("4 - Para sair.");
                        try
                        {
                            opcao2 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        if (opcao2 == 1)
                        {
                            Console.WriteLine("O curso escolhido possui: " + A.Count + " alunos.");
                        }
                        if (opcao2 == 2)
                        {
                            Console.WriteLine("O curso escolhido possui: " + B.Count + " alunos.");
                        }
                        if (opcao2 == 3)
                        {
                            Console.WriteLine("O curso escolhido possui: " + C.Count + " alunos.");
                        }
                    }
                }

                if (opcao == 2)
                {
                    Console.WriteLine();
                    int qteTotal = A.Count + B.Count + C.Count;
                    Console.WriteLine("Temos o total de " + qteTotal + " alunos.");
                }

                if (opcao == 3)
                {
                    int opcao2 = 1;
                    while (opcao2 != 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Digite o curso desejado:");
                        Console.WriteLine("1 - A");
                        Console.WriteLine("2 - B");
                        Console.WriteLine("3 - C");
                        Console.WriteLine("4 - Para sair.");
                        try
                        {
                            opcao2 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        if (opcao2 == 1)
                        {
                            foreach (Aluno x in A)
                            {
                                Console.WriteLine(x);
                            }
                        }
                        if (opcao2 == 2)
                        {
                            foreach (Aluno x in B)
                            {
                                Console.WriteLine(x);
                            }
                        }
                        if (opcao2 == 3)
                        {
                            foreach (Aluno x in C)
                            {
                                Console.WriteLine(x);
                            }
                        }
                    }
                }
            }
        }
    }
}
