namespace Singleton;

public class DangerSingleton
{
    private static DangerSingleton _instance;
    
    private DangerSingleton() { }

    public static DangerSingleton GetInstance()
    {
        _instance ??= new DangerSingleton();

        return _instance;
    }

    public void DoWork()
    {
        Console.WriteLine("Я делаю работу!");
    }
}