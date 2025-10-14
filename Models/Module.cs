public class Module
{
    public int Id { get; set; }
    public string Institule { get; set; } = "";

    public int Credit { get; set; }

    public Module()
    {
        Institule = "";
        Credit = 0;
    }
    public Module(string institule, int credit)
    {
        Institule = institule;
        Credit = credit; 


    }
    public override string ToString()
    {
        string msg = $"l'id est {Id} , Institule : {Institule}, Credit : {Credit}";
        return msg;
    }

}