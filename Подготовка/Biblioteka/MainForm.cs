using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class MainForm : Form
    {
        // создание списка, он типо как полка кник, когда класс это одна книга
        private List<Book> books = new List<Book>();
        public MainForm()
        {
            InitializeComponent();
            //  создание в таблице 4 столбца, и их названия
            dataGridViewKnigi.ColumnCount = 4;
            dataGridViewKnigi.Columns[0].Name = "Название";
            dataGridViewKnigi.Columns[1].Name = "Автор";
            dataGridViewKnigi.Columns[2].Name = "Год";
            dataGridViewKnigi.Columns[3].Name = "Жанр";

        }

        private void buttonDobav_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                    string.IsNullOrWhiteSpace(textBoxYear.Text) ||
                    string.IsNullOrWhiteSpace(textBoxGenre.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // получение данных в TextBox
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            int year;

            if (!int.TryParse(textBoxYear.Text, out year))
            {
                MessageBox.Show("Год должен быть числом!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            string genre = textBoxGenre.Text;

            // Проверка на дубликаты
            foreach (Book b in books)
            {
                if (b.Title.ToLower() == textBoxTitle.Text.ToLower() &&
                    b.Author.ToLower() == textBoxAuthor.Text.ToLower())
                {
                    MessageBox.Show("Такая книга уже существует!");
                    return;
                }
            }

            // создание книги
            Book book = new Book(title, author, year, genre);
            // добавление книги в список
            books.Add(book);

            // показывает книгу в таблице, добавление строки
            dataGridViewKnigi.Rows.Add(book.Title, book.Author, book.Year, book.Genre);

            // очистка полей
            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxYear.Clear();
            textBoxGenre.Clear();

            textBoxTitle.Focus();
        }

        private void buttonNaiti_Click(object sender, EventArgs e)
        {
            // получение текста
            string searchTitle = textBoxTitle.Text;

            // создание переменной
            bool found = false;

            // снимаем выделение со всех строк
            dataGridViewKnigi.ClearSelection();

            // цикл (потому что нужен номер строки)
            for (int i = 0; i < books.Count; i++)
            {
                // сравнение названия (ToLower - программа читает надписи разные по правописанию одинаково)
                if (books[i].Title.ToLower() == searchTitle.ToLower())
                {
                    // выделение строки
                    dataGridViewKnigi.Rows[i].Selected = true;

                    // прокручивание таблицы
                    dataGridViewKnigi.FirstDisplayedScrollingRowIndex = i;

                    // запоминаем
                    found = true;
                    // остановка
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Книга не найдена.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // проверка, выбрана ли строка
            if (dataGridViewKnigi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите книгу для удаления!");
                return;
            }

            // получение номера строки
            int index = dataGridViewKnigi.SelectedRows[0].Index;
            // спрашиваем подтверждение
            DialogResult result = MessageBox.Show(
                "Удалить выбранную книгу?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            // если да
            if (result == DialogResult.Yes)
            {
                books.RemoveAt(index);
                dataGridViewKnigi.Rows.RemoveAt(index);
            }
        }

        private void buttonSortirovat_Click(object sender, EventArgs e)
        {
            // цикл, количество подходов
            for (int i = 0; i < books.Count - 1; i++)
            {
                // сравнение соседних книг
                for (int j = 0; j < books.Count - i - 1; j++)
                {
                    // сравнение строк по алфавиту
                    if (string.Compare(books[j].Title, books[j + 1].Title) > 0)
                    {
                        Book temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }
            // обновление таблицы
            dataGridViewKnigi.Rows.Clear();
            // заново заполняется
            foreach (Book book in books)
            {
                dataGridViewKnigi.Rows.Add(book.Title, book.Author, book.Year, book.Genre);
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Очистить всю библиотеку?",
        "Подтверждение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // удаляет все объекты списка
                books.Clear();
                dataGridViewKnigi.Rows.Clear();

                textBoxTitle.Clear();
                textBoxAuthor.Clear();
                textBoxYear.Clear();
                textBoxGenre.Clear();
            }
        }
    }
}
