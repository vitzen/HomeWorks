// ТЕКСТ ЗАДАНИЯ
// Написать консольную программу, которая не блокируя основной поток опрашивает сайты
// "http://yandex.ru",
// "http://google.ru",
// "http://vk.com",
// "http://msdn.com",
// c помощью WebClient.DownloadStringTaskAsync и возвращает на экран самый быстропришедший ответ.
// Остальные запросы нужно отменять через CancelationToken. Используя Task и async/await

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace homework20
{
    class Program
    {
        private static CancellationTokenSource _cancellationTokenSource;

        static void Main(string[] args)
        {
            //Создаем объект Cancelation Token
            _cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = _cancellationTokenSource.Token;

            string[] _url = new string[]
            {
                "http://yandex.ru",
                "http://google.ru",
                "http://vk.com",
                "http://msdn.com"
            };

            
            async Task<string> LoadAllDataByTasks()
            {
                StringBuilder sb = new StringBuilder();
                var time = Stopwatch.StartNew();

                foreach (var url in _url)
                {
                    if (_cancellationTokenSource.IsCancellationRequested)
                    {
                        sb.AppendLine("Была запрошена отмена операции.");
                        break;
                    }

                    var result = await LoadDataAsync(url);
                    sb.AppendLine($"{url}: {result}");
                }

                time.Stop();

                sb.AppendLine($"TOTAL time: {time.ElapsedMilliseconds} ms");
                return sb.ToString();
            }


            async Task<string> LoadDataAsync(string url)
            {
                var time = Stopwatch.StartNew();
                var webClient = new WebClient();
                try
                {
                    var result = await webClient.DownloadStringTaskAsync(url);
                    time.Stop();
                    return $"SIZE:{result.Length}. TIME:{time.ElapsedMilliseconds} ms";
                }
                catch (WebException e)
                {
                    return $"Error load {url}. {e.Message}";
                }
            }

            var a = LoadAllDataByTasks().ToString();
            // Console.WriteLine(String.Join(",", a));
            // Console.ReadKey();

            //Отмена всех тасок
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource.Dispose();
        }
    }
}