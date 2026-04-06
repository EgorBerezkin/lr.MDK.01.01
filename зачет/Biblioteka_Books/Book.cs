using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Books
{
    // СОЗДАНИЕ КЛАССА
    public class Book
    {
        // Поля класса
        private string title_; // название книги
        private string author_; // автор
        private int year_; // год издания
        private bool isAvailable_; // хранение доступности

        public string Title
        { 
            get { return title_; } 
        }

        public string Author
        { 
            get { return author_; }
        }

        public int Year
        {
            get { return year_; } 
        }

        public bool IsAvailable
        {
            get { return isAvailable_; } 
        }

        // Конструтор класса
        public Book(string title, string author, int year, bool isAvailable)
        {
            title_ = title;
            author_ = author;
            year_ = year;
            isAvailable_ = isAvailable;
        }

        // Методы класса
        public void ShowInfo()
        {
            Console.WriteLine($" {title_} - {author_} ({year_}) - {(isAvailable_ ? "Доступна" : "Выдана")}");
        }
    }
}
