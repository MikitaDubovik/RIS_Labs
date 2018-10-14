using Fifth.Extentions;
using System;
using System.IO;

namespace Fifth.Service
{
    public class BusService
    {
        private XmlService _xmlservice = new XmlService();

        private FileService _fileService = new FileService(Path.GetDirectoryName(Environment.CurrentDirectory) + "\\User.txt");

        private UserService _userService = new UserService();

        public const string ReserveChoice = "Reserve";

        public const string RemoveChoice = "Remove";

        private readonly double dollarExchangeRate = 2.01;

        private const double euroExchangeRate = 2.46;

        public void Reserve()
        {
            Console.WriteLine("Please choose id of trip");
            Console.WriteLine();

            PrintAll();

            var id = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Now please fill information about yourself");

            _userService.FillInfo();

            _xmlservice.Update(id, ReserveChoice);

            _fileService.Add(id, _xmlservice.GetDestination(id));

            Console.WriteLine("Done");
        }

        public void UnReserve()
        {
            var count = Print();

            if (count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Choose id of trip");
                var id = Console.ReadLine();

                _xmlservice.Update(id, RemoveChoice);

                _fileService.Remove(id);

                Console.WriteLine("Done");
            }
        }

        public void PrintAll()
        {
            var items = _xmlservice.Load();
            foreach (var item in items)
            {
                Console.WriteLine("ID - " + item.Id);
                Console.WriteLine("Destination - " + item.Destination);
                Console.WriteLine("Day - " + item.Day);
                Console.WriteLine("Cost in BYN - " + item.Cost + " - in USD - " + dollarExchangeRate.Count(item.Cost) + " - in EUR - " + euroExchangeRate.Count(item.Cost));
                Console.WriteLine("Number of free place - " + item.FreePlace);
                Console.WriteLine();
            }
        }

        public int Print()
        {
            _userService.FillName();

            var items = _fileService.Find();

            if (items.Count != 0)
            {
                Console.WriteLine("Your trips");
                Console.WriteLine();
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("You don't have trips");
            }

            return items.Count;
        }
    }
}
