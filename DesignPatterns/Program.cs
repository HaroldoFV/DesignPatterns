using DesignPatterns.FactoryMethod;
using DesignPatterns.Observer;
using DesignPatterns.Singleton;

DatabaseConnection.Instance.Connect(); // singleton - Criacional

DocumentCreator creator = new PDFDocumentCreator();
creator.OpenDocument(); // factory method - Criacional
creator = new WordDocumentCreator();
creator.OpenDocument(); // factory method - Criacional

// Observer - Comportamental
NewsAgency agency = new();
NewsSubscriber john = new("John");
NewsSubscriber jane = new("Jane");

agency.AddObserver(john);
agency.AddObserver(jane);
agency.PublishNews("Nova vacina descoberta!");