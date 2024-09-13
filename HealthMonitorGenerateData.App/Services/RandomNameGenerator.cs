using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthMonitorGenerateData.App.Services
{
    public class RandomNameGenerator
    {
        private static readonly List<string> FirstNames = new List<string>
        {
                "James", "William","Michael","Robert","David","Mary","Patricia","Jennifer","Linda","Elizabeth"
        };

        private static readonly List<string> LastNames = new List<string>
        {
            "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Wilson", "Anderson", "Taylor"
        };

        private static readonly List<string> MiddleNames = new List<string>
        {
            "James", "Alexander", "Michael", "William", "Thomas", "Marie", "Elizabeth", "Grace", "Rose", "Anne"
        };

        private static readonly Random Random = new Random();

        public static string GenerateFirstName()
        {
            return FirstNames[Random.Next(FirstNames.Count)];
        }

        public static string GenerateLastName()
        {
            return LastNames[Random.Next(LastNames.Count)];
        }

        public static string GenerateMiddleName()
        {
            return MiddleNames[Random.Next(MiddleNames.Count)];
        }

        public static string GenerateFullName()
        {
            return $"{GenerateLastName()} {GenerateFirstName()} {GenerateMiddleName()}";
        }
    }
}
