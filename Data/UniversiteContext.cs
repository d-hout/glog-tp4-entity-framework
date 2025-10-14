using Microsoft.EntityFrameworkCore;

using System.IO;

public class UniversiteContext : DbContext
{
    public DbSet<Etudiant> Etudiant { get; set; } = null!;
    public DbSet<Module> Module { get; set; } = null!;
    public DbSet<Inscription> Inscription { get; set; } = null!;
    public string DbPath { get; private set; }
    public UniversiteContext()
    {
        // Path to SQLite database file
        DbPath = "EFUniversity.db";
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Le fichier SQLite sera créé dans le dossier courant
        var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "data.sqlite");
        options.UseSqlite($"Data Source={dbPath}");
    }
}
