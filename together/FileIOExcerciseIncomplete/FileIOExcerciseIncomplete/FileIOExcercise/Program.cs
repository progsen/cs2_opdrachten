using System;
using System.IO;

namespace FileIOExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = ????;//maak een nieuwe naar 1 van de directories in de test directory (volledig path vergeet je @ niet!)
            foreach (DirectoryInfo sub in ???)//haal alle directories op die in dir zitten!
            {
                Console.Write(sub.Name[5]);
            }
            Console.WriteLine();
            //welke boodschap krijg je?
            Console.ReadLine();
        }
    }
}
