namespace DesignPatterns.Singleton;

public sealed class DatabaseConnection
{
    private static DatabaseConnection instance = null;
    private static readonly object padlock = new object();

    private DatabaseConnection()
    {
    }

    public static DatabaseConnection Instance
    {
        get
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseConnection();
                    }
                }
            }

            return instance;
        }
    }

    public void Connect()
    {
        Console.WriteLine("Conectado ao banco de dados.");
    }
}


// Singleton
// O padrão Singleton garante que uma classe tenha apenas
// uma instância e fornece um ponto global de acesso a ela.