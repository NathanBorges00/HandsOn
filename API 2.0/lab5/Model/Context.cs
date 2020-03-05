using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public class Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public Context(DbContextOptions options)
            : base(options)
        {
        }
    }
}