namespace homework19;

public class InputParser
{
    static int GetIntFromInput()
    {
        bool inputFromUser = false;
        int nElement = 0;

        do
        {
            Console.WriteLine("Введите целое число");
            string inputSymbol = Console.ReadLine();
            bool input = Int32.TryParse(inputSymbol, out int outputElement);
            if (input == false)
            {
                Console.WriteLine("Введенное вами число с клавиатуры неверно, попробуйте заново");
            }
            else
            {
                nElement = outputElement;
                inputFromUser = true;
                break;
            }
        } while (inputFromUser == false);

        return nElement;
    }
}