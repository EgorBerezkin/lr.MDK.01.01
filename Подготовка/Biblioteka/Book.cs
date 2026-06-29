using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Book // создание класса, описывает одну книгу
                      // класс - это шаблон объекта
    {
        public string Title { get; set; } // свойство и поле класса
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        // конструктор, вызывается автоматически при создании книги
        public Book(string title, string author, int year, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
        }
    }
}
