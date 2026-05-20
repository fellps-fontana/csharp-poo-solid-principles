using ConsoleApp1.ContentContext.Enums;

namespace ConsoleApp1.ContentContext;

public class Course: Content
{
    public Course(string title, string url):base(title, url)
    {
        Modules = new List<Module>();
    }
    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level{get; set;}
}




