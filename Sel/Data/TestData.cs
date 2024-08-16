using Sel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Data
{
    public static class TestData
    {
        public static int[] Type { get; private set; } = {};
        public static string Site { get; private set; } = "NE UAT";
        public static string SSN { get; private set; } = "";
        public static string? Employer1 { get; private set; } = "";
        public static string? Employer2 { get; private set; } = "";
        public static bool useTwoEmployers { get; private set; } = false;
        public static string FirstName { get; private set; } = "";
        public static string LastName { get; private set; } = "";
        public static string DOB { get; private set; } = "";
        public static string? Zip { get; private set; } = "";
        public static string Email { get; private set; } = "";
        public static string Address1 { get; private set; } = "";
        public static string Phone { get; private set; } = "";
        public static string WorkBeginDate1 { get; private set; } = "";
        public static string WorkEndDate1 { get; private set; } = "";
        public static string WorkBeginDate2 { get; private set; } = "";
        public static string WorkEndDate2 { get; private set; } = "";
        public static string? StateAbbreviation { get; private set; }
        public static string? Url { get; private set; }
        public static string Username { get; private set; }
        public static string Password { get; private set; }
        public static string SecurityResponse { get; private set; }
        public static string JobTitle { get; private set; }
        public static string CreditWeeks { get; private set; } = "13";
        static readonly List<Environment> envs = Environment.CreateEnvironments();
        static TestData()
        {
            if (String.IsNullOrWhiteSpace(SSN))
            {
                SSN = DataGenerator.GenerateRandomNumbers(1, "234567") + DataGenerator.GenerateRandomNumbers(8);
            }

            Environment? selectedEnvironment = envs.FirstOrDefault(e => e.DisplayName.ToLower() == Site.ToLower());
            if (selectedEnvironment != null)
            {
                Url = selectedEnvironment.Url;
                StateAbbreviation = selectedEnvironment.StateAbbreviation;
                if (String.IsNullOrWhiteSpace(Zip))
                {
                    Zip = selectedEnvironment.ZipCode;
                }
                if (String.IsNullOrWhiteSpace(Employer1))
                {
                    Employer1 = selectedEnvironment.Employer1;
                }
                if (String.IsNullOrWhiteSpace(Employer2))
                {
                    Employer2 = selectedEnvironment.Employer2;
                }
            } else
            {
                Console.WriteLine("Environment not found.");
            }

            if (String.IsNullOrWhiteSpace(FirstName))
            {
                FirstName = "Alex";
            }

            if (String.IsNullOrWhiteSpace(LastName))
            {
                LastName = "Istomin";
            }

            if (String.IsNullOrWhiteSpace(DOB))
            {
                DOB = "11/11/1959";
            }

            //switch (Site)
            //{
            //    case "PR":
            //        Username = "GSIUIAI" + DataGenerator.GenerateRandomLetters(7) + "01";
            //        break;
            //    default:
            //        Username = "GSIUIAI" + DataGenerator.GenerateRandomLetters(7) + "1";
            //        break;
            //}

            Username = Site switch
            {
                _ when new[] { "PR" }.Any(site => TestData.Site.Contains(site)) => "GSIUIAI" + DataGenerator.GenerateRandomLetters(7) + "01",
               // _ when new[] { "AZ" }.Any(site => TestData.Site.Contains(site)) => "GSIUIAI" + DataGenerator.GenerateRandomNumbers(7),
                _ => "GSIUIAI" + DataGenerator.GenerateRandomLetters(7) + "1"
            };

            if (String.IsNullOrWhiteSpace(Email))
            {
                Email = Username + "@geosolinc.com";
            }

            if (String.IsNullOrWhiteSpace(Address1))
            {
                Address1 = "2714 Park Avenue";
            }

            if (String.IsNullOrWhiteSpace(Phone))
            {
                Phone = "8135647356";
            }

            if (String.IsNullOrWhiteSpace(WorkBeginDate1))
            {
                WorkBeginDate1 = "11/11/2011";
            }

            if (String.IsNullOrWhiteSpace(WorkEndDate1))
            {
                WorkEndDate1 = DateTime.Today.ToString("MM/dd/yyyy");
            }

            if (String.IsNullOrWhiteSpace(WorkBeginDate2))
            {
                WorkBeginDate2 = "11/11/2011";
            }

            if (String.IsNullOrWhiteSpace(WorkEndDate2))
            {
                WorkEndDate2 = DateTime.Today.ToString("MM/dd/yyyy");
            }

            Password = "Olga2011!!!!!!";
            SecurityResponse = "test";
            JobTitle = "test";

        }







    }
}
