using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Categories_2._1
{
    public class RemoteApiService : IDataService
    {
        public string FetchData(string resourceID)
        {
            Console.WriteLine($"Запрашиваю данные для {resourceID}");
            Thread.Sleep(2000);
            string fakeData = $"Данные для {resourceID} от {DateTime.Now:HH.mm.ss}";
            Console.WriteLine("Данные получены");
            return fakeData ;
        }
    }
}
