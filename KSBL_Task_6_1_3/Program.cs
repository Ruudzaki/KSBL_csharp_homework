using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_6_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Call of Chtulhu",
                                    "H.P. Lovecraft",
                                    "Once, I found my uncle's diary...");

            book1.Show();

            Console.ReadKey();
        }
    }

    class Book
    {
        public Title Title { get; set; }

        public Author Author { get; set; }

        public Content Content { get; set; }

        public Book(string title, string author, string content)
        {
            Title = new Title();
            Author = new Author();
            Content = new Content();

            Title.title = title;
            Author.author = author;
            Content.content = content;
        }

        public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class Title
    {
        public string title;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(title);
        }
    }

    class Author
    {
        public string author;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author);
        }
    }

    class Content
    {
        public string content;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(content);
        }
    }
}
