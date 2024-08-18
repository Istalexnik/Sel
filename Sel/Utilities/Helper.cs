using Sel.Data;
using Sel.Enums;
using Sel.GUI;
using System.Text;
using System.Windows;

namespace Sel.Utilities
{
    public static class Helper
    {
        private static Random random = new Random();

        public static string GenerateRandomLetters(int length, string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        {
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(letters[random.Next(letters.Length)]);
            }

            return result.ToString();
        }

        public static string GenerateRandomNumbers(int length, string numbers = "0123456789")
        {
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(numbers[random.Next(numbers.Length)]);
            }

            return result.ToString();
        }

        public static string GenerateUniqueBirthdate()
        {
            int year = random.Next(1930, 2000);
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

        public static bool CheckPause(PageType currentPage)
        {
            if (TestData.SelectedPages!.Contains(currentPage))
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    DialogHelper.ShowCustomPauseDialog($"You are on the page: {currentPage}. Please perform your actions on this page, then manually navigate to the next page and only after that click Ok on this dialog to continue the execution.");
                });
                return true;
            }
            return false;
        }


    }

}
