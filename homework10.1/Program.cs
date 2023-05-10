// Домашнее задание 10.1:
// В классы для пылесосов добавить свойство максимального объема которое он может обработать.
// Добавить метод по сбору пыли, и если переданный объем превышает параметр пылесоса, сгенерировать иключение(создать свое) и обработать в вызывающем методе.
// Сделать дженерик на основе пылесоса - по собственному желанию что именно.

using System.Text;
using ClassLibrary.Rooms;
using ClassLibrary.Vacuum_Cleaner;

namespace homework10._1
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
                new ManualVacuum<string>("MANUAL VACUUM", 100),
                new RoboticVacuum<string>("ROBOTIC VACUUM", 90),
                new WhashingVacuum<int>("WHASHING VACUUM", 79)
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

            //Блок для подсчета 
            static string CalculateMaxDustVolumeOfRoom(VacuumClass[] vacuums, RoomClass[] rooms)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var vacuum in vacuums)
                {
                    foreach (var room in rooms)
                    {
                        var str = $"{vacuum.CalculateMaxDustVolumeOfRoom(room)}";
                        sb.AppendLine(str);
                    }
                }

                return sb.ToString();
            }

            Console.WriteLine(CalculateMaxDustVolumeOfRoom);
        }
    }
}