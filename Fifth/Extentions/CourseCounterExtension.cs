namespace Fifth.Extentions
{
    public static class CourseCounterExtension
    {
        public static string Count(this double course, string money)
        {
            var result = double.TryParse(money, out var moneyDouble);
            if (result)
            {
                return (course * moneyDouble).ToString();
            }
            else
            {
                return "Error in counting";
            }
        }
    }
}
