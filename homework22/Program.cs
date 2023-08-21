// С помощью Newtonsoft.Json превратить в JSON несколько объектов из прошлых домашек.
// И вернуть из джейсона в объект

using System;
using System.Reflection.Emit;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Schema;
using Newtonsoft.Json;

namespace homework22
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

            HttpClient httpClient = new HttpClient();

            //Преобразование объектов - пользователей в JSON
            string objectsToJson = JsonConvert.SerializeObject(enrolleeList);
            
            //Преобразование из JSON в объектов - пользователей
            var jsonToObjects = JsonConvert.DeserializeObject(objectsToJson);


        }
    }
}

