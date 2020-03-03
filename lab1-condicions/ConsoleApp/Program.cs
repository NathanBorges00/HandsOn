using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int valor);

            while(valor < 1 || valor > 100)
            {
                System.Console.WriteLine("Valor invalido para o sorteio. por favor entre com um valor de 1 a 100");
                int.TryParse(Console.ReadLine(), out valor);
            }

            if(valor == 40 || valor == 75 ||valor == 90)
            {
                System.Console.WriteLine("Sortudo, ganhou um carro");
            }
            else
            {
                System.Console.WriteLine("Tente novamente, quem sabe voce ganha!");
            }

            Console.ReadKey();
        }
    }
}
