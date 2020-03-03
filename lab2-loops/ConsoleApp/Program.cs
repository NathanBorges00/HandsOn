using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            int a = 0;
            
            System.Console.Write("Pares: ");
            
            for(int i = 1; i < 12; i++)
            {
                if(i % 2 == 0)
                {
                    System.Console.Write(i + " ");
                }
            }

            System.Console.WriteLine("\n");

            while(a <= 5)
            {
                System.Console.Write(a + " ");
                a++;
            }
        }
    }
}
