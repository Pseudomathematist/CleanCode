3.1
public class PalindromeChecker
{
    public static bool IsPalindrome(string text)
    {
        // Преобразуем текст в нижний регистр и удаляем пробелы.
        text = text.ToLower().Replace(" ", "");

        // Сравниваем текст с его обратным вариантом.
        return text == new string(text.ToCharArray().Reverse().ToArray());
    }

    public static void Main(string[] args)
    {
        // Пример использования функции IsPalindrome.
        string text = "А роза упала на лапу Азора";
        bool isPalindrome = IsPalindrome(text);
        Console.WriteLine($"{text} - {isPalindrome}");
    }
}
//

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    // Метод для вывода информации о книге
    public void PrintInfo()
    {
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Количество страниц: {Pages}");
    }
}
//

public class BookLibrary
{
    public List<Book> Books { get; set; }

    public BookLibrary()
    {
        Books = new List<Book>();
    }

    // Метод для добавления книги в библиотеку
    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    // Метод для поиска книги по названию
    public Book FindBook(string title)
    {
        foreach (Book book in Books)
        {
            if (book.Title == title)
            {
                return book;
            }
        }
        return null;
    }

    public static void Main(string[] args)
    {
        // Создаем библиотеку
        BookLibrary library = new BookLibrary();

        // Добавляем книги
        library.AddBook(new Book("Война и мир", "Лев Толстой", 885));
        library.AddBook(new Book("Преступление и наказание", "Фёдор Достоевский", 680));

        // Ищем книгу
        Book foundBook = library.FindBook("Преступление и наказание");

        if (foundBook != null)
        {
            Console.WriteLine("Найдена книга:");
            foundBook.PrintInfo();
        }
        else
        {
            Console.WriteLine("Книга не найдена.");
        }
    }
}
//

public class BookSorter
{
    // Метод для сортировки списка книг по автору
    public static List<Book> SortByAuthor(List<Book> books)
    {
        return books.OrderBy(book => book.Author).ToList();
    }

    // Метод для сортировки списка книг по количеству страниц
    public static List<Book> SortByPages(List<Book> books)
    {
        return books.OrderByDescending(book => book.Pages).ToList();
    }

    public static void Main(string[] args)
    {
        // Создаем список книг
        List<Book> books = new List<Book>()
        {
            new Book("Война и мир", "Лев Толстой", 885),
            new Book("Преступление и наказание", "Фёдор Достоевский", 680),
            new Book("Мастер и Маргарита", "Михаил Булгаков", 422),
        };

        // Сортируем книги по автору
        List<Book> sortedByAuthor = SortByAuthor(books);
        Console.WriteLine("Сортировка по автору:");
        foreach (Book book in sortedByAuthor)
        {
            book.PrintInfo();
        }

        // Сортируем книги по количеству страниц
        List<Book> sortedByPages = SortByPages(books);
        Console.WriteLine("\nСортировка по количеству страниц:");
        foreach (Book book in sortedByPages)
        {
            book.PrintInfo();
        }
    }
}
//


public class BookDictionary
{
    public Dictionary<string, Book> Books { get; set; }

    public BookDictionary()
    {
        Books = new Dictionary<string, Book>();
    }

    // Метод для добавления книги в словарь по ее названию
    public void AddBook(Book book)
    {
        Books[book.Title] = book;
    }

    // Метод для поиска книги по названию
    public Book FindBook(string title)
    {
        if (Books.ContainsKey(title))
        {
            return Books[title];
        }
        return null;
    }

    public static void Main(string[] args)
    {
        // Создаем словарь книг
        BookDictionary dictionary = new BookDictionary();

        // Добавляем книги
        dictionary.AddBook(new Book("Война и мир", "Лев Толстой", 885));
        dictionary.AddBook(new Book("Преступление и наказание", "Фёдор Достоевский", 680));

        // Ищем книгу
        Book foundBook = dictionary.FindBook("Преступление и наказание");

        if (foundBook != null)
        {
            Console.WriteLine("Найдена книга:");
            foundBook.PrintInfo();
        }
        else
        {
            Console.WriteLine("Книга не найдена.");
        }
    }
}
///


public class EvenNumberChecker
{
    public static bool IsEven(int number)
    {
        // Проверяем, делится ли число на 2 без остатка.
        return number % 2 == 0;
    }

    public static void Main(string[] args)
    {
        // Пример использования функции IsEven.
        int number = 10;
        bool isEven = IsEven(number);
        Console.WriteLine($"{number} - {isEven}");
    }
}
//
public class BookSorterLambda
{
    public static void Main(string[] args)
    {
        // Создаем список книг
        List<Book> books = new List<Book>()
        {
            new Book("Война и мир", "Лев Толстой", 885),
            new Book("Преступление и наказание", "Фёдор Достоевский", 680),
            new Book("Мастер и Маргарита", "Михаил Булгаков", 422),
        };

        // Сортируем книги по автору
        List<Book> sortedByAuthor = books.OrderBy(book => book.Author).ToList();
        Console.WriteLine("Сортировка по автору:");
        foreach (Book book in sortedByAuthor)
        {
            book.PrintInfo();
        }

        // Сортируем книги по количеству страниц
        List<Book> sortedByPages = books.OrderByDescending(book => book.Pages).ToList();
        Console.WriteLine("\nСортировка по количеству страниц:");
        foreach (Book book in sortedByPages)
        {
            book.PrintInfo();
        }
    }
}
