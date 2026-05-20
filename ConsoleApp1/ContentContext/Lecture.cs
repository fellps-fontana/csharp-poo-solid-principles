using ConsoleApp1.ContentContext.Enums;

namespace ConsoleApp1.ContentContext;

public class Lecture : Base
{
    public Lecture()
    {
        
    }
    public int Order { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level{get; set;}


}