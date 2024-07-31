using CadastroPassoas1.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroPassoas1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    DbSet<Pessoa> Pessoas { get; set; } = null!;
}
