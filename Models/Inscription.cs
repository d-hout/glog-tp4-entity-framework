public class Inscritpion
{
    public enum Note { A, B, C, D, E, F } // ràv : heritage represente entre les classes par des fleches 
    public int Identifiant { get; set; }
    public DateOnly Date { get; set; }
    public Note Note { get; set; }

    public Module Module { get; set; }
    public Etudiant Etudiant { get; set; }

    public override string Tostring()
    {
        string msg = $" id = {Identifiant}, Date = {Date}, note : {Note}";
    }
}