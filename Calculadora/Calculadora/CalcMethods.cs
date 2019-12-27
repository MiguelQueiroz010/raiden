using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class CalcMethods
    {
        public void Normal()
        {

            int x;
            int y;
            string z;
            int resultado;

            void Valores()
            {
                Console.WriteLine("Digite os valores para calcular");
                Console.WriteLine("Valor 1:");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Valor 2:");
                y = int.Parse(Console.ReadLine());
            }

            Valores();
            Operacao();
            void Operacao()
            {
                Console.WriteLine("Operações disponíveis: Soma(+), Subtração(-), Divisão(/) e Multiplicação(*)" +
                    "\nDigite o tipo de operação:");
                z = Console.ReadLine();

                if (z == "+")
                {
                    resultado = x + y;
                    Console.WriteLine($"\nResultado: {resultado}");
                }
                else if (z == "-")
                {
                    resultado = x - y;
                    Console.WriteLine($"\nResultado: {resultado}");
                }
                else if (z == "*")
                {
                    resultado = x * y;
                    Console.WriteLine($"\nResultado: {resultado}");
                }
                else if (z == "/")
                {
                    resultado = x / y;
                    Console.WriteLine($"\nResultado: {resultado}");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Erro!!");
                    Operacao();
                }
            }
        }
        public void Hexadecimal()
        {
            Console.WriteLine("Digite os valores para calcular:");
            Console.WriteLine("Valor 1:");
            //Hexadecimais vem em strings lembre-se
            string value1 = Console.ReadLine();
            //mas são calculados como inteiros com conversão para o valor
            int i = Convert.ToInt32(value1, 16);
            Console.WriteLine("Valor 2:");
            string value2 = Console.ReadLine();
            int i2 = Convert.ToInt32(value2, 16);
            Operacao();

            void Operacao()
            {
                string p;
                int res = 0;
                Console.WriteLine("Digite a operação desejada:");
                Console.WriteLine("Operações disponíveis: Soma(+), Subtração(-), Divisão(/) e Multiplicação(*)");
                p = Console.ReadLine();
                switch (p)
                {
                    case "+":
                        res = i + i2;
                        Result();
                        break;
                    case "-":
                        res = i - i2;
                        Result();
                        break;
                    case "/":
                        res = i / i2;
                        Result();
                        break;
                    case "*":
                        res = i * i2;
                        Result();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Operação inexistente!!! Tente de novo.");
                        Operacao();
                        break;
                }

                void Result()
                {
                    //e para ver o resultado em hexadecimal e não em inteiro use isso:
                    Console.WriteLine($"\nResultado=" + res.ToString("X"));
                }


            }



        }

        public void Octal()
        {
            Console.WriteLine("Digite os valores para calcular:");
            Console.WriteLine("Valor 1:");
            //Octais vem de 1 a 7 e de 10 em diante.
            string value1 = Console.ReadLine();
            //mas são calculados como inteiros com conversão para o valor de base 8.
            int i = Convert.ToInt32(value1, 8);
            Console.WriteLine("Valor 2:");
            string value2 = Console.ReadLine();
            int i2 = Convert.ToInt32(value2, 8);
            Operacao();

            void Operacao()
            {
                string p;
                int res = 0;
                Console.WriteLine("Digite a operação desejada:");
                Console.WriteLine("Operações disponíveis: Soma(+), Subtração(-), Divisão(/) e Multiplicação(*)");
                p = Console.ReadLine();
                switch (p)
                {
                    case "+":
                        res = i + i2;
                        Result();
                        break;
                    case "-":
                        res = i - i2;
                        Result();
                        break;
                    case "/":
                        res = i / i2;
                        Result();
                        break;
                    case "*":
                        res = i * i2;
                        Result();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Operação inexistente!!! Tente de novo.");
                        Operacao();
                        break;
                }

                void Result()
                {
                    //e para ver o resultado em octal:

                    Console.WriteLine($"\nResultado=" + Convert.ToString(res, 8));
                }


            }

        }
        public void Bin()
        {
            Console.WriteLine("Digite os valores para calcular:");
            Console.WriteLine("Valor 1:");
            //Octais vem de 1 a 7 e de 10 em diante.
            string value1 = Console.ReadLine();
            //mas são calculados como inteiros com conversão para o valor de base 8.
            int i = Convert.ToInt32(value1, 2);
            Console.WriteLine("Valor 2:");
            string value2 = Console.ReadLine();
            int i2 = Convert.ToInt32(value2, 2);
            Operacao();

            void Operacao()
            {
                string p;
                int res = 0;
                Console.WriteLine("Digite a operação desejada:");
                Console.WriteLine("Operações disponíveis: Soma(+), Subtração(-), Divisão(/) e Multiplicação(*)");
                p = Console.ReadLine();
                switch (p)
                {
                    case "+":
                        res = i + i2;
                        Result();
                        break;
                    case "-":
                        res = i - i2;
                        Result();
                        break;
                    case "/":
                        res = i / i2;
                        Result();
                        break;
                    case "*":
                        res = i * i2;
                        Result();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Operação inexistente!!! Tente de novo.");
                        Operacao();
                        break;
                }

                void Result()
                {
                    //e para ver o resultado em octal:

                    Console.WriteLine($"\nResultado=" + Convert.ToString(res, 2));
                }

            }
        }
    }
    }

    