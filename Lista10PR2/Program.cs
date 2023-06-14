using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            int Laço1 = 1;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Exercício 1");
                Console.WriteLine("2. Exercício 2");
                Console.WriteLine("3. Exercício 3");
                Console.WriteLine("4. Exercício 4 ");
                Console.WriteLine("5. Exercício 5 ");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());



                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }



                Console.WriteLine();
            } while (true);
        }



        static void Exercicio1()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            float[] vetor = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite o ", i + 1, "º número: ");
                vetor[i] = float.Parse(Console.ReadLine());
            }

            float menor = vetor[0];
            float maior = vetor[0];
            float soma = vetor[0];

            for (int i = 1; i < tamanho; i++)
            {
                if (vetor[i] < menor)
                    menor = vetor[i];

                if (vetor[i] > maior)
                    maior = vetor[i];

                soma += vetor[i];
            }

            float media = soma / tamanho;

            Console.WriteLine("Menor número: ", menor);
            Console.WriteLine("Maior número: ", maior);
            Console.WriteLine("Média aritmética: ", media);
            Console.WriteLine("Executando o exercício 1...");
        }

        static void Exercicio2()
        {

            Console.Write("Informe o tamanho do vetor (N): ");
            int N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("O valor de N deve ser maior que zero.");
                return;
            }

            float[] vetor = new float[N];
            float soma = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Informe o valor {i + 1}: ");
                vetor[i] = float.Parse(Console.ReadLine());
                soma += vetor[i];
            }

            float media = soma / N;

            Console.WriteLine("\nValores maiores ou iguais à média:");
            for (int i = 0; i < N; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
            Console.WriteLine("Executando o exercício 2...");
        }



        static void Exercicio3()
        {
            Console.Write("Informe o tamanho do vetor (N): ");
            int N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("O valor de N deve ser maior que zero.");
                return;
            }

            float[] vetor = new float[N];
            float soma = 0;

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                vetor[i] = (float)random.NextDouble();
                soma += vetor[i];
            }

            float media = soma / N;

            Console.WriteLine("\nValores maiores ou iguais à média:");
            for (int i = 0; i < N; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
            Console.WriteLine("Executando o exercício 3...");
        }
        static void Exercicio4()
        {

            Console.Write("Informe a quantidade de assinaturas (N): ");
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Informe o nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNomes em ordem reversa:");

            for (int i = N - 1; i >= 0; i--)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.WriteLine("Executando o exercício 4...");
        }
        static void Exercicio5()
        {
            Console.Write("Informe o tamanho do vetor (N): ");
            int N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Tamanho inválido. O valor de N deve ser maior que zero.");
                return;
            }

            int[] vetor = new int[N];
            Random random = new Random();

            int countPares = 0;
            int countImpares = 0;

            for (int i = 0; i < N; i++)
            {
                vetor[i] = random.Next(100); // Gera um número aleatório entre 0 e 99

                if (vetor[i] % 2 == 0)
                {
                    countPares++;
                }
                else
                {
                    countImpares++;
                }
            }

            Console.WriteLine("\nVetor gerado:");

            for (int i = 0; i < N; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.WriteLine("\n\nQuantidade de números pares: " + countPares);
            Console.WriteLine("Quantidade de números ímpares: " + countImpares);
            Console.WriteLine("Executando o exercício 5...");
        }
    }
}
   
