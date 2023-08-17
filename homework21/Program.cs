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
using System.Text;

namespace homework21
{
    public class Program
    {
        public static void Main()
        {
            var drives = DriveInfo.GetDrives();
            var drive = drives.First();
            DateTime dateTime = new DateTime();
            
            var collection = new List<string?>();
            collection.Add(Enumerable.Range(1, 100).ToString()); // Массив для записи в файл 1
            collection.Add(dateTime.ToString()); //Date Time для записи в файл 2
            collection.Add(Directory.GetDirectories(drive.RootDirectory.FullName).ToString()); //Список всех директорий для записи в файл 3

            //var result = collection.ToString();
            Console.WriteLine(collection[0].ToString());

            
            //
            // var directories = Directory.GetDirectories(drive.RootDirectory.FullName);
            // var currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //
            // //Создаем дириекторию в каталоге проекта
            // try
            // {
            //     var info = new DirectoryInfo(currentPath);
            //     var createdDirectory = info.CreateSubdirectory("MyDirectory");
            //
            //
            //     if (createdDirectory.Exists)
            //     {
            //         Console.WriteLine($"Папка |{createdDirectory.Name}| успешно создана по пути: {currentPath} ");
            //     }
            //
            //     File.Create(Path.Combine(createdDirectory.FullName, "file1.txt"));
            //
            // }
            // catch (Exception e)
            // {
            //     throw new Exception("Не удалось создать директорию по указанному пути");
            // }
            //
            //
            // FileStream CreateFile(string name)
            // {
            //     var fileInfo = new FileInfo(name);
            //     if (!fileInfo.Exists)
            //         return fileInfo.Create();
            //     return File.Open(name, FileMode.Open);
            // }
        }
    }
}