using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        enum Menu { Somar = 1, Subtrair, Multiplicar, Dividir, Potência, Raiz, Sair }
        static void Main(string[] args)
        {
            bool end = false;
            while (!end)
            {
                Console.WriteLine("Seja bem vindo ao CALCULATION");
                Console.WriteLine("Selecione a operação desejada: ");
                Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Potência\n6 - Raiz\n7 - Sair");
                Menu OP = (Menu)int.Parse(Console.ReadLine());

                switch (OP)
                {
                    case Menu.Somar:
                        Soma();
                        break;
                    case Menu.Subtrair:
                        Subtrai();
                        break;
                    case Menu.Multiplicar:
                        Multiplica();
                        break;
                    case Menu.Dividir:
                        Divide();
                        break;
                    case Menu.Potência:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            static void Soma()
            {
                Console.WriteLine("Digite o primeiro número: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                float num2 = float.Parse(Console.ReadLine());

                float Result = num1 + num2;

                Console.WriteLine("O resultado é: " + Result);
                Console.WriteLine("Pressione enter para continuar");
                Console.ReadLine();
                Console.Clear();

            }

            static void Subtrai()
            {
                Console.WriteLine("Digite o primeiro número: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                float num2 = float.Parse(Console.ReadLine());

                float Result = num1 - num2;

                Console.WriteLine("O resultado é: " + Result);

                Console.WriteLine("Pressione enter para continuar");
                Console.ReadLine();
                Console.Clear();

            }

            static void Multiplica()
            {
                Console.WriteLine("Digite o primeiro número: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                float num2 = float.Parse(Console.ReadLine());

                float Result = num1 * num2;

                Console.WriteLine("O resultado é: " + Result);

                Console.WriteLine("Pressione enter para continuar");
                Console.ReadLine();
                Console.Clear();

            }

            static void Divide()
            {
                Console.WriteLine("Digite o primeiro número: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                float num2 = float.Parse(Console.ReadLine());

                float Result = num1 / num2;

                Console.WriteLine("O resultado é: " + Result);

                Console.WriteLine("Pressione enter para continuar");
                Console.ReadLine();
                Console.Clear();

            }

            static void Potencia()
            {
                Console.WriteLine("Digite a base: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente: ");
                float num2 = float.Parse(Console.ReadLine());
                float result = (float)Math.Pow(num1, num2);
                Console.WriteLine("O resultado é: " + result);
                Console.WriteLine("Pressione enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }

            static void Raiz()
            {
                Console.WriteLine("Digite o numero: ");
                float num1 = float.Parse(Console.ReadLine());
                float result = (float)Math.Sqrt(num1);
                Console.WriteLine("O resultado é: " + result);
                Console.WriteLine("Pressione enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }

        }

    }
}
