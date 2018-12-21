using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, e;
            int d = 0;

            Random rnd = new Random();
            int randa = rnd.Next(1, 50);
            int randb = rnd.Next(1, 50);
           
            Console.WriteLine("\nDigite a opção desejada");
            Console.WriteLine("\n1 para Soma");
            Console.WriteLine("\n2 para Subtração");
            Console.WriteLine("\n3 para Multiplicação");

            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine("\nVoce escolheu Soma");
                    d = randa + randb;
                    break;
                case 2:
                    Console.WriteLine("\nVoce escolheu Subtração");
                    d = randa - randb;
                    break;
                case 3:
                    Console.WriteLine("\nVoce escolheu Multiplicação");
                    d = randa * randb;
                    break;
                default:
                    Console.WriteLine("\nOpção incorreta");
                    break;
            }
            Console.WriteLine("\nO primeiro valor é: "+randa+" e o segundo valor é: "+randb);
            Console.WriteLine("\nAgora digite o valor que você acha que é o resultado");
            e = int.Parse(Console.ReadLine());
            if (e == d)
            {
                Console.WriteLine("\nParabens vc acertou o resultado é: " + d);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nVoce errou o resultado correto seria: " + d);
                Console.ReadKey();
            }
        }
    }
}
