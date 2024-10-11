namespace DesignPatterns.Observer;

public interface IObserver
{
    void Update(string message);
}

public class NewsSubscriber : IObserver
{
    private readonly string _name;

    public NewsSubscriber(string name)
    {
        this._name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} received the news: {message}");
    }
}

public class NewsAgency
{
    private List<IObserver> _observers = new();

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void PublishNews(string news)
    {
        foreach (var observer in _observers)
        {
            observer.Update(news);
        }
    }
}

// Observer
// O padrão Observer define uma dependência um-para-muitos entre objetos,
// de modo que quando um objeto muda de estado, todos os seus dependentes
// são notificados e atualizados automaticamente.