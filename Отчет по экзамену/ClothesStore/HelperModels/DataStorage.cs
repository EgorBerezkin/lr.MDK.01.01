using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothesStore.Models;
using Npgsql;

namespace ClothesStore.HelperModels
{
    public class DataStorage
    {
        private string connectionString_;
        public List<Clothing> clothingList_;
        public List<Pokupatel> pokupatelList_;
        public List<Receipt> receiptsList_;

        public List<Clothing> ClothingList => clothingList_;
        public List<Receipt> ReceiptsList => receiptsList_;

        public DataStorage(string connectionString)
        {
            connectionString_ = connectionString;
            clothingList_ = new List<Clothing>();
            pokupatelList_ = new List<Pokupatel>();
            receiptsList_ = new List<Receipt>();
        }

        // методы класса
        //1.	загрузить товары из файла – loadClothing();
        public void LoadClothing()
        {
            clothingList_.Clear();
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = "SELECT id_clothing, name, category, counteragent, price FROM Clothes ORDER BY id_clothing";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Clothing c = new Clothing(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), (double)reader.GetDecimal(4));
                        clothingList_.Add(c);
                    }
                }
            }
        }
        //2.	сохранить товары в файл – saveClothing();
        public void SaveClothing()
        {
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                foreach (var c in clothingList_)
                {
                    string query = @"INSERT INTO Clothes (id_clothing, name, category, counteragent, price) 
                                    VALUES (@id, @name, @category, @counteragent, @price)
                                    ON CONFLICT (id_clothing) DO UPDATE SET 
                                    name = EXCLUDED.name,
                                    category = EXCLUDED.category,
                                    counteragent = EXCLUDED.counteragent,
                                    price = EXCLUDED.price";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", c.id_clothing_);
                        cmd.Parameters.AddWithValue("@name", c.name_);
                        cmd.Parameters.AddWithValue("@category", c.category_);
                        cmd.Parameters.AddWithValue("@counteragent", c.counteragent_);
                        cmd.Parameters.AddWithValue("@price", c.price_);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        //3.	найти товар по ID – findClothingById();
        public Clothing FindClothingById(int id)
        {
            return clothingList_.FirstOrDefault(c => c.id_clothing_ == id);
        }
        // Проверка на дубликат в существующем списке
        public bool IsDuplicateInList(Clothing clothing)
        {
            return clothingList_.Any(c => c.id_clothing_ != clothing.id_clothing_ && c.GetUniqueKey() == clothing.GetUniqueKey());
        }
        public void AddClothing(Clothing clothing)
        {
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = @"INSERT INTO Clothes (name, category, counteragent, price) VALUES (@name, @category, @counteragent, @price) RETURNING id_clothing";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", clothing.name_);
                    cmd.Parameters.AddWithValue("@category", clothing.category_);
                    cmd.Parameters.AddWithValue("@counteragent", clothing.counteragent_);
                    cmd.Parameters.AddWithValue("@price", clothing.price_);
                    int newId = Convert.ToInt32(cmd.ExecuteScalar());
                    clothing.id_clothing_ = newId;
                    clothingList_.Add(clothing);
                }
            }
        }
        // Обновить товар в БД
        public void UpdateClothing(Clothing clothing)
        {
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = @"UPDATE Clothes SET name = @name, category = @category, counteragent = @counteragent, price = @price  WHERE id_clothing = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", clothing.id_clothing_);
                    cmd.Parameters.AddWithValue("@name", clothing.name_);
                    cmd.Parameters.AddWithValue("@category", clothing.category_);
                    cmd.Parameters.AddWithValue("@counteragent", clothing.counteragent_);
                    cmd.Parameters.AddWithValue("@price", clothing.price_);
                    cmd.ExecuteNonQuery();
                }
            }

            var existing = clothingList_.FirstOrDefault(c => c.id_clothing_ == clothing.id_clothing_);
            if (existing != null)
            {
                existing.name_ = clothing.name_;
                existing.category_ = clothing.category_;
                existing.counteragent_ = clothing.counteragent_;
                existing.price_ = clothing.price_;
            }
        }
        // Удалить товар из БД
        public void DeleteClothing(int id)
        {
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = "DELETE FROM Clothes WHERE id_clothing = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            var existing = clothingList_.FirstOrDefault(c => c.id_clothing_ == id);
            if (existing != null)
            {
                clothingList_.Remove(existing);
            }
        }
        
        // Для формы покупатели
        //4.	найти покупателя по телефону – findCustomerByPhone().
        public Pokupatel FindCustomerByPhone(string phone)
        {
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = "SELECT id_client,phone,total_sum,total_checks_count,last_visit_date FROM Customers WHERE phone = @phone";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Pokupatel(reader.GetInt32(0), reader.GetString(1), (double)reader.GetDecimal(2), reader.GetInt32(3), reader.GetDateTime(4));
                        }
                    }
                }
            }
            return null;
        }
        // Загрузка покупателей
        public void LoadCustomers()
        {
            pokupatelList_.Clear();
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query =@"SELECT id_client,phone,total_sum,total_checks_count,last_visit_date FROM Customers ORDER BY id_client";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pokupatel customer = new Pokupatel(reader.GetInt32(0), reader.GetString(1), (double)reader.GetDecimal(2), reader.GetInt32(3), reader.GetDateTime(4));
                        pokupatelList_.Add(customer);
                    }
                }
            }
        }
        // Добавление покупателя
        public void AddCustomer(Pokupatel customer)
        {
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = @"INSERT INTO Customers(phone,total_sum,total_checks_count,last_visit_date) VALUES(@phone,@sum,@count,@date) RETURNING id_client";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", customer.phone_);
                    cmd.Parameters.AddWithValue("@sum", customer.totalSum_);
                    cmd.Parameters.AddWithValue("@count", customer.totalChecksCount_);
                    cmd.Parameters.AddWithValue("@date", customer.lastVisitDate_);
                    int newId = Convert.ToInt32(cmd.ExecuteScalar());
                    customer.id_client_ = newId;
                }
            }
            pokupatelList_.Add(customer);
        }
        // Обновление покупателя
        public void UpdateCustomer(Pokupatel customer)
        {
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = @"UPDATE Customers SET phone = @phone, total_sum = @sum, total_checks_count = @count, last_visit_date = @date WHERE id_client = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", customer.id_client_);
                    cmd.Parameters.AddWithValue("@phone", customer.phone_);
                    cmd.Parameters.AddWithValue("@sum", customer.totalSum_);
                    cmd.Parameters.AddWithValue("@count", customer.totalChecksCount_);
                    cmd.Parameters.AddWithValue("@date", customer.lastVisitDate_);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Удаление покупателя
        public void DeleteCustomer(int id)
        {
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = @"DELETE FROM Customers WHERE id_client = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            var customer = pokupatelList_.FirstOrDefault(p => p.id_client_ == id);
            if (customer != null)
            {
                pokupatelList_.Remove(customer);
            }
        }
        // Проверка телефона на уникальность
        public bool IsPhoneExists(string phone)
        {
            return pokupatelList_.Any(p => p.phone_ == phone);
        }
        public Pokupatel FindCustomerById(int id)
        {
            return pokupatelList_.FirstOrDefault(p => p.id_client_ == id);
        }
        // Чеки
        // Метод загрузки чеков
        public void LoadReceipts()
        {
            receiptsList_.Clear();
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = @"SELECT id_check, sale_date, id_client, total_amount, payment_method, id_user FROM Receipts ORDER BY id_check";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Receipt receipt = new Receipt(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), new List<Clothing>(), new List<int>(), (double)reader.GetDecimal(3), reader.GetString(4), reader.IsDBNull(5) ? 0 : reader.GetInt32(5));
                        receiptsList_.Add(receipt);
                    }
                }
            }
        }
        // Метод сохранения чека
        public void SaveReceipt(Receipt receipt)
        {
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = @"INSERT INTO Receipts(sale_date,id_client,total_amount,payment_method,id_user) VALUES(@sale_date,@id_client,@total_amount,@payment_method,@id_user) RETURNING id_check";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sale_date", receipt.sale_date_);
                    cmd.Parameters.AddWithValue("@id_client", receipt.id_client_);
                    cmd.Parameters.AddWithValue("@total_amount", receipt.total_amount_);
                    cmd.Parameters.AddWithValue("@payment_method", receipt.payment_method_);
                    cmd.Parameters.AddWithValue("@id_user", receipt.id_user_);
                    receipt.id_check_ = Convert.ToInt32(cmd.ExecuteScalar());
                }
                SaveReceiptItems(receipt, conn);
            }
            receiptsList_.Add(receipt);
        }
        // Поиск товара по названию
        public Clothing FindClothingByName(string name)
        {
            return clothingList_.FirstOrDefault(c => c.name_.ToLower() == name.ToLower());
        }
        // Номер чека
        public int GetNextReceiptId()
        {
            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = "SELECT COALESCE(MAX(id_check), 0) + 1 FROM Receipts";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        private void SaveReceiptItems(Receipt receipt, NpgsqlConnection conn)
        {
            for (int i = 0; i < receipt.items_.Count; i++)
            {
                string query = @"INSERT INTO ReceiptItems(id_check,id_clothing,quantity) VALUES(@id_check,@id_clothing,@quantity)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_check", receipt.id_check_);
                    cmd.Parameters.AddWithValue("@id_clothing", receipt.items_[i].id_clothing_);
                    cmd.Parameters.AddWithValue("@quantity", receipt.quantities_[i]);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public Receipt GetLastReceiptByClientId(int clientId)
        {
            LoadReceipts();
            Receipt lastReceipt = receiptsList_
                .Where(r => r.id_client_ == clientId)
                .OrderByDescending(r => r.sale_date_)
                .FirstOrDefault();

            if (lastReceipt != null)
            {
                LoadReceiptItems(lastReceipt);
            }
            return lastReceipt;
        }
        public void LoadReceiptItems(Receipt receipt)
        {
            receipt.items_.Clear();
            receipt.quantities_.Clear();

            using (var conn = new NpgsqlConnection(connectionString_))
            {
                conn.Open();
                string query = @"SELECT c.id_clothing,c.name,c.category,c.counteragent,c.price,ri.quantity
                                FROM ReceiptItems ri
                                JOIN Clothes c
                                ON c.id_clothing = ri.id_clothing
                                WHERE ri.id_check = @id_check";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_check", receipt.id_check_);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Clothing clothing = new Clothing(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), (double)reader.GetDecimal(4));
                            receipt.items_.Add(clothing);
                            receipt.quantities_.Add(reader.GetInt32(5));
                        }
                    }
                }
            }
        }
    }
}
