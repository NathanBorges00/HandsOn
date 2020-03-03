using System;

namespace Generics
{ 
    public class MinhaClasseGenerica<T> where T : struct
    {
        public T Field;   
    }
    class Program
    {
        static void Main(string[] args)
        {
            MinhaClasseGenerica<int> g = new  MinhaClasseGenerica<int>();
            //MinhaClasseGenerica<string> g = new  MinhaClasseGenerica<string>();
            Console.ReadKey();
        }
    }
}