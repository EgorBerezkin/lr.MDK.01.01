using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Categories_2._1
{
    public interface IDataService // Интерфейс для различных сервисов данных
    {
        string FetchData(string resourceID); // метод для получения данных по идентификатору ресурса
    }
}
