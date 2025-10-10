using Microsoft.EntityFrameworkCore;

public class TodoContext : DbContext
{
    private const string DbPath = "data.sqlite";

    // Mettre à jour cette section en fonction du projet (Models/)
    public DbSet<Etudiant> Etudiant { get; set; } = null!;
    public DbSet<Module> Module { get; set; } = null!;
    public DbSet<Inscritpion> Inscription { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var dpPath = Path.Combine(Directory.GetCurrentDirectory(), "data.sqlite");
        options.UseSqlite($"Data Source={DbPath}");
    }
}