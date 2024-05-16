using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.Dados;

public class DDados : DbContext
{
    public DDados(DbContextOptions<DDados> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    public DbSet<HistoricoModel> historicoModels { get; set; }
    
}

