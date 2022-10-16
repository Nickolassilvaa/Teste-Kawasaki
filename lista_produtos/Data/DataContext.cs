using lista_produto;
using Microsoft.EntityFrameworkCore;

namespace lista_produtos.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
