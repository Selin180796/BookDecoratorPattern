
using System;

class Program
{
    static void Main()
    {
        
        IComponent<string> book = new ConcreteComponent("Book Decorator Pattern is different.");

        
        IComponent<string> plainBook = new PlainDecorator(book);
        IComponent<string> upperCaseBook = new UpperCaseDecorator(book);
        IComponent<string> coloredBook = new ColorDecorator(book);

        
        Console.WriteLine("Original Title: " + book.GetText());
        Console.WriteLine("Plain Title: " + plainBook.GetText());
        Console.WriteLine("Uppercase Title: " + upperCaseBook.GetText());
        Console.WriteLine("Colored Title: " + coloredBook.GetText());
    }
}
