// Переделать предыдущее домашнее задание по потокам на использование Task.

using System.Collections.Generic;
using System.Text;
using static homework18._1.TransportCard;
using System.Threading;
using System.Threading.Tasks;

namespace homework18._1
{
    public class Program
    {
        //Создаем объект синхронизации для работы потоков
        public static object _sync = new object();

        public static void Main()
        {
            decimal replenishmentAmount = 100M; //Сумма пополнения
            decimal paymentAmount = 30M; //Сумма оплаты проезда
            int tasksCount = 4;

            Console.WriteLine("Программа - ТРАНСПОРТНАЯ КАРТА\n".AddNewNotification());
            TransportCard transportCard = new TransportCard("Month bus ticket",
                0M,
                30M,
                0.1M,
                30M);

            //Подписки
            transportCard.ReplenishementEvent += SubscribtionClass.ReplenishmentSubscription;
            transportCard.PaymentEvent += SubscribtionClass.PaymentSubscription;


            var myTasks = new Task[tasksCount];

            for (int i = 0; i < tasksCount / 2; i++)
            {
                myTasks[i] = new Task(() =>
                {
                    lock (_sync)
                    {
                        transportCard.Payment(replenishmentAmount);
                        Console.WriteLine($"Таска отвечает за платеж");
                    }
                });
            }

            for (int i = tasksCount / 2; i < tasksCount; i++)
            {
                myTasks[i] = new Task(() =>
                {
                    
                    lock (_sync)
                    {
                        Console.WriteLine("Чтение платежа из истории");

                        var a = transportCard.historyOfTransactions
                            .Select(x => x.ToString());
                        Console.WriteLine(String.Join(",", a));
                        //Thread.Sleep(1000);
                    }
                });
            }

            for (int i = 0; i < tasksCount; i++)
            {
                myTasks[i].Start();
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