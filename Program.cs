using System;
using System.Globalization;


namespace ZadanieKwalifikacyjne
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] dates = new string[1];
            string pattern = "dd.MM.yyyy";
            string patternMonthYear = "MM.yyyy";
            string patternMonth = "dd.MM";
            string patternDay = "dd";
            string patternYear = "yyyy";

            input = Console.ReadLine();
                dates = input.Split(' ');

            if ((DateTime.TryParseExact(dates[0], pattern, null,
                                   DateTimeStyles.None, out var date1)) &&
                                   (DateTime.TryParseExact(dates[1], pattern, null,
                                   DateTimeStyles.None, out var date2)))
            {
                TimeSpan difference = date2 - date1;

                if (date2.Year != date1.Year)
                {
                    Console.WriteLine("{0} - {1}", date1.ToString(pattern), date2.ToString(pattern));
                }
                else if (date2.Month != date1.Month)
                {
                    Console.WriteLine("{0} - {1}.{2}", date1.ToString(patternMonth), date2.ToString(patternMonth), date2.ToString(patternYear));
                }
                else if (date2.Day != date1.Day)
                {
                    Console.WriteLine("{0} - {1}.{2}", date1.ToString(patternDay), date2.ToString(patternDay), date2.ToString(patternMonthYear));
                }
                else
                {
                    Console.WriteLine("There is no difference in those dates");
                }

            }
            else
            {
                Console.WriteLine("Unable to convert ",
                                  input);
            }

            
        }

    }
}
