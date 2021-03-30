using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ClassLibrary8_1
{
    public class ReadnSave
    {


        public static void GetInfo()
        {
            string path = @"C:\UsrInf\HoWo8.txt";

            string[] readText = File.ReadAllLines(path, Encoding.UTF8);
            for (int i = 0; i < readText.Length; i++)
            {
                Console.WriteLine(readText[i]);
            }

            var info = new List<string>(3);

            string userName = $"Имя пользователя: ";
            Console.WriteLine(userName);
            info.Add(userName);
            info.Add(Console.ReadLine());

            string userAge = $"Возсраст пользователя: ";
            Console.WriteLine(userAge);
            info.Add(userAge);
            info.Add(Console.ReadLine());

            string userJob = $"Род деятельности: ";
            Console.WriteLine(userJob);
            info.Add(userJob);
            info.Add(Console.ReadLine());

            File.WriteAllLines(@"C:\UsrInf\HoWo8.txt", info.ToArray());

        }

    }
}