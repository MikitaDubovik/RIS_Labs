using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fifth.UserHelper
{
    public static class User
    {
        public static string Name { get; set; }

        public static string Surname { get; set; }

        public static string Patronymic { get; set; }

        [RegularExpression(@"^\+[2-9]\d{3}-\d{3}-\d{4}$", ErrorMessage = "The phone number has to have a format +xxxx-xxx-xxxx")]
        public static string PhoneNumber { get; set; }

        [StringLength(maximumLength: 2, MinimumLength = 2, ErrorMessage = "Inadmissible length of a series")]
        public static string SeriesOfPassport { get; set; }

        public static string NumberOfPassport { get; set; }

        public static List<string> Routes { get; set; }
    }
}
