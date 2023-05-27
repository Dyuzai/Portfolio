using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeTemperatura_sem_interface_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Olá, seja bem-vindo.");
            Console.WriteLine("Escolha qual temperatura está usando");
            Console.WriteLine("Digite 1 para Celsius");
            Console.WriteLine("Digite 2 para Fahrenheit");
            Console.WriteLine("Digite 3 para Kelvin");
            Console.WriteLine("----------");

            char Escolha = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("----------");

            if (Escolha == '1')
            {

                Console.WriteLine("Digite para qual temperatura quer converter");
                Console.WriteLine("Digite 1 para Fahrenheit");
                Console.WriteLine("Digite 2 para Kelvin");
                Console.WriteLine("----------");
                char Escolha2 = Convert.ToChar(Console.ReadLine());
                

                if (Escolha2 == '1')
                {
                    Console.WriteLine("Digite a temperatura em Celcius");
                    Int32 Celcius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------");

                    double F = 1.8 * Celcius + 32;

                    Console.WriteLine("O valor " + Celcius + " Em Fahrenheit é " + F);
                }
                    else if (Escolha2 == '2')
                {
                    Console.WriteLine("Digite a temperatura em Celcius");
                    Int32 Celcius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------");

                    int K = Celcius + 273;

                    Console.WriteLine("O valor " + Celcius + " Em Kelvin é " + K);

                }
                    else
                {
                    Console.WriteLine("Desconheço essa tecla");
                }
            }
            else if (Escolha == '2')
            {
                Console.WriteLine("Digite para qual temperatura quer converter");
                Console.WriteLine("Digite 1 para Celsius");
                Console.WriteLine("Digite 2 para Kelvin");
                Console.WriteLine("----------");
                char Escolha2 = Convert.ToChar(Console.ReadLine());
                

                if (Escolha2 == '1')
                {
                    Console.WriteLine("Digite a temperatura em Fahrenheit");
                    Console.WriteLine("----------");
                    Int32 Fahrenheit = Convert.ToInt32(Console.ReadLine());
                    

                    double C = (Fahrenheit - 32) / 1.8;

                    Console.WriteLine("O valor " + Fahrenheit + " Em Celcius é " + C);
                }
                else if (Escolha2 == '2')
                {
                    Console.WriteLine("Digite a temperatura em Fahrenheit");
                    Console.WriteLine("----------");
                    Int32 Fahrenheit = Convert.ToInt32(Console.ReadLine());


                    double K = ((Fahrenheit - 32) / 1.8) + 273;
                    Console.WriteLine("O valor " + Fahrenheit + " Em Kelvin é " + K);
                }
                else
                {
                    Console.WriteLine("Desconheço essa tecla");
                }
            }
            else if (Escolha == '3')
            {
                Console.WriteLine("Digite para qual temperatura quer converter");
                Console.WriteLine("Digite 1 para Celsius");
                Console.WriteLine("Digite 2 para Fahrenheit");
                Console.WriteLine("----------");
                char Escolha2 = Convert.ToChar(Console.ReadLine());
                

                if (Escolha2 == '1')
                {
                    Console.WriteLine("Digite a temperatura em Kelvin");
                    Console.WriteLine("----------");
                    Int32 Kelvin = Convert.ToInt32(Console.ReadLine());
                    

                    int C = Kelvin - 273;

                    Console.WriteLine("O valor " + Kelvin + " Em Celcius é " + C);
                }
                else if(Escolha2 == '2')
                {
                    Console.WriteLine("Digite a temperatura em Fahrenheit");
                    Console.WriteLine("----------");
                    Int32 Kelvin = Convert.ToInt32(Console.ReadLine());
                    

                    double F = ((Kelvin - 273) * 1.8) + 32;
                    Console.WriteLine("O valor " + Kelvin + " Em Fahrenheit é " + F);
                }
                else
                {
                    Console.WriteLine("Desconheço essa tecla");
                }
            }
            else
            {
                Console.WriteLine("Desconheço Tecla digitado");

            }

            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
