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

            string[] urlsToDownloads = new string[]
            {
                "http://yandex.ru",
                "http://google.ru",
                "http://vk.com",
                "http://msdn.com"
            };

            string LoadAllDataByTasks(string[] urls)
            {
                StringBuilder sb = new StringBuilder();
                var time = Stopwatch.StartNew();

                List<Task<string>> listOfTasks = new List<Task<string>>();

                foreach (var url in urls)
                {
                    if (_cancellationTokenSource.IsCancellationRequested)
                    {
                        sb.AppendLine("Была запрошена отмена операции.");
                        break;
                    }

                    using var resultTask = LoadDataAsync(url, token);

                    listOfTasks.Add(resultTask);
                    resultTask.Start();

                    sb.AppendLine($"{url}:");
                }

                var indexOfTask = Task.WaitAny(listOfTasks.ToArray());
                _cancellationTokenSource.Cancel();

                time.Stop();


                var result = listOfTasks[indexOfTask].Result;
                sb.AppendLine(($"{result}"));

                sb.AppendLine($"TOTAL time: {time.ElapsedMilliseconds} ms");
                return sb.ToString();
            }

            async Task<string> LoadDataAsync(string url, CancellationToken token)
            {
                var time = Stopwatch.StartNew();
                var webClient = new WebClient();
                try
                {
                    token.Register(webClient.CancelAsync);
                    var result = await webClient.DownloadStringTaskAsync(url);

                    time.Stop();
                    return $"SIZE:{result.Length}. TIME:{time.ElapsedMilliseconds} ms {url}";
                }
                catch (WebException e)
                {
                    return $"Error load {url}. {e.Message}";
                }
            }

            LoadAllDataByTasks(urlsToDownloads);
        }
    }
}