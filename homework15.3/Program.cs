// ЗАДАЧА:
// Создать проект консольной программы с решениями задач:
//     ● Исходная последовательность содержит сведения об абитуриентах. Каждый элемент
// последовательности включает следующие поля:
//     <Фамилия> <Год поступления> <Номер школы>
//     Для каждой школы вывести общее число абитуриентов за все годы и фамилию первого из абитуриентов
// этой школы, содержащихся в исходном наборе данных (вначале указывать номер школы, затем число
//     абитуриентов, затем фамилию). Сведения о каждой школе выводить на новой строке и упорядочивать
// по возрастанию номеров школ.

using System;
using System.Reflection.Emit;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace homework15._4
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Задача 3");

            List<Enrollee> enrolleeList = new List<Enrollee>();

            enrolleeList.Add(new Enrollee("Савельева Ульяна", 13, 2023));
            enrolleeList.Add(new Enrollee("Павлов Ярослав", 123, 2022));
            enrolleeList.Add(new Enrollee("Плотникова Ариана", 13, 2023));
            enrolleeList.Add(new Enrollee("Кузнецов Павел", 13, 2021));
            enrolleeList.Add(new Enrollee("Борисова Ева", 4, 2023));
            enrolleeList.Add(new Enrollee("Кожевникова Вера", 13, 2021));
            enrolleeList.Add(new Enrollee("Филатова Полина", 123, 2023));
            enrolleeList.Add(new Enrollee("Денисова Татьяна", 18, 2022));
            enrolleeList.Add(new Enrollee("Большаков Владислава", 23, 2022));
            enrolleeList.Add(new Enrollee("Тарасова Арина", 3, 2023));
            enrolleeList.Add(new Enrollee("Моисеев Михаил", 23, 2021));
            enrolleeList.Add(new Enrollee("Литвинов Алексей", 18, 2021));

            Console.WriteLine("* Исходная последовательность из учеников : \n" +
                              (String.Join("\n", enrolleeList)));
            Console.WriteLine(new string('-', 60));

            var subSequence = enrolleeList
                .GroupBy(x => x.SchoolNumber)
                .ToList();
            

            Console.WriteLine("* Последовательность из учеников : \n" +
                              (String.Join("\n", subSequence)));


            //Задержка
            Console.ReadKey();
        }
    }
}