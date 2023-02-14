using LessonsBotDbProvider.CacheDownloader;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        CacheController ef = new CacheController();
        ef.StartMigrate();
    }
}