using System;

namespace CourseApp
{
    public class Program
    {
        public static void Main()
        {
            string input = string.Empty;
            DateTime birthday = default(DateTime);
            DateTime today = DateTime.Now;
            do
            {
                input = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out birthday));
            string data = Data(today, birthday);
            Console.WriteLine(data);
        }

        public static string Data(DateTime today, DateTime birthday)
        {
            string data = string.Empty;
            long dataChela = today.Ticks - birthday.Ticks;
            DateTime pDate = new DateTime(dataChela);
            int year = pDate.Year - 1;
            int month = pDate.Month - 1;
            int day = pDate.Day - 1;
            data = year + " " + month + " " + day;
            return data;
        }
    }
}