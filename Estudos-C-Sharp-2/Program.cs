using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
namespace Estudos_C_Sharp_2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////////////////////////////////////////
            // Arrays
            /*
            
            String[] carros = { "Gol" ,"Palio", "Uno" };
            carros[0] = "Mustang";

            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }

            // OU

            String[] marcas = new string[3];

            marcas[0] = "Ford";
            marcas[1] = "Chevrolet";
            marcas[2] = "Fiat";

            for (int j = 0; j < marcas.Length; j++)
            {
                Console.WriteLine(marcas[j]);
            }
            */

            ////////////////////////////////////////////////
            // foreach = menos flexível que o for, porém, mais simples
            /*
            String[] carros = { "Gol", "Palio", "Uno" };

            foreach(String carro in carros)
            {
                Console.WriteLine(carro);
            }
            */

            ////////////////////////////////////////////////
            // *Method

            /*
            String nome = "Erick";
            int idade = 20;
            
            Parabens(nome, idade);
            Parabens(nome, idade);
            Parabens(nome, idade);
            */

            ////////////////////////////////////////////////
            // *return

            /*
            double x;
            double y;
            double result;

            Console.WriteLine("Digite o primeiro número: ");
            x = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Digite o segundo número: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiplicar(x, y);

            Console.WriteLine(result);
            */

            ////////////////////////////////////////////////
            // *Method overloading = compartilham o mesmo nome mas diferentes parâmetros
            //                       nome + parâmetro = assinatura
            //                       métodos devem ter assinaturas únicas

            /*
            int total;
            total = Somar(2, 6 , 8);
            Console.WriteLine(total);
            */

            ////////////////////////////////////////////////
            // *Parametros keywords = parâmetro de um método que possui um número variável de argumentos.
            //                        o tipo de parâmetro deve ser singular  - array dimensional

            /*
            double total = CheckOut(30.20, 88.12, 25, 70, 55.50);

            Console.WriteLine(total);
            */

            ////////////////////////////////////////////////
            // Exception handle

            //   try = try algum código que e considerado perigoso
            //   catch = catches e cuida das excessoes quando elas ocorrem
            //   finally = sempre executa mesmo se uma excessão for pega ou não

            /*
            int x;
            int y;
            double resultado;

            try
            {
                Console.WriteLine("Digite o primeiro número: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                y = Convert.ToInt32(Console.ReadLine());

                resultado = x / y;

                Console.WriteLine("resultado: " + resultado);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Digite apenas números");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("jamanta");
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }
            */

            ////////////////////////////////////////////////
            // Conditional Operator
            // (condição) ? x : y

            /*
            double temperatura = 27;
            String mensagem;

            mensagem = (temperatura >= 20) ? "Está de boa lá fora" : "Está frio lá fora";

            Console.WriteLine(menssagem);
            */

            /////////////////////////////////////////////////
            // String interpolation

            /*
            String nome = "Erick";
            String sobrenome = "Lima";
            int idade = 19;

            Console.WriteLine($"Olá {nome} {sobrenome}");
            Console.WriteLine($"Você tem {idade, 10} anos");
            */

            ////////////////////////////////////////////////
            // Arrays Multidimensionais
            
            /*
            // ao invés disso
            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };
            
            // use isto
            String[,] estacionamento = {    { "Mustang", "F-150", "Explorer" },
                                            { "Corvette", "Camaro", "Silverado" } ,
                                            { "Corolla", "Camry", "Rav4" }              
            };
            
            // substituindo
            estacionamento[0, 2] = "Fusion";
            
            //printando
            foreach (String carro in estacionamento)
            {
                Console.WriteLine(carro);
            }

            // ou

            for(int i = 0; i < estacionamento.GetLength(0); i++)
            {
                for(int j = 0; j < estacionamento.GetLength(1); j++)
                {
                    Console.Write(estacionamento[i,j] + " ");
                }
                Console.WriteLine();
            }
            */
            ////////////////////////////////////////////////

            Console.ReadKey();
        }

        ////////////////////////////////////////////////
        // *Method

        /*
        static void Parabens(String nome, int idade)
        {
            Console.WriteLine("Parabéns pra você!" );
            Console.WriteLine("Parabéns pra você!");
            Console.WriteLine("Parabéns pra VOCÊ!");
            Console.WriteLine("Parabéns pra você!" + nome);
            Console.WriteLine("Hoje você completa " + idade + " anos");
        }
        */

        ////////////////////////////////////////////////
        // *return

        /*
        static double Multiplicar(double x, double y)
        {
            
            return x * y;
        }
        */

        ////////////////////////////////////////////////
        // *Method overloading

        /*
        static int Somar(int a, int b)
        {
            return a + b;
        }

        static int Somar(int a, int b, int c)
        {
            return a + b + c;
        }
        */

        ////////////////////////////////////////////////
        // *Parametros keywords

        /*
       static double CheckOut(params double[] preços)
        {
            double total = 0;

            foreach(double preço in preços)
            {
                total += preço;
            }
            return total;
        }
        */
    }
}
