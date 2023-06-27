// ЗАДАНИЕ - Написать потокобезопасный прием платежей и вывод транзакций по транспортной карте.
// public List<decimal> History { get; set; } - список со всеми транзакциями.
// Нужно обеспечить безопасное добавление платежей в 2 потока и считывание истории платежей в 2 потока.

using System.Collections.Generic;
using System.Text;
using static homework18._1.TransportCard;
using System.Threading;

namespace homework18._1
{
    public class Program
    {
        public static void Main()
        {
            decimal replenishmentAmount = 100M; //Сумма пополнения
            decimal paymentAmount = 30M; //Сумма оплаты проезда
            int threadsCount = 4;

            Console.WriteLine("Программа - ТРАНСПОРТНАЯ КАРТА\n".AddNewNotification());
            TransportCard transportCard = new TransportCard("Month bus ticket",
                0M,
                30M,
                0.1M,
                30M);

            //Подписки
            transportCard.ReplenishementEvent += SubscribtionClass.ReplenishmentSubscription;
            transportCard.PaymentEvent += SubscribtionClass.PaymentSubscription;

            //Создаем объект синхронизации для работы потоков
            object _sync = new object();

            Thread[] myThreads = new Thread[threadsCount];

            for (int i = 0; i < threadsCount / 2; i++)
            {
                myThreads[i] = new Thread(() =>
                {
                    lock (_sync)
                    {
                        transportCard.Payment(replenishmentAmount);
                        Console.WriteLine($"Поток {myThreads[i].CurrentCulture} отвечает за платеж");
                    }
                });
            }

            for (int i = threadsCount / 2; i < threadsCount; i++)
            {
                myThreads[i] = new Thread(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Чтение платежа из истории");
                    
                    lock (_sync)
                    {
                        var a = transportCard.historyOfTransactions
                            .Select(x => x.ToString());
                        Console.WriteLine(String.Join(",", a));
                    }
                });
            }

            for (int i = 0; i < threadsCount; i++)
            {
                myThreads[i].Start();
            }

            transportCard.Replenishment(replenishmentAmount);
            transportCard.Payment(paymentAmount);
            transportCard.Payment(paymentAmount);
            transportCard.Payment(paymentAmount);
            transportCard.Payment(paymentAmount);
            transportCard.Payment(paymentAmount);
            transportCard.Payment(paymentAmount);

            transportCard.Replenishment(replenishmentAmount);
            transportCard.Payment(paymentAmount);
            transportCard.Payment(paymentAmount);

            transportCard.Replenishment(replenishmentAmount);
            transportCard.Replenishment(replenishmentAmount);
            transportCard.Replenishment(replenishmentAmount);
            transportCard.Replenishment(replenishmentAmount);
            transportCard.Replenishment(replenishmentAmount);

            transportCard.ReplenishementEvent -= SubscribtionClass.ReplenishmentSubscription;
            transportCard.PaymentEvent -= SubscribtionClass.PaymentSubscription;

            Console.WriteLine(new string('-', 60));
        }
    }
}