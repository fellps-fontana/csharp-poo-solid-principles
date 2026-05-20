using ConsoleApp1.NotificationContext;

namespace ConsoleApp1.ContentContext;

public abstract class Base : Notifiable
{
    public Base()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
}