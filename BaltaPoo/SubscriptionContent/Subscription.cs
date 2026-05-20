using ConsoleApp1.ContentContext;

namespace ConsoleApp1.SubscriptionContent;

public class Subscription : Base
{
    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsInactive => EndDate <= DateTime.Now;
}