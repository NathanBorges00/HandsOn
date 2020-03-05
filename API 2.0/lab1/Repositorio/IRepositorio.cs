using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lab1
{
    public interface IRepositorio
    {
        void Add(Produto produto);

        void Update(Produto produto);

        void Remove(Guid id);

        Produto Get(Guid id);

        IList<Produto> GetAll();

        Task SaveChangesAsync();
    }
}