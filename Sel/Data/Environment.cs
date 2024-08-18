using System.Collections.Generic;

namespace Sel.Data
{
    public class Environment
    {
        public string DisplayName { get; }
        public string Url { get; }
        public string ZipCode { get; }
        public string StateName { get; }
        public string StateAbbreviation { get; }
        public string Employer1 { get; }
        public string Employer2 { get; }

        public Environment(string displayName, string url, string zipCode, string stateName, string stateAbbreviation, string employer1, string employer2)
        {
            DisplayName = displayName;
            Url = url;
            ZipCode = zipCode;
            StateName = stateName;
            StateAbbreviation = stateAbbreviation;
            Employer1 = employer1;
            Employer2 = employer2;
        }

        public static List<Environment> CreateEnvironments()
        {
            return new List<Environment>
            {
                new Environment("IA UAT", "https://uat-app-vos19000000-gus.geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "LAXMI JT LLC", "Tampa Toyota"),
                new Environment("IA CUAT", "https://cuat-app-vos19000000-geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "Publix", "Tampa Toyota"),
                new Environment("IA QA", "https://qa-app-vos19000000-geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "Target", "Amazon Com Services Inc"),
                new Environment("IA STAGING", "https://staging-app-vos19000000.geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "Target", "Amazon Web Services, Inc."),
                new Environment("PR UAT", "https://uat-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Publix", "Tampa Toyota"),
                new Environment("PR QA", "https://qa-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Publix", "Tampa Toyota"),
                new Environment("PR STAGING", "https://staging-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Prog Child Care", "Toyota"),
                new Environment("DC UAT", "https://uat-app-vos11000000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "SERDINO INC", "Tampa Toyota"),
                new Environment("DC QA", "https://qa-app-vos11000000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Tampa Toyota"),
                new Environment("DC STAGING", "https://staging-app-vos11000000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Toyota Motor North America Inc", "Tampa Toyota"),
                new Environment("DC PFL UAT", "https://uat-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Tampa Toyota"),
                new Environment("DC PFL CUAT", "https://cuat-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Tampa Toyota"),
                new Environment("DC PFL STAGING", "https://staging-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Tampa Toyota"),
                new Environment("PA UAT", "https://uat-app-vos42000000.geosolinc.com/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "SERDINO INC", "Amazon"),
                new Environment("PA CIT", "https://cit.benefits.uc.pa.gov/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "SERDINO INC", "Tampa Toyota"),
                new Environment("PA CUAT", "https://uat.benefits.uc.pa.gov/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "Target", "Toyota"),
                new Environment("PA QA", "https://qa-app-vos42000000.geosolinc.com/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "SERDINO INC", "Publix"),
                new Environment("NE UAT", "https://uat-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "AIR CONDITIONING UTILITIES", "Amazon"),
                new Environment("NE QA", "https://qa-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "Target", "Tampa Toyota"),
                new Environment("NE STAGING", "https://staging-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "ABEL INC", "Tampa Toyota"),
                new Environment("LA UAT", "https://uat-app-vos22000000.geosolinc.com/vosnet/default.aspx", "70803", "Louisiana", "LA", "MICROCHIP LLC", "Tampa Toyota"),
                new Environment("LA QA", "https://qa-app-vos22000000.geosolinc.com/vosnet/default.aspx", "70803", "Louisiana", "LA", "Publix", "Tampa Toyota"),
                new Environment("TN UAT", "https://uat-app-vos47000000.geosolinc.com/vosnet/default.aspx", "37243", "Tennessee", "TN", "Target", "Tampa Toyota"),
                new Environment("TN QA", "https://qa-app-vos47000000.geosolinc.com/vosnet/default.aspx", "37243", "Tennessee", "TN", "Target", "Tampa Toyota"),
                new Environment("AZ UAT", "https://uat-app-vos04000000.geosolinc.com/vosnet/default.aspx", "86438", "Arizona", "AZ", "GENCORP INC", "Publix"),
                new Environment("AZ CUAT", "https://cuat-app-vos04000000.geosolinc.com/vosnet/default.aspx", "86438", "Arizona", "AZ", "GENCORP INC", "Publix"),
                new Environment("AZ QA", "https://qa-app-vos04000000.geosolinc.com/vosnet/default.aspx", "86438", "Arizona", "AZ", "GETTYSBURG HARDWARE STORE", "BENDERSVILLE GARAGE"),
                new Environment("AZ STAGING", "https://staging-app-vos04000000.geosolinc.com/vosnet/default.aspx", "86438", "Arizona", "AZ", "Target", "Tampa Toyota"),
                new Environment("NV UAT", "https://uat-app-vos32000000.geosolinc.com/vosnet/default.aspx", "89101", "Nevada", "NV", "Publix", "Tampa Toyota")
            };
        }
    }
}
