using ConsoleApp1.ContentContext;
using ConsoleApp1.NotificationContext;

namespace ConsoleApp1.SubscriptionContent;

public class Student : Base
{
    public Student()
    {
        Subscriptions = new List<Subscription>();
    }
    public User User { get; set; }
    public String Name { get; set; }
    public String Email { get; set; }
    public IList<Subscription>  Subscriptions { get; set; }

    public void CreateSubscription(Subscription subscription)
    {
        if (IsPremium)
        {
            AddNotification(new Notification("Premium", "O aluno ja e premium"));
        }
        Subscriptions.Add(subscription);
    }
    public bool IsPremium => Subscriptions.Any(x=>!x.IsInactive);
}