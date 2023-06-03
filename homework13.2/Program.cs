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

            listOfCards.RemoveAt(2);
            Console.WriteLine(string.Join(" ||| ", listOfCards));

            listOfCards.AddRange((listOfCards));
            Console.WriteLine(string.Join(" ||| ", listOfCards));

            var transportCardSearching = listOfCards.Find(X => X.CardName == "Trolleybus Card");
            Console.WriteLine(
                $"Параметры транспортной карты, которые соотвествуют требованиям поиска: {transportCardSearching}");

            var count = listOfCards.Count;
            Console.WriteLine($"Количество элементов list: {listOfCards.Count}");

            listOfCards.RemoveAll((x) => { return x == transportCard4 || x == transportCard2; });
            Console.WriteLine(string.Join(" ||| ", listOfCards));
            Console.WriteLine(new string('-', 60));

            //Queue
            Queue<TransportCard> transportCardQueue = new Queue<TransportCard>();
            transportCardQueue.Enqueue(transportCard2);
            transportCardQueue.Enqueue(transportCard3);
            transportCardQueue.Enqueue(transportCard4);

            //Извлекаем первый элемент из очереди
            var lastTransportCardInEqueu = transportCardQueue.Dequeue();
            Console.WriteLine($"Первый элемент в очереди: {lastTransportCardInEqueu}");

            //Голова череди
            var headOfQueue = transportCardQueue.Peek();
            Console.WriteLine($"Голова очереди: {headOfQueue}");
            Console.WriteLine("Оставшиеся элементы в очереди : " +
                              String.Join(" ||| ", transportCardQueue));

            transportCardQueue.Dequeue();
            transportCardQueue.Dequeue();
            Console.WriteLine("Оставшиеся элементы в очереди : " +
                              String.Join(" ||| ", transportCardQueue));

            TransportCard result;
            transportCardQueue.TryDequeue(out result);

            if (result == null)
            {
                Console.WriteLine("Очередь пуста");
            }
            else
            {
                Console.WriteLine("Оставшиеся элементы в очереди : " +
                                  String.Join(" ||| ", transportCardQueue));
            }

            Console.WriteLine(new string('-', 60));

            //Stack
            Stack<TransportCard> transportCardsInStack = new Stack<TransportCard>();

            for (int j = 0; j < arrayOfCards.Length; j++)
            {
                transportCardsInStack.Push(arrayOfCards[j]);
            }

            Console.WriteLine("Элементы в стеке : " +
                              String.Join(" ||| ", transportCardsInStack));

            transportCardsInStack.TryPop(out result);
            Console.WriteLine("Последний элемент в стеке : " +
                              String.Join(" ||| ", result));
            Console.WriteLine(new string('-', 60));

            //Dictionary
            Dictionary<string, decimal> transportCardDictionary = new Dictionary<string, decimal>();

            transportCardDictionary.Add(transportCard2.CardName, transportCard2.MoneyBalance);
            transportCardDictionary.Add(transportCard3.CardName, transportCard3.MoneyBalance);
            transportCardDictionary.Add(transportCard4.CardName, transportCard4.MoneyBalance);

            Console.WriteLine("Вывод на экран нашего словаря транспортных карт на момент создания");
            Console.WriteLine(String.Join(" ||| ", transportCardDictionary));

            var dictionaryElement = transportCardDictionary[transportCard3.CardName];
            Console.WriteLine($"Баланс транспортной карты Train Card: {dictionaryElement}");
        }
    }
}