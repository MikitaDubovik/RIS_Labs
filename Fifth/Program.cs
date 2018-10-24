using Fifth.BusHelper;
using System;
using Fifth.UserHelper;
using Fifth.Service;

namespace Fifth
{
    public class Program
    {
        private static BusService _busService = new BusService();

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Choose operation");
                Console.WriteLine("1.Reserve");
                Console.WriteLine("2.Print all available trips");
                Console.WriteLine("3.Print all your trips");
                Console.WriteLine("4.Print trips in a certain day");
                Console.WriteLine("5.Unreserve");
                Console.WriteLine("6.Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        _busService.Reserve();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        _busService.PrintAll();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        _busService.Print();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        _busService.PrintAllInDay();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        _busService.UnReserve();
                        Console.ReadKey();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (true);
        }
    }
}
