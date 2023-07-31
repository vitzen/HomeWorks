namespace homework19;

public static class InputParser
{
    public static int cancelationTokenStatus()
    {
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Для отмены  одной из Task's нажмите 1 \n" +
                              "Для отмены всех Task's нажмите 2 \n");
            Console.ForegroundColor = ConsoleColor.White;

            var tokenStatus = false;

            string inputSymbol = Console.ReadLine();
            bool input = Int32.TryParse(inputSymbol, out int outputElement);
            if (!input)
            {
                break;
            }
            else
            {
                switch (outputElement)
                {
                    case 1:
                        tokenStatus = token.IsCancellationRequested == true;
                        break;
                    case 2:
                        tokenStatus = token.IsCancellationRequested == true;
                        break;
                    default: break;
                }
            }
        } while (inputFromUser == false);
        return CancellationToken
    }
}