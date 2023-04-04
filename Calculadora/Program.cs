using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------");
            Console.WriteLine("Selecione uma opção:");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao) 
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma() 
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float numero2 = float.Parse(Console.ReadLine());

            float resultado = numero1 + numero2;

            Console.WriteLine($"A soma é {resultado}");

            Console.ReadLine();
            Menu();
        }

        static void Subtracao() 
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            float numero2 = float.Parse(Console.ReadLine());

            float resultado = numero1 - numero2;

            Console.WriteLine($"A subtração é {resultado}");

            Console.ReadLine();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            float numero2 = float.Parse(Console.ReadLine());

            float resultado = numero1 / numero2;

            Console.WriteLine($"A divisão é {resultado}");

            Console.ReadLine();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            float numero2 = float.Parse(Console.ReadLine());

            float resultado = numero1 * numero2;

            Console.WriteLine($"A multiplicação é {resultado}");

            Console.ReadLine();
            Menu();

        }
    }
}
