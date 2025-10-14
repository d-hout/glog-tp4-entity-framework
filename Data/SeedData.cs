using System;

public class SeedData
{
    public static void Initialise(UniversiteContext context)
    {

        Etudiant eleve1 = new Etudiant("Dupont", "Pierre");
        Etudiant eleve2 = new Etudiant("Deramaix", "Mathilde");
        Etudiant eleve3 = new Etudiant("Sacher", "Juliette");
        Etudiant eleve4 = new Etudiant("Lefrais", "Jeanne");

        context.Etudiant.AddRange(eleve1, eleve2, eleve3, eleve4);

        Module m1 = new Module("Math", 50);
        Module m2 = new Module("Cognitique", 50);
        Module m3 = new Module("Anglais", 50);
        Module m4 = new Module("Biologie", 50);

        context.Module.AddRange(m1, m2, m3, m4);

        Inscription i1 = new Inscription(new DateOnly(2025, 10, 10), Note.A, m1, eleve1);
        Inscription i2 = new Inscription(new DateOnly(2025, 10, 10), Note.E, m2, eleve2);
        Inscription i3 = new Inscription(new DateOnly(2025, 10, 10), Note.F, m3, eleve3);
        Inscription i4 = new Inscription(new DateOnly(2025, 10, 10), Note.A, m3, eleve3);

        context.Inscription.AddRange(i1, i2, i3, i4);

        context.SaveChanges();

    }
}
