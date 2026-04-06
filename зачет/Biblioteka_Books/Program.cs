using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Books
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов
            Book kniga = new Book("Год назад", "Робин Бенуэй", 2000, true);
            kniga.ShowInfo(); // Вызов метода
            Book kniga1 = new Book("Клин клином", "Онгель Таль", 2004, false);
            kniga1.ShowInfo(); // Вызов метода
            Book kniga2 = new Book("Если вс кошки в мире исчезнут", "Гэнки Кавамура", 2007, true);
            kniga2.ShowInfo(); // Вызов метода
            Console.WriteLine($"------------------------------------------------------------------");
            
            // Создание списков объекта
            List<Book> kniga3 = new List<Book>()
            {
                new Book("Коралина", "Нил Гейман", 2000, true),
                new Book("Блондинка в законе", "Алиса Стрип", 2003, false)
            };
            foreach (Book b in kniga3)
            {
                b.ShowInfo();
            }
            Console.WriteLine($"------------------------------------------------------------------");
            
            // Добавление книги в список
            kniga3.Add(new Book("Властелин колец", "Джон Толкин", 1954, true));
            kniga3[kniga3.Count - 1].ShowInfo();
            Console.WriteLine($"------------------------------------------------------------------");
            
            // Поиск книги по названию
            Book found = kniga3.Find(b => b.Title == "Коралина");
            if (found != null)
            {
                Console.WriteLine("Найдена книга:");
                found.ShowInfo();                                           
            }
            Console.WriteLine($"------------------------------------------------------------------");
            
            // Удаление книги
            Book toDelete = kniga3.Find(b => b.Title == "Блондинка в законе");
            if (toDelete != null)
            {
                kniga3.Remove(toDelete);
                Console.WriteLine("Список книг после удаления:");
                foreach (Book b in kniga3)
                {
                    b.ShowInfo();
                }
            }     
            ///////////////////////////////////////////////////////////
            Console.WriteLine($"------------------------------------------------------------------");
            Console.WriteLine("Словарь");
            Dictionary<int, Book> biblioteka2 = new Dictionary<int, Book>()
            {
                { 1, new Book("Коралина", "Нил Гейман", 2000, true) },
                { 2, new Book("Блондинка в законе", "Алиса Стрип", 2003, false) },
                { 3, new Book("Властелин колец", "Джон Толкин", 1954, true) }
            };
            foreach (var item in biblioteka2)
            {
                item.Value.ShowInfo();
            }

            Console.WriteLine($"------------------------------------------------------------------");
            int newId = biblioteka2.Count + 1;  // Считаем новый ID (3)
            biblioteka2.Add(newId, new Book("Властелин колец", "Джон Толкин", 1954, false));
            biblioteka2[newId].ShowInfo();  // Показываем по ключу (ID)

            Console.WriteLine($"------------------------------------------------------------------");
            Book book = biblioteka2.Values.FirstOrDefault(b => b.Title == "Коралина");
            if (found != null)
            {
                Console.WriteLine("Найдена книга:");
                found.ShowInfo();
            }
            ////////////////////////////////////////////////////
            
            // ФУНКЦИИ
        }
    }
}
