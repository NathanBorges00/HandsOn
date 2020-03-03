using System;

namespace ConsoleApp
{
    public class RepositorioGenerico<T> where T : class, new()
    {
        public Guid Save(T obj)
        {
            return Guid.NewGuid();
        }

        public void Update(T obj)
        {

        }

        public void Delete(T obj)
        {

        }

        public Object Get(Guid id)
        {
            return null;
        }
    }

    public class Cliente
    {

    }

    public class Produto
    {

    }

    public class Teste
    {
        public static void Main()
        {
            RepositorioGenerico<Produto> produto = new RepositorioGenerico<Produto>();
            RepositorioGenerico<Cliente> cliente = new RepositorioGenerico<Cliente>();
            Console.ReadKey();
        }
    }
}
