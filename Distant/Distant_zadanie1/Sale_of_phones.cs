using System;

namespace Remote_assignment_1
{
    public struct Sale_of_phones
    {
        public DateTime Date;     // Дата продажи (метка времени)
        public string PhoneModel; // Модель телефона
        public int Quantity;      // Количество проданных единиц
        public double Price;      // Цена за единицу для клиента
         
        // Вычисление дохода магазина
        public double Revenue => Price * Quantity;
    }
}
