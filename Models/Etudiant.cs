public class Etudiant
{
    public int Id { get; set; }
    public string Nom { get; set; } = "";// public required string nom {gte;set;} : pour assurer que les chaines nom et prenom ne seront pas nulles
    public string Prenom { get; set; } = "";

    public Etudiant()
    {
        Nom = "";
        Prenom = "";
    }
    
    public Etudiant (string nom, string prenom)
    {
        Nom = nom;
        Prenom = prenom; 
    }

    public override string ToString()
    {
        string message = $" l'id est {Id} le nom est {Nom} et le prenom est {Prenom}";
        return message;
    }

    
}