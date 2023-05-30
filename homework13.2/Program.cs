//ЗАДАНИЕ - На примере транспортной карты изучить коллекции - массива, листа, стека, очереди.
//Добавление, извлечение, поиск(где возможен), и другие основные операции

using System.Collections.Generic;
using System.Text;
using static homework13._2.TransportCard;

namespace homework13._2
{
    public class Program
    {
        public static void Main()
        {
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

            //Создаем обьекты новых транспортных карт
            TransportCard transportCard2 = new TransportCard("Trolleybus Card", 0, 30, 0.1M, 30);
            TransportCard transportCard3 = new TransportCard("Train Card", 100, 30, 0.1M, 30);
            TransportCard transportCard4 = new TransportCard("Tram Card", 200, 30, 0.1M, 30);

            //Массивы
            var arrayOfCards = new TransportCard[] { transportCard2, transportCard3, transportCard4 };

            foreach (var cardItem in arrayOfCards)
            {
                Console.WriteLine($"Название карты: {cardItem.CardName}, Баланс карты: {cardItem.MoneyBalance}");
            }

            Console.WriteLine(new string('-', 60));

            //List
            List<TransportCard> listOfCards = new List<TransportCard>();
            listOfCards.Add(transportCard2);
            listOfCards.Add(transportCard3); 
            listOfCards.Insert(0, transportCard4);
            Console.WriteLine(string.Join(" ||| ", listOfCards));
            
            listOfCards.Reverse();
            Console.WriteLine(string.Join(" ||| ", listOfCards));
        }
    }
}