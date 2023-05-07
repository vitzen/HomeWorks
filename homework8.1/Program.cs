/*
ЗАДАЧА:
● Создать класс, описывающий пылесос
○ В классе должен быть виртуальное свойство Model для получения наименования модели пылесоса
○ В классе должен быть виртуальный метод StartCleaning, который пишет в консоль о том, что началась
уборка
○ Создать перегрузку метода StartCleaning, которая принимает параметром комнату, в которой нужно
сделать уборку
● Создать 3 класса наследника
○ Например: обычный пылесос, робот пылесос, моющий пылесос и тд
○ В 1 наследнике оставить тело метода StartCleaning родителя
○ В 2 наследнике переопределить метод StartCleaning, написав в начале уборки о том, какая модель
пылесоса начала уборку
○ В 3 наследнике реализовать сокрытие метода StartCleaning
● Каждый класс описать в отдельном файле
● Создать массив базового типа, добавить в него объекты класса пылесос. В цикле у
всех объектов вызвать метод StartCleaning
 */

using System;
using System.Reflection.Emit;
using System.Text;
using homework8._1.Rooms;
using homework8._1.Vacuum_Cleaner;
using static homework8._1.Mathematics;

namespace homework8._1
{
    class Program
    {
        public static void Main()
        {
            //Создаем объекты комнат и помещаем их в массив
            RoomClass[] rooms =
            {
                new HallRoom(10, 6),
                new KitchenRoom(8),
                new SleepingRoom(8, 5)
            };

            double totalRoomsArea = Mathematics.CalculateRoomArea(rooms);
            double totalRoomsPerimetr = Mathematics.CalculateRoomPerimetr(rooms);


            //Создаем объекты-пылесосы и помещаем их в массив
            VacuumClass[] vacuums =
            {
                new ManualVacuum("MANUAL VACUUM"),
                new RoboticVacuum("ROBOTIC VACUUM"),
                new WhashingVacuum("WHASHING VACUUM")
            };


            //Блок для вызова в каждом устройстве (пылесосе) метода StartCleaning
            string CalculateVacuums(VacuumClass[] vacuums)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var vacuum in vacuums)
                {
                    foreach (var room in rooms)
                    {
                        var str = $"{vacuum.StartCleaning(room)}";
                        sb.AppendLine(str);
                    }
                }

                return sb.ToString();
            }


            Console.WriteLine(CalculateVacuums(vacuums));
        }
    }
}