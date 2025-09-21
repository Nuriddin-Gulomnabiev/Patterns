namespace Singleton;

public class LazySingleton
{
    private static readonly Lazy<LazySingleton> _instance = new(() => new LazySingleton());

    private LazySingleton() { }

    public static LazySingleton Instance => _instance.Value;

    public void DoWork()
    {
        Console.WriteLine("Работаю в единственном экземпляре");
    }
}
