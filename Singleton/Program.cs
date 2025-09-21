using Singleton;

var instance = DangerSingleton.GetInstance();

instance.DoWork();

Parallel.For(0, 5, i =>
{
    var instance = LazySingleton.Instance;
    
    instance.DoWork();
});