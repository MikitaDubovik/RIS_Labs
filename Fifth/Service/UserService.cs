using Fifth.UserHelper;
using System;

namespace Fifth.Service
{
    public class UserService
    {
        private delegate string GetInfo();
        private static GetInfo _getInfo = Console.ReadLine;

        public void FillInfo()
        {
            Console.WriteLine("Enter your name");
            User.Name = _getInfo();

            Console.WriteLine("Enter your surname");
            User.Surname = _getInfo();

            Console.WriteLine("Enter your patronymic");
            User.Patronymic = _getInfo();

            Console.WriteLine("Enter your phone number");
            User.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter your series of passport");
            User.SeriesOfPassport = _getInfo();

            Console.WriteLine("Enter your number of passport");
            User.NumberOfPassport = _getInfo();
        }

        public void FillName()
        {
            Console.WriteLine("Pleas enter your name");
            User.Name = _getInfo();
        }
    }
}
