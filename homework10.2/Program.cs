// Домашнее задание 10.1: !!! с применением GENERIC
// В классы для пылесосов добавить свойство максимального объема которое он может обработать.
// Добавить метод по сбору пыли, и если переданный объем превышает параметр пылесоса,
// сгенерировать иключение(создать свое) и обработать в вызывающем методе.

using System.Text;
using NewClassLibrary.Rooms;
using NewClassLibrary.Vacuum_Cleaner;

namespace homework10._2
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

            //Создаем массив в котором мы можем работать с дженериками любого типа
            //за счет созданного родительского класса SuperVacuum
            SuperVacuum[] vacuums =
            {
                new ManualVacuum("MANUAL", 1),
                new RoboticVacuum("ROBOTIC", 89),
                new WhashingVacuum(009385647, 67)
            };

            //Блок для получения статуса --> GetStartVacuumStates с каждого пылесоса при старте работы
            string GetStartVacuumStates(SuperVacuum[] vacuums)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var vacuum in vacuums)
                {
                    foreach (var room in rooms)
                    {
                        var str = $"{vacuum.StartCleaning(room, vacuum)}";
                        sb.AppendLine(str);
                    }
                }

                return sb.ToString();
            }

            Console.WriteLine($"{GetStartVacuumStates(vacuums)}\n");

            //Блок для получения статуса вместимости каждого пылесоса
            static string GetVacuumMaxVolumeStates(SuperVacuum[] vacuums, RoomClass[] rooms)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var vacuum in vacuums)
                {
                    foreach (var room in rooms)
                    {
                        var str = $"{vacuum.CalculateMaxDustVolumeOfRoom(room, vacuum)}";
                        sb.AppendLine(str);
                    }
                }

                return sb.ToString();
            }

            Console.WriteLine(GetVacuumMaxVolumeStates(vacuums, rooms));
        }
    }
}