// Домашнее задание
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.
using System;

        namespace homework5._1
        {
            class Program
            {
                
                /// <summary>
                /// Метод, осуществляющий парсинг вводимых пользователем значений с консоли
                /// </summary>
                public static void ParsingMethod(string inputFromUser, string[] userNumbers)
                {
                    string unknownInput = inputFromUser;
                    string[] unknownNumbers = new string[unknownInput];
                        
                        
                        
                    bool input = Int32.TryParse(unknownInput, out int arrayCountNumber);
                    if (input)
                    {
                        for (int i = 0; i < userNumbers.Length; i++)
                        {
                            
                        }
                        
                        
                        
                        //CalculateMethod(arrayCountNumber);
                    }
                    
                    
                    
                    
                }
        
                /// <summary>
                /// Метод логики 
                /// </summary>
                public static void CalculateMethod(int arrayElementsCount)
                {
                    int[] myArray = new int[arrayElementsCount];
                }
        
                /// <summary>
                /// Метод вывода на консоль
                /// </summary>
                public static void PrintMethod()
                {
            
                }  
                
                
                static void Main()
                {
                    
                    Console.WriteLine("Программа для подсчета суммы элементов одномерного массива \n" +
                                      "Введите размерность (количество элементов) массива");
                    
                    string inputFromConsole = Console.ReadLine();
                     
                    ParsingMethod(inputFromConsole);
                    
                    
                    bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayElementsCount);

                    if (consoleInput)
                    {
                        int[] myArray = new int[arrayElementsCount];
                        for (int i = 0; i < myArray.Length; i++)
                        {
                            Console.WriteLine("Введите число");
                            string number = Console.ReadLine();
                            bool numberInput = Int32.TryParse(number, out int num);
                            if (numberInput)
                            {
                                myArray[i] = num;
                            }
                            else
                            {
                                Console.WriteLine("Некорректно введенное число, Запускаем программу заново");
                            }
                        }

                        // Полученный после ввода массив данных
                        Console.WriteLine($"Элементы вашего массива: {string.Join(" ", myArray)}");
                        int sumOfArrayElements = myArray.Sum();
                        Console.WriteLine($"Сумма всех элементов в массиве равна = {sumOfArrayElements} ");
                    }

                    else
                    {
                        Console.WriteLine("Введите корректное число элементов в вашем массиве");
                    }


                    // Delay
                    Console.ReadKey();
                }
            }
        }