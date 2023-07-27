﻿//Добавить для каждой карты логику максимального и минимального баланса (указывается в конструкторе).
//При выходе за границы выбрасывать исключение(написать свои 2 иключения).
//Обработать эти исключения в тасках, которые занимаются пополнением и списанием денег
//Научиться пользоваться отменой тасок.
//Добавить логику ввода с консоли специального слова,
//которое отменяет таски на запись транзакций/чтения транзакций в отдельности для каждой таски и в целом для всех

using System.Collections.Generic;
using System.Text;
using static homework19.TransportCard;
using System.Threading;
using System.Threading.Tasks;

namespace homework19
{
    public class Program
    {
        //Создаем объект синхронизации и Cancelation Token для работы потоков
        private static object _sync = new object();
        private static CancellationTokenSource _cancellationTokenSource;

        public static void Main()
        {
            decimal replenishmentAmount = 100M; //Сумма пополнения
            decimal paymentAmount = 30M; //Сумма оплаты проезда
            int tasksCount = 2;
            bool inputFromUser = false;

            Console.WriteLine("Программа - ТРАНСПОРТНАЯ КАРТА\n".AddNewNotification());
            TransportCard transportCard = new TransportCard("Month bus ticket",
                0M,
                30M,
                30M,
                1000M,
                0.1M,
                30M
            );

            _cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = _cancellationTokenSource.Token;

            //Подписки
            transportCard.ReplenishementEvent += SubscribtionClass.ReplenishmentSubscription;
            transportCard.PaymentEvent += SubscribtionClass.PaymentSubscription;

            //Создаем массив Тасок, оборачиваем таски в LOCK, обрабатываем исключения,
            //и передаем Cancelation Token в каждую таску
            var myTasks = new Task[tasksCount];

            for (int i = 0; i < tasksCount; i++)
            {
                myTasks[i] = new Task(() =>
                {
                    do
                    {
                        lock (_sync)
                        {
                            Task.Delay(5000);
                            try
                            {
                                transportCard.Replenishment(replenishmentAmount);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(">>>Таска отвечает за пополнение");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"ОШИБКА {e.Message}");
                            }
                        }

                        lock (_sync)
                        {
                            Task.Delay(5000);
                            try
                            {
                                transportCard.Payment(paymentAmount);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"<<<Таска отвечает за платеж");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"ОШИБКА {e.Message}");
                            }
                        }
                    } while (token.IsCancellationRequested);
                });
            }

            for (int i = 0; i < tasksCount; i++)
            {
                myTasks[i].Start();
            }

            Task.WaitAll(myTasks);

            transportCard.ReplenishementEvent -= SubscribtionClass.ReplenishmentSubscription;
            transportCard.PaymentEvent -= SubscribtionClass.PaymentSubscription;

            Console.WriteLine(new string('-', 60));
        }
    }
}