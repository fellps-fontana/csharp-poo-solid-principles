using ConsoleApp1.ContentContext;
using ConsoleApp1.ContentContext.Enums;

internal class Program
{
    public static void Main(string[] args)
    {
        var course = new Course(title:"s", url:"asd");
        var course2 = new Course(title:"s1", url:"asd");
        var course3 = new Course(title:"s2", url:"asd");
        var course4 = new Course(title:"s3", url:"asd");
        
        var carreira = new Career(title:"carreira", "asd");
        var careerItemList = new List<CareerItem>();
        var Sequencia3 = new CareerItem(3, "teste", "vida", course);
        var Sequencia2 = new CareerItem(2, "teste", "vida", course2);
        var Sequencia1 = new CareerItem(1, "teste", "vida", course3);
        careerItemList.Add(Sequencia1);
        careerItemList.Add(Sequencia2);
        careerItemList.Add(Sequencia3);
        carreira.Items = careerItemList;
        foreach (var item in carreira.Items)
        {
            Console.WriteLine(item.Course.Title);
            foreach (var careerItem in careerItemList.OrderBy(x=>x.Order))
            {
                Console.WriteLine(careerItem.Order);
            }
        }
        
    }

}