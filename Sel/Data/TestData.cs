using Sel.Data;
using Sel.Enums;
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
        public static ClaimType ClaimType { get; set; }
        public static string SSN { get; set; } = "";
        public static string? Employer1 { get; set; } = "";
        public static string? Employer2 { get; set; } = "";
        public static bool useTwoEmployers { get; set; } = false;
        public static string FirstName { get; set; } = "";
        public static string LastName { get; set; } = "";
        public static string DOB { get; set; } = "";
        public static string? Zip { get; set; } = "";
        public static string Email { get; set; } = "";
        public static string Address1 { get; set; } = "2714 Park Avenue";
        public static string Phone { get; set; } = "8135647356";
        public static string WorkBeginDate1 { get; set; } = "";
        public static string WorkEndDate1 { get; set; } = "";
        public static string WorkBeginDate2 { get; set; } = "";
        public static string WorkEndDate2 { get; set; } = "";
        public static string? StateName { get; set; }
        public static string? StateAbbreviation { get; set; }
        public static List<PageType>? SelectedPages { get; set; }
        public static string? Url { get; set; } = "";
        public static string Username { get; set; } = "";
        public static string Password { get; set; } = "Hrjt2345^^^^^";
        public static string SecurityResponse { get; set; } = "test";
        public static string JobTitle { get; set; } = "test";
        public static string CreditWeeks { get; set; } = "13";

    }
}