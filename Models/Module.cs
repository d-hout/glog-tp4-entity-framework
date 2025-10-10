public class Module
{
    public int Id { get; set; }
    public string Institule { get; set; } = ""; 

    public int Credit { get; set; }

    public override string ToString()
    {
        string msg = $"l'id est {Id} , Institule : {Institule}, Credit : {Credit}";
        return msg;
    }

}