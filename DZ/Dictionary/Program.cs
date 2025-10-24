using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    enum Genre
    {
        Drama,
        Tragic,
        Comedy,
        Unknown
    }

    class Program
    {
        static public void RemoveBook(Dictionary<Genre, List<string>> allBooks,
                                       string bookName)
        {
            foreach (List<string> books in allBooks.Values)
            {
                for (int index = 0; index < books.Count; ++index)
                {
                    if (books[index] == bookName)
                    {
                        books.RemoveAt(index);
                        --index;
                    }
                }
            }
        }
        ///  Добавление книги
        /// Редактирование книг

        static void PrintBooksByGenre(Genre genre, Dictionary<Genre, List<string>> allBooks)
        {
            if (allBooks.ContainsKey(genre))
            {
                List<string> books = allBooks[genre];
                Console.WriteLine(String.Join("\n", books));
            }
            else
            {
                Console.WriteLine("Книг данного жанра мы еще не завезли");
            }
        }

        static private Genre MakeGenreByText(string text)
        {
            if (text == "драма")
            {
                return Genre.Drama;
            }

            if (text == "комедия")
            {
                return Genre.Comedy;
            }

            if (text == "трагедия")
            {
                return Genre.Tragic;
            }

            return Genre.Unknown;
        }

        /// Пользовательское добавление книг
        static void UserAddBook(Dictionary<Genre, List<string>> allBooks)
        {
            Console.Write("Введите жанр книги (драма/комедия/трагедия): ");
            string genreText = Console.ReadLine();
            Genre genre = MakeGenreByText(genreText);

            if (genre == Genre.Unknown)
            {
                Console.WriteLine("Ошибка: неизвестный жанр!");
                return;
            }

            Console.Write("Введите название книги: ");
            string bookName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(bookName))
            {
                Console.WriteLine("Ошибка: название книги не может быть пустым!");
                return;
            }
        }

        /// Пользовательское добавление книг
        static void UserEditBook(Dictionary<Genre, List<string>> allBooks)
        {
            Console.Write("Введите текущее название книги для редактирования: ");
            string oldBookName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(oldBookName))
            {
                Console.WriteLine("Ошибка: название книги не может быть пустым!");
                return;
            }

            Console.Write("Введите новое название книги: ");
            string newBookName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(newBookName))
            {
                Console.WriteLine("Ошибка: новое название книги не может быть пустым!");
                return;
            }
        }

        static void Main()
        {
            /// создали пустой словарь,
            /// где ключом выступает тип перечисления Genre,
            /// а значение список строковых значений (список названий книг)
            Dictionary<Genre, List<string>> catalogBooks =
                new Dictionary<Genre, List<string>>();

            /// заполнили книги жанра комедии
            catalogBooks.Add(Genre.Comedy,new List<string>() { "Горе от ума",
                                                  "Вечера на хуторе близ Диканьки",
                                                  "Ревизор",
                                                  "Ум от горя"});

            /// заполнили книги жанра трагедии
            catalogBooks.Add(Genre.Tragic,
                 new List<string>() { "Сегодня суббота",
                                      "Трагедия понедельника"});


            bool running = true;
            while (running)
            {
                Console.WriteLine("1. Просмотреть книги по жанру");
                Console.WriteLine("2. Добавить книгу");
                Console.WriteLine("3. Редактировать книгу");
                Console.WriteLine("4. Удалить книгу");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Какой жанр литературы Вам интересен? ");
                        string text = Console.ReadLine();
                        Genre genre = MakeGenreByText(text);
                        if (genre == Genre.Unknown)
                        {
                            Console.WriteLine("Ай я-яй, нужна либо драма, либо трагедия, либо комедия");
                            return;
                        }
                        else
                        {
                            PrintBooksByGenre(genre, catalogBooks);
                        }
                        break;
                    case "2":
                        UserAddBook(catalogBooks);
                        break;
                    case "3":
                        UserEditBook(catalogBooks);
                        break;
                    case "4":
                        Console.Write("Какую книгу хотите удалить? ");
                        string book = Console.ReadLine();
                        RemoveBook(catalogBooks, book);
                        Console.WriteLine("Книга удалена. Текущий каталог:");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор! Попробуйте снова.");
                        break;
                }
            }
               /// Д.З. Реализовать функции добавления книг и редактирования их названий
        }
    }
}
