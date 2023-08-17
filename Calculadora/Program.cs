using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora");
            Console.WriteLine("");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto da divisão"); //segundo desafio
            Console.WriteLine("6 - Potencia"); //segundo desafio
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.Write("Insira a opção desejada: ");

            string operador;

            string opcao;
            opcao = Console.ReadLine();

            string valor1, valor2;
            float resultado;
            double potenciaResultado;

            Console.Write("Insira o primeiro valor: ");
            valor1 = Console.ReadLine();
            Console.Write("Insira o segundo valor: ");
            valor2 = Console.ReadLine();

            var isNumericValor1 = float.TryParse(valor1, out float n); // validação numérico
            var isNumericValor2 = float.TryParse(valor2, out float m); // validação numérico

            if (isNumericValor1 == false || isNumericValor2 == false)
            {
                Console.WriteLine("Um dos valores inseridos não é numerico!");
                return;
            }

            switch (opcao)
            {
                case "1":
                    operador = "+";
                    resultado = float.Parse(valor1) + float.Parse(valor2);
                    break;      
                case "2":
                    operador = "-";
                    resultado = float.Parse(valor1) - float.Parse(valor2);
                    break;
                case "3":
                    operador = "*";
                    resultado = float.Parse(valor1) * float.Parse(valor2);
                    break;
                case "4":
                    operador = "/";
                    if (valor1 == "0" || valor2 == "0") //validação para divisão
                    {
                        Console.WriteLine("Divisão por zero!");
                        return;
                    }
                    resultado = float.Parse(valor1) / float.Parse(valor2);
                    break;
                case "5":
                    operador = "%";
                    resultado = float.Parse(valor1) % float.Parse(valor2);
                    break;
                case "6":
                    operador = "^";
                    potenciaResultado = Math.Pow(double.Parse(valor1), double.Parse(valor2));
                    Console.WriteLine("Resultado da operação " + valor1 + " " + operador + " " + valor2 + " = " + potenciaResultado);
                    return;
                case "0":
                    Console.WriteLine("Até mais!");
                    return;
                default: 
                    Console.WriteLine("Opção inválida!");
                    return;
                    
            }

            Console.WriteLine("");
            Console.WriteLine("Resultado da operação " + valor1 + " " + operador + " " + valor2 + " = " + resultado);

        }
    }
}
