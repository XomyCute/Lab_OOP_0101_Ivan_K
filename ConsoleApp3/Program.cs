using System;

class Book
{
    private string author;
    private string title;
    private int year;
    private string group;

    public Book()
    {
        author = "Unknown";
        title = "Unknown";
        year = 0;
        group = "Unknown";
    }

    public Book(string author, string title, int year, string group)
    {
        this.author = author;
        this.title = title;
        this.year = year;
        this.group = group;
    }

    public Book(Book book)
    {
        this.author = book.author;
        this.title = book.title;
        this.year = book.year;
        this.group = book.group;
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public string Group
    {
        get { return group; }
        set { group = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Сенкевич", "Потоп", 1978, "Х");
        Book book2 = new Book("Ландау", "Механика", 1989, "У");

        Console.WriteLine("Автор книги\t\tНазва\t\tРик випуску\t\tГрупа");
        Console.WriteLine(book1.Author + "\t\t" + book1.Title + "\t\t" + book1.Year + "\t\t" + book1.Group);
        Console.WriteLine(book2.Author + "\t\t" + book2.Title + "\t\t" + book2.Year + "\t\t" + book2.Group);

        Console.ReadLine();
    }
}