namespace FireApp.Services;

public class ServiceManagement : IServiceManagement
{
    public void GenerateMerchandise()
    {
        Console.WriteLine($"Generate Merchandise: Long running task {DateTime.Now:yyy-MM-dd HH:mm:ss}");
    }

    public void SendEmail()
    {
         Console.WriteLine($"Send Email: Short running task {DateTime.Now:yyy-MM-dd HH:mm:ss}");
    }

    public void SyncData()
    {
        Console.WriteLine($"Sync Data: Short running task {DateTime.Now:yyy-MM-dd HH:mm:ss}");
    }

    public void UpdateDatabase()
    {
        Console.WriteLine($"Update Database: Long running task {DateTime.Now:yyy-MM-dd HH:mm:ss}");
    }
}