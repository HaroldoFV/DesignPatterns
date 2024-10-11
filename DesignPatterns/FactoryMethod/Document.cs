namespace DesignPatterns.FactoryMethod;

public abstract class Document
{
    public abstract void Open();
    public abstract void Save();
}

public class PDFDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Abrindo documento PDF.");
    }

    public override void Save()
    {
        Console.WriteLine("Salvando documento PDF.");
    }
}

public class WordDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Abrindo documento Word.");
    }

    public override void Save()
    {
        Console.WriteLine("Salvando documento Word.");
    }
}

public abstract class DocumentCreator
{
    public abstract Document CreateDocument();

    public void OpenDocument()
    {
        Document doc = CreateDocument();
        doc.Open();
    }
}

public class PDFDocumentCreator : DocumentCreator
{
    public override Document CreateDocument()
    {
        return new PDFDocument();
    }
}

public class WordDocumentCreator : DocumentCreator
{
    public override Document CreateDocument()
    {
        return new WordDocument();
    }
}

// Factory Method
// O padrão Factory Method define uma interface para criar um objeto,
// mas permite que as subclasses decidam qual classe instanciar.