// 1 Создать директорию
// 2 Создать в ней 3 файла.
// Первый - с массивом чисел от 1 до 100.
// Второй - с текущей датов,
// Третий - со списком всех подкаталогов из c:/ProgramFiles (или любого другого)
// 3 Считать информацию из файлов, созданных в пункте 2.
// 4 Файл №2 перенести в новую директорию(ее нужно тоже создать, в любом месте)
// 5 Перенести категорию №1 в категорию, созданную на шаге 4.
// 6 Задание на FileStream. Считать из файла №1 только ту порцию информации,
// где хранятся числа от 10 до 20. Перезаписать их на числа от 200 до 210.

using System;
using System.IO;
using System.Net.Mime;
using System.Reflection;

namespace homework21
{
    public class Program
    {
        public static void Main()
        {
            int[] arrayExample = Enumerable.Range(1, 100).ToArray(); // Массив для записи в файл 1
            DateTime dateTime = new DateTime(); //Date Time для записи в файл 2

            var drives = DriveInfo.GetDrives();
            var drive = drives.First();

            var directories = Directory.GetDirectories(drive.RootDirectory.FullName);
            var currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            //Создаем дириекторию в каталоге проекта
            try
            {
                var info = new DirectoryInfo(currentPath);
                var createdDirectory = info.CreateSubdirectory("MyDirectory");
                File.Create(Path.Combine(createdDirectory.FullName, "text.txt"));
                if (createdDirectory.Exists)
                {
                    Console.WriteLine("Директория успешно создана");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Не удалось создать директорию");
            }


            static void WriteByStreem()
            {
                using (FileStream filestream = File.Open())
                {
                }
            }

            // Console.WriteLine(String.Join(",", Content.));
        }
    }
}