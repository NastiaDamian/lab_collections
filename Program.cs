using System;
using System.Collections.Generic;

// Клас для представлення документу
public class Document
{
    public string Title { get; set; }
    public string Content { get; set; }

    public override string ToString()
    {
        return $"{Title}: {Content}";
    }
}

class Program
{
    static void Main()
    {
        // Керування стеком документів
        Console.WriteLine("Stack of Documents:");
        Stack<Document> documentStack = new Stack<Document>();

        // Додавання нових документів
        documentStack.Push(new Document { Title = "Document1", Content = "Content1" });
        documentStack.Push(new Document { Title = "Document2", Content = "Content2" });

        // Виведення інформації про верхній документ
        PrintTopDocumentInfo(documentStack);

        // Видалення верхнього документу
        documentStack.Pop();

        // Виведення інформації про новий верхній документ
        PrintTopDocumentInfo(documentStack);

        // Керування чергою замовлень
        Console.WriteLine("\nQueue of Orders:");
        Queue<string> orderQueue = new Queue<string>();

        // Додавання нових замовлень
        EnqueueOrder(orderQueue, "Order1");
        EnqueueOrder(orderQueue, "Order2");

        // Виведення інформації про найстарше замовлення
        PrintOldestOrderInfo(orderQueue);

        // Видалення найстаршого замовлення
        DequeueOrder(orderQueue);

        // Виведення інформації про нове найстарше замовлення
        PrintOldestOrderInfo(orderQueue);

        // Магазин книг зі словником
        Console.WriteLine("\nBookstore with Dictionary:");
        Dictionary<int, Book> bookDictionary = new Dictionary<int, Book>();

        // Додавання нових книг
        AddBookToDictionary(bookDictionary, 1, "Harry Potter", "J. K. Rowling");
        AddBookToDictionary(bookDictionary, 2, "ALICE'S ADVENTURES IN WONDERLAND", " Lewis Carroll");

        // Виведення інформації про книгу за її унікальним ідентифікатором
        PrintBookInfoById(bookDictionary, 1);

        // Видалення книги за її унікальним ідентифікатором
        RemoveBookById(bookDictionary, 1);

        // Виведення інформації про книгу за видаленим унікальним ідентифікатором
        PrintBookInfoById(bookDictionary, 1);
    }

    // Метод для виведення інформації про верхній документ у стеці
    static void PrintTopDocumentInfo(Stack<Document> stack)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine("Top Document: " + stack.Peek());
        }
        else
        {
            Console.WriteLine("Stack is empty.");
        }
    }

    // Метод для додавання нового замовлення до черги
    static void EnqueueOrder(Queue<string> queue, string order)
    {
        queue.Enqueue(order);
        Console.WriteLine($"Enqueued Order: {order}");
    }

    // Метод для виведення інформації про найстарше замовлення в черзі
    static void PrintOldestOrderInfo(Queue<string> queue)
    {
        if (queue.Count > 0)
        {
            Console.WriteLine("Oldest Order: " + queue.Peek());
        }
        else
        {
            Console.WriteLine("Queue is empty.");
        }
    }

    // Метод для видалення найстаршого замовлення з черги
    static void DequeueOrder(Queue<string> queue)
    {
        if (queue.Count > 0)
        {
            string oldestOrder = queue.Dequeue();
            Console.WriteLine($"Dequeued Order: {oldestOrder}");
        }
        else
        {
            Console.WriteLine("Queue is empty.");
        }
    }

    // Клас для представлення книги
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author}";
        }
    }

    // Метод для додавання нової книги до словника
    static void AddBookToDictionary(Dictionary<int, Book> dictionary, int bookId, string title, string author)
    {
        Book newBook = new Book { Title = title, Author = author };
        dictionary.Add(bookId, newBook);
        Console.WriteLine($"Added Book to Dictionary: {newBook}");
    }

    // Метод для виведення інформації про книгу за її унікальним ідентифікатором
    static void PrintBookInfoById(Dictionary<int, Book> dictionary, int bookId)
    {
        if (dictionary.ContainsKey(bookId))
        {
            Console.WriteLine($"Book Info by ID {bookId}: " + dictionary[bookId]);
        }
        else
        {
            Console.WriteLine($"Book with ID {bookId} not found.");
        }
    }

    // Метод для видалення книги за її унікальним ідентифікатором
    static void RemoveBookById(Dictionary<int, Book> dictionary, int bookId)
    {
        if (dictionary.ContainsKey(bookId))
        {
            Book removedBook = dictionary[bookId];
            dictionary.Remove(bookId);
            Console.WriteLine($"Removed Book by ID {bookId}: {removedBook}");
        }
        else
        {
            Console.WriteLine($"Book with ID {bookId} not found.");
        }
    }
}
