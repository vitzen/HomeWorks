// ЗАДАЧА:
//     ● Создать класс транспортная карта
//     ○ определить в нем делегат с аргументом строчного типа (string), которое будет уведомлять об
// операции
//     ○ реализовать методы Пополнение (при вызове метода передаем какой суммой пополняем карту) и
//     Оплата (снимаем из баланса карты 30 руб)
//     ○ реализовать вызов и оповещение текстом о случившимся событии пополнения и оплаты
//     ○ в строке события писать текущий баланс карты
//     ● Создать экземпляр класса транспортная карта
//     ○ подписаться на событие уведомления о операциях по транспортной карте
//     ○ вызвать методы пополнения карты и оплаты по карте
//     ○ при срабатывании - писать текст события в консоль
//  
// Добавить предикат на возможность списания денег, функцию на расчет кешбека, сохранение истории всех платежей и ее просмотр

using System.Text;
using static homework11.TransportCard;

namespace homework11
{
    public class Program
    {
        public static void Main()
        {
            decimal replenishmentAmount = 100M; //Сумма пополнения
            decimal paymentAmount = 30M; //Сумма оплаты проезда
            //decimal _calculateCashback = 0.1M; //Коэффициент для расчет кэшбека при пополнении карты
            
            Console.WriteLine("Программа - ТРАНСПОРТНАЯ КАРТА\n");
            TransportCard transportCard = new TransportCard("Month bus ticket", 0M, 30M, 0.1M);


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

            transportCard.ReplenishementEvent -= SubscribtionClass.ReplenishmentSubscription;
            transportCard.PaymentEvent -= SubscribtionClass.PaymentSubscription;


            //добавить запись все операций в .txt файл
        }
    }
}