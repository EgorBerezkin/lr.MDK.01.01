using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Categories_2._1
{
    public class CachingProxyService : IDataService
    {
        private readonly RemoteApiService _realService;
        private readonly Dictionary<string, (string data, DateTime expiry)> _cache;
        private readonly int _cacheTTLMinutes;

        public CachingProxyService(int cacheTTLMinutes = 1)
        {
            // Создаем реальный сервис
            _realService = new RemoteApiService();

            // Создаем пустой кэш
            _cache = new Dictionary<string, (string, DateTime)>();

            // Сохраняем настройку времени жизни кэша
            _cacheTTLMinutes = cacheTTLMinutes;

            Console.WriteLine($"[CachingProxy] Создан кэш с TTL = {cacheTTLMinutes} мин");
        }

        public string FetchData(string resourceId)
        {
            Console.WriteLine($"\n[CachingProxy] Запрос данных для '{resourceId}'");

            // 1. ПРОВЕРЯЕМ, ЕСТЬ ЛИ ДАННЫЕ В КЭШЕ
            if (_cache.ContainsKey(resourceId))
            {
                Console.WriteLine($"[CachingProxy] Найдены данные в кэше");

                // Получаем данные и время истечения из кэша
                var cachedItem = _cache[resourceId];
                DateTime expiryTime = cachedItem.expiry;
                string cachedData = cachedItem.data;

                // 2. ПРОВЕРЯЕМ, НЕ УСТАРЕЛИ ЛИ ДАННЫЕ
                if (DateTime.Now < expiryTime)
                {
                    // Данные еще свежие
                    Console.WriteLine($"[CachingProxy] Данные свежие (действительны до {expiryTime:HH:mm:ss})");
                    Console.WriteLine($"[CachingProxy] Возвращаю данные из кэша");
                    return cachedData;
                }
                else
                {
                    // Данные устарели
                    Console.WriteLine($"[CachingProxy] Данные устарели (истекли в {expiryTime:HH:mm:ss})");
                    Console.WriteLine($"[CachingProxy] Удаляю устаревшие данные из кэша");

                    // Удаляем устаревшие данные из кэша
                    _cache.Remove(resourceId);
                }
            }
            else
            {
                Console.WriteLine($"[CachingProxy] Данных в кэше нет");
            }

            // 3. ЕСЛИ ДАННЫХ НЕТ ИЛИ ОНИ УСТАРЕЛИ - ОБРАЩАЕМСЯ К РЕАЛЬНОМУ СЕРВИСУ
            Console.WriteLine($"[CachingProxy] Обращаюсь к реальному API...");

            // Засекаем время начала запроса
            DateTime startTime = DateTime.Now;

            // Получаем данные из реального сервиса
            string freshData = _realService.FetchData(resourceId);

            // Вычисляем время выполнения
            TimeSpan elapsed = DateTime.Now - startTime;
            Console.WriteLine($"[CachingProxy] Запрос занял {elapsed.TotalSeconds:F1} сек");

            // 4. СОХРАНЯЕМ ДАННЫЕ В КЭШ
            DateTime newExpiry = DateTime.Now.AddMinutes(_cacheTTLMinutes);
            _cache[resourceId] = (freshData, newExpiry);

            Console.WriteLine($"[CachingProxy] Сохранил данные в кэш (действительны до {newExpiry:HH:mm:ss})");

            // Возвращаем свежие данные
            return freshData;
        }
    }
}
