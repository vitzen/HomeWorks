// namespace homework19;
//
// public static class InputParser
// {
//     public static int cancelationTokenStatus()
//     {
//         do
//         {
//             Console.ForegroundColor = ConsoleColor.Yellow;
//             Console.WriteLine("Для отмены  одной из Task's нажмите 1 \n" +
//                               "Для отмены всех Task's нажмите 2 \n");
//             Console.ForegroundColor = ConsoleColor.White;
//
//             var tokenStatus = false;
//
//             string inputSymbol = Console.ReadLine();
//             bool input = Int32.TryParse(inputSymbol, out int outputElement);
//             if (!input)
//             {
//                 break;
//             }
//             else
//             {
//                 switch (outputElement)
//                 {
//                     case 1:
//                         tokenStatus = token.IsCancellationRequested == true;
//                         break;
//                     case 2:
//                         tokenStatus = token.IsCancellationRequested == true;
//                         break;
//                     default: break;
//                 }
//             }
//         } while (inputFromUser == false);
//         return CancellationToken
//     }
// }







// lock (_sync)
// {
//     //Создаем задержку для имитации долгой работы таски
//     Task.Delay(5000);
//     try
//     {
//         transportCard.Replenishment(replenishmentAmount);
//         Console.ForegroundColor = ConsoleColor.Green;
//         Console.WriteLine(">>>Таска отвечает за пополнение");
//         Console.ForegroundColor = ConsoleColor.White;
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine($"ОШИБКА {e.Message}");
//     }
// }
//                 
// lock (_sync)
// {
//     //Создаем задержку для имитации долгой работы таски
//     Task.Delay(5000);
//     try
//     {
//         transportCard.Payment(paymentAmount);
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.WriteLine($"<<<Таска отвечает за платеж");
//         Console.ForegroundColor = ConsoleColor.White;
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine($"ОШИБКА {e.Message}");
//     }
// }
