using System;
using System.IO;
using FileService;

namespace RIS
{
    public class Program
    {
        private static readonly string FileName = Path.GetDirectoryName(Environment.CurrentDirectory) + "\\..\\Repo.txt";
        private static readonly FileWorker FileWorker = new FileWorker(FileName);

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose operation");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Print");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.Update");
                Console.WriteLine("5.Sort by name");
                Console.WriteLine("6.Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        FileWorker.Add();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(FileWorker.GetAll());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        FileWorker.Delete();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        FileWorker.Update();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        foreach (var ice in FileWorker.Sort())
                        {
                            Console.WriteLine(ice);
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (true);
        }
    }
}
