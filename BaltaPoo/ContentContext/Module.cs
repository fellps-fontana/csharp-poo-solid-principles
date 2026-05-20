namespace ConsoleApp1.ContentContext;

public class Module  : Base
{
    public Module()
    {
        Leacture = new List<Lecture>();
    }
    public int  Order { get; set;}
    public string Title { get; set; }
    public IList<Lecture> Leacture { get; set; }
    
        
}