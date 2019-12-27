using System;
namespace Calculadora
{
    class Cálculos
    {
        static void Main(string[] args)
        {
            //Corzinha 
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Principal();
            static void Principal()
            {
                string t;
                //Chamada de classe
                CalcMethods exec = new CalcMethods();
                //Escolha de calculadora
                Console.WriteLine("Formatos: Normal(n), Hexadecimal(h), Octa(o) e Binário(b)" +
                    "\nDigite o tipo de calculadora que deseja usar:");
                t = Console.ReadLine();

                switch (t)
                {
                    case "n":
                        Console.Clear();
                        exec.Normal();
                        OpcoesSaida();
                        break;
                    case "h":
                        Console.Clear();
                        exec.Hexadecimal();
                        OpcoesSaida();
                        break;
                    case "o":
                        Console.Clear();
                        exec.Octal();
                        OpcoesSaida();
                        break;
                    case "b":
                        Console.Clear();
                        exec.Bin();
                        OpcoesSaida();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Comando incorreto!!");
                        Principal();
                        break;
                }
                /* IF ELSE SUBSTITUÍDO POR SWITCH CASE
                if (t == "n")
                {
                    Console.Clear();
                    exec.Normal();
                }
                else if (t == "h")
                {
                    Console.Clear();
                    exec.Hexadecimal();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Comando incorreto!!");
                    Principal();
                }
                */
                //Execução Pós-cálculos
                
            }

            
            void OpcoesSaida()
            {
                Console.WriteLine("\nQuer calcular mais?");
                Console.WriteLine("Digite 1 para continuar na calculadora.\nDigite 2 para sair." +
                        "\nEscolha uma opção:");
                string q = Console.ReadLine();
                switch (q)
                {
                    case "1":
                        Console.Clear();
                        Principal();
                        break;
                    case "2":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("OPÇÃO INCORRETA!!");
                        OpcoesSaida();
                        break;
                }
                }

            }
        }
    }

