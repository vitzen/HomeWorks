// ЗАДАНИЕ - Написать потокобезопасный прием платежей и вывод транзакций по транспортной карте.
// public List<decimal> History { get; set; } - список со всеми транзакциями.
// Нужно обеспечить безопасное добавление платежей в 2 потока и считывание истории платежей в 2 потока.

using System.Collections.Generic;
using System.Text;
using static homework17.TransportCard;
using System.Threading;

namespace homework17
{
    public class Program
    {
        //Создаем объект синхронизации
        public static object _sync = new object();

        public static void Main()
        {
            var thread1 = new Thread(_addPaymentIntoHystory);
            var thread2 = new Thread();
            var thread3 = new Thread();
            var thread4 = new Thread();
            
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            
            decimal replenishmentAmount = 100M; //Сумма пополнения
            decimal paymentAmount = 30M; //Сумма оплаты проезда

            Console.WriteLine("Программа - ТРАНСПОРТНАЯ КАРТА\n".AddNewNotification());
            TransportCard transportCard = new TransportCard("Month bus ticket",
                0M,
                30M,
                0.1M, 30M);

            //Подписки
            transportCard.ReplenishementEvent += SubscribtionClass.ReplenishmentSubscription;
            transportCard.PaymentEvent += SubscribtionClass.PaymentSubscription;

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

            Console.WriteLine(String.Join(",", transportCard.HistoryOfTransactions));
            Console.WriteLine(new string('-', 60));
        }
    }
}