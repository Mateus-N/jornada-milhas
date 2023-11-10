using JornadaMilhasApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JornadaMilhasApi.Data;

public class AppDbContext : DbContext
{
    public DbSet<Companhia> Companhias { get; set; }
    public DbSet<Depoimento> Depoimentos { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<Passagem> Passagens { get; set; }
    public DbSet<Promocao> Promocoes { get; set; }
    public DbSet<Usuario> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Passagem>()
            .HasOne(p => p.Origem)
            .WithMany(e => e.PassagensOrigem)
            .HasForeignKey(p => p.OrigemId);

        builder.Entity<Passagem>()
            .HasOne(p => p.Destino)
            .WithMany(e => e.PassagensDestino)
            .HasForeignKey(p => p.DestinoId);

        builder.Entity<Passagem>()
            .HasOne(p => p.Companhia)
            .WithMany(c => c.Passagens)
            .HasForeignKey(p => p.CompanhiaId);

        builder.Entity<Usuario>()
            .HasOne(u => u.Estado)
            .WithMany(e => e.UserEstado)
            .HasForeignKey(p => p.EstadoId);
    }
}
