using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;

//herdar de DbContext
public class AppDbContext : DbContext
{
    //construtor
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    //propriedade DbSet, que representa a tabela no banco de dados

    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Categoria>? Categorias { get; set; }


}
