using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DÉMARRAGE PROGRAMME");

        using (var context = new UniversiteContext())
        {

            var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "data.sqlite");
            Console.WriteLine($"📂 Base de données : {dbPath}");
            Console.WriteLine("\n📘 Liste des modules (ordre alphabétique) :");

            var modules = context.Module
                .OrderBy(m => m.Institule)
                .ToList();

            foreach (var module in modules)
            {
                Console.WriteLine($"- {module.Institule} ({module.Credit} crédits)");
            }

            var etudiants = context.Etudiant
                .OrderByDescending(e => e.Id)
                .ToList();
            Console.WriteLine("\n📗 Liste des étudiants (ID décroissant) :");

            foreach (var e in etudiants)
            {
                Console.WriteLine($"- {e.Id} : {e.Nom} {e.Prenom}");
            }


        }
    }
}
