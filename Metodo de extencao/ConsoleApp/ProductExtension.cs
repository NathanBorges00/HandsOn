using System;

namespace ConsoleApp.src.Extensions
{
   public static class ProductExtension
   {
       public static void AddTag(this Product product)
       {
           // implementação...
           System.Console.WriteLine("AOBA!");
           Console.ReadKey();
       }
   }
}