using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Utilities
{
    public static class DataGenerator
    {
        private static Random random = new Random();

        public static string GenerateRandomLetters(int length, string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        {
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(LETTERS[random.Next(LETTERS.Length)]);
            }

            return result.ToString();
        }

        public static string GenerateRandomNumbers(int length, string NUMBERS = "0123456789")
        {
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(NUMBERS[random.Next(NUMBERS.Length)]);
            }

            return result.ToString();
        }

        public static string GenerateUniqueBirthdate()
        {
            int year = random.Next(1920, 2020);
            int month = random.Next(1, 13);

            int maxDay;
            switch (month)
            {
                case 2:
                    maxDay = (DateTime.IsLeapYear(year)) ? 29 : 28;  // Handle leap years for February
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    maxDay = 30;  // Months with 30 days
                    break;
                default:
                    maxDay = 31;  // All other months have 31 days
                    break;
            }

            int day = random.Next(1, maxDay + 1);

            DateTime birthdate = new DateTime(year, month, day);
            return birthdate.ToString("MM/dd/yyyy");
        }


    }
    
}
