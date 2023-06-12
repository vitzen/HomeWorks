// ЗАДАЧА:
// Создать проект консольной программы с решениями задач:
// ● Исходная последовательность содержит сведения об абитуриентах. Каждый элемент
// последовательности включает следующие поля:
// <Фамилия> <Год поступления> <Номер школы>
//
// Для каждой школы вывести общее число абитуриентов за все годы и фамилию первого из абитуриентов
// этой школы, содержащихся в исходном наборе данных (вначале указывать номер школы, затем число
// абитуриентов, затем фамилию). Сведения о каждой школе выводить на новой строке и упорядочивать
// по возрастанию номеров школ.

using System;
using System.Reflection.Emit;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Schema;

namespace homework15._3
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Задача 3");

            List<Enrollee> enrolleeList = new List<Enrollee>()
            {
                new Enrollee("Савельева Ульяна", 13, 2023),
                new Enrollee("Павлов Ярослав", 123, 2022),
                new Enrollee("Плотникова Ариана", 13, 2023),
                new Enrollee("Кузнецов Павел", 13, 2021),
                new Enrollee("Кузнецов Павел", 13, 2021),
                new Enrollee("Борисова Ева", 4, 2023),
                new Enrollee("Кожевникова Вера", 13, 2021),
                new Enrollee("Филатова Полина", 123, 2023),
                new Enrollee("Денисова Татьяна", 18, 2022),
                new Enrollee("Большаков Владислава", 23, 2022),
                new Enrollee("Тарасова Арина", 3, 2023),
                new Enrollee("Моисеев Михаил", 23, 2021),
                new Enrollee("Литвинов Алексей", 18, 2021)
            };

            Console.WriteLine("* Исходная последовательность из учеников : \n" +
                              (String.Join("\n", enrolleeList)));
            Console.WriteLine(new string('-', 60));

            var subSequence = enrolleeList
                .Where(x => true)
                .GroupBy(x => x.SchoolNumber)
                .ToDictionary(
                    x => x.Key,
                    y => new
                    {
                        count = y.Count(),
                        fullName = y.First().Name
                    }
                );

            Console.WriteLine("* Последовательность из учеников : \n" +
                              (String.Join("\n", subSequence)));

            //Задержка
            Console.ReadKey();
        }
    }
}