using LessonsBotDbProvider.CacheDownloader;
using LessonsBotDbProvider.Controller;
using LessonsBotDbProvider.ModelsDb;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        CacheController ef = new CacheController();
        ef.StartMigrate();

        Controller s = new Controller();
        s.BotNewCreate("asdf", 1500);

    }
}