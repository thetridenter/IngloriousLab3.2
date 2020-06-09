using System;
using System.IO;

namespace IngloriousLab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма створена для запису результатів переможців у змаганні");

            Console.WriteLine("Введіть прізвище третього фіналіста");
            string third = Console.ReadLine();
            Console.WriteLine("Введіть результат третього фіналіста");
            int thirdres = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть прізвище другого фіналіста");
            string second = Console.ReadLine();
            Console.WriteLine("Введіть результат другого фіналіста");
            int secondres = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть прізвище першого фіналіста");
            string first = Console.ReadLine();
            Console.WriteLine("Введіть результат першого фіналіста");
            int firstres = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть прізвище та ім'я голови журі");
            string namesurname = Console.ReadLine();

            string path = @"/Users/kostiantyn/Desktop/University/Object_Oriented_Programming/Assets/Lab3/sport.txt";

            FileInfo myfile = new FileInfo(path);

            StreamWriter sw;

            if (myfile.Exists)
            {
                myfile.Delete();
            }

            sw = myfile.CreateText();
            sw.Write($"Результати фіналістів \nТретє місце \n{third}\t{thirdres}\nДруге місце \n{second}\t{secondres}\nПерше місце \n{first}\t{firstres}");
            sw.Write("\n \n Голова журі — " + namesurname);
            sw.Close();
        }
    }
}