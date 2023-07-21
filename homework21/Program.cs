using System;
using System.IO;


namespace homework20
{
    public class Program
    {
        public static void Main()
        {
            var drives = DriveInfo.GetDrives();
            Console.WriteLine(drives);
        }
    }
}