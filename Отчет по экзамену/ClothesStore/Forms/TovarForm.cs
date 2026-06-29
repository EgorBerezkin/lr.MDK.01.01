using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothesStore.HelperModels;
using System.IO;
using ClothesStore.Models;

namespace ClothesStore.Forms
{
    public partial class TovarForm : Form
    {
        private DataStorage dataStorage_;
        private string connectionString_ = "Host=localhost;Database=ClothesStoreDB;Username=postgres";
        private bool columnsAdded = false;

        public TovarForm()
        {
            InitializeComponent();
            dataStorage_ = new DataStorage(connectionString_);
        }
        private void TovarForm_Load(object sender, EventArgs e)
        {
            if (!columnsAdded)
            {
                dataGridViewTovar.Columns.Clear();
                dataGridViewTovar.Columns.Add("id_clothing", "ID");
                dataGridViewTovar.Columns.Add("name", "Наименование");
                dataGridViewTovar.Columns.Add("category", "Категория");
                dataGridViewTovar.Columns.Add("counteragent", "Поставщик");
                dataGridViewTovar.Columns.Add("price", "Цена");
                dataGridViewTovar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewTovar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewTovar.MultiSelect = false;
                dataGridViewTovar.ReadOnly = true;
                columnsAdded = true;
            }
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dataStorage_.LoadClothing();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshGrid()
        {
            if (dataGridViewTovar.Columns.Count == 0) return;
            dataGridViewTovar.Rows.Clear();
            foreach (var p in dataStorage_.ClothingList)
            {
                dataGridViewTovar.Rows.Add(p.id_clothing_, p.name_, p.category_, p.counteragent_, p.price_);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTovarForm form = new AddTovarForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Clothing newProduct = form.ResultTovars;
                // Проверяем уникальность перед добавлением
                if (dataStorage_.IsDuplicateInList(newProduct))
                {
                    MessageBox.Show("Товар с таким наименованием и поставщиком уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataStorage_.AddClothing(newProduct);
                RefreshGrid();
                MessageBox.Show("Товар добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLoadCsv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    // Проверка расширения файла
                    if (!fileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Ожидается файл .csv", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string[] lines;
                    try
                    {
                        lines = File.ReadAllLines(fileName, Encoding.GetEncoding(1251));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Не удалось прочитать файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (lines.Length == 0)
                    {
                        string[] headers = lines[0].Split(';');
                        if (headers.Length != 4)
                        {
                            MessageBox.Show("Некорректная структура заголовков", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // Проверка разделителя
                    if (!lines[0].Contains(';'))
                    {
                        MessageBox.Show("Ожидается разделитель «;»", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int added = 0;
                    List<string> duplicateErrors = new List<string>();
                    Dictionary<string, int> uniqueCheck = new Dictionary<string, int>();
                    
                    for (int i = 1; i < lines.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(lines[i])) continue;
                        string[] parts = lines[i].Split(';');
                        if (parts.Length != 4)
                        {
                            MessageBox.Show($"Строка {i + 1}: неверное количество полей. Ожидается 4 поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                        try
                        {
                            string name = parts[0].Trim();
                            string category = parts[1].Trim();
                            string counteragent = parts[2].Trim();

                            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(counteragent))
                            {
                                MessageBox.Show($"Строка {i + 1}: заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                            if (!double.TryParse(parts[3].Trim(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double price))
                            {
                                MessageBox.Show($"Строка {i + 1}: цена должна быть числом", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }

                            string uniqueKey = name.ToLower().Trim() + "|" + counteragent.ToLower().Trim();
                            if (uniqueCheck.ContainsKey(uniqueKey))
                            {
                                duplicateErrors.Add($"Строка {uniqueCheck[uniqueKey] + 1} и строка {i + 1}");
                                continue;
                            }

                            if (dataStorage_.IsDuplicateInList( new Clothing(0, name, category, counteragent, price)))
                            {
                                duplicateErrors.Add($"Строка {i + 1} дублирует существующий товар");
                                continue;
                            }

                            uniqueCheck.Add(uniqueKey, i);
                            Clothing newProduct = new Clothing(0, name, category, counteragent, price);
                            dataStorage_.AddClothing(newProduct);
                            added++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка в строке {i + 1}: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (duplicateErrors.Count > 0)
                    {
                        string dupMessage = "Обнаружены дубликаты строк:\n";
                        foreach (var dup in duplicateErrors)
                        {
                            dupMessage += $"• {dup}\n";
                        }
                        dupMessage += "\nПожалуйста, удалите повторяющиеся строки и загрузите файл заново.";

                        DialogResult result = MessageBox.Show(dupMessage + "\n\nПоказать все дубликаты?", "Обнаружены дубликаты", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            ShowDuplicates(duplicateErrors);
                        }
                    }
                    RefreshGrid();
                    MessageBox.Show($"Загружено {added} товаров из CSV.", "Загрузка завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewTovar.SelectedRows[0].Cells["id_clothing"].Value;
            Clothing product = dataStorage_.FindClothingById(id);
            if (product == null)
            return;

            AddTovarForm form = new AddTovarForm(product);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (dataStorage_.ClothingList.Any(c => c.id_clothing_ != product.id_clothing_ && c.GetUniqueKey() == form.ResultTovars.GetUniqueKey()))
                {
                    MessageBox.Show("Товар с таким наименованием и поставщиком уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataStorage_.UpdateClothing(product);
                RefreshGrid();
                MessageBox.Show("Товар обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTovar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = (int)dataGridViewTovar.SelectedRows[0].Cells["id_clothing"].Value;
                dataStorage_.DeleteClothing(id);
                LoadData();
                MessageBox.Show("Товар удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataStorage_.SaveClothing();
                MessageBox.Show("Данные сохранены в базу данных", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowDuplicates(List<string> duplicates)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Найденные дубликаты:");
            sb.AppendLine();

            foreach (string item in duplicates)
            {
                sb.AppendLine(item);
            }
            MessageBox.Show(sb.ToString(), "Список дубликатов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
