public enum Note { A, B, C, D, E, F }
public class Inscritpion
{
    // ràv : heritage represente entre les classes par des fleches 
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public Note Note { get; set; }

    public Module Module { get; set; } = null!;
    public Etudiant Etudiant { get; set; } = null!;

    public override string ToString()
    {
        string msg = $" id = {Id}, Date = {Date}, note : {Note}";
        return msg;
    }
}