// See https://aka.ms/new-console-template for more information
using SamuraiApp.UI;

Console.WriteLine("Hello, World!");

SamuraiAppManager manager = new();
manager.Start();

do
{
    Console.WriteLine("Name");
    var name = Console.ReadLine();
    var samuraiId = manager.AddSamurai(name!);
    for (int i = 3 - 1; i >= 0; i--)
    {

        Console.WriteLine("Quote");
        var quote = Console.ReadLine();
        manager.AddQuote(samuraiId, quote!);
    }
    foreach (var samurai in manager.GetSamurais())
    {
        Console.WriteLine(samurai);
    }


} while (true);
