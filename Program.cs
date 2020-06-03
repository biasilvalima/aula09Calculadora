using System;
using System.Diagnostics;

namespace aula09Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a operação desejada: ");
            string operação = (Console.ReadLine());

            System.Console.WriteLine("Digite o segundo valor: ");
            int valor2 = int.Parse (Console.ReadLine());

            Console.ReadKey();

            switch(operação){
                case "+":
                System.Console.WriteLine($"Resultado: {valor1} + {valor2} = " + (valor1 + valor2));
                break;

                case "-":
                System.Console.WriteLine($"Resultado: {valor1} - {valor2} = " + (valor1 - valor2));
                break;

                case "x":
                System.Console.WriteLine($"Resultado: {valor1} * {valor2} = " + (valor1 * valor2));
                break;

                case "/":
                    int v = valor1 / valor2;
                    System.Console.WriteLine($"Resultado: {valor1} / {valor2} = " + valor1 / valor2);
                break;
            }
        }

      }
   }





            
    

        
