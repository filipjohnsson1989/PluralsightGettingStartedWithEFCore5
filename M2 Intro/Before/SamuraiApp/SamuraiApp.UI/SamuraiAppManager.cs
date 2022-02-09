using SamuraiApp.Data;
using SamuraiApp.Domain;

namespace SamuraiApp.UI;

public class SamuraiAppManager
{
    private SamuraiContext context;
    public SamuraiAppManager()
    {
        context = new();
    }

    public void Start()
    {
        context.Database.EnsureCreated();

    }

    public int AddSamurai(string name)
    {
        Samurai samurai = new() { Name = name };
        context.Samurais.Add(samurai);
        context.SaveChanges();
        return samurai.Id;
    }

    public int AddQuote(int samuraiId, string text)
    {
        Quote quote = new() { SamuraiId = samuraiId, Text = text };
        context.Quotes.Add(quote);
        context.SaveChanges();
        return quote.Id;
    }

    public IEnumerable<string> GetSamurais() => context.Samurais.Select(s => $"Name: {s.Name}\n\rQuates:{String.Join(',', s.Quotes.Select(c => c.Text))}").ToList();
}
