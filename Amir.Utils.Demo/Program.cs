using System;
using Amir.Utils.Helpers;

namespace Amir.Utils.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🔤 String Helper Examples:\n");

            string input = "hello from amir!";
            Console.WriteLine($"Original: {input}");
            Console.WriteLine($"ToTitleCase: {StringHelper.ToTitleCase(input)}");

            string slugInput = "Hello, World! This is a test.";
            Console.WriteLine($"\nOriginal: {slugInput}");
            Console.WriteLine($"\nSlugify: {StringHelper.Slugify(slugInput)}");

            string specialChars = "Hi@# Amir!";
            Console.WriteLine($"\nOriginal: {specialChars}");
            Console.WriteLine($"\nRemoved Special Characters: {StringHelper.RemoveSpecialCharacters(specialChars)}");


            Console.WriteLine("\n--------------------------------------------:\n");
            Console.WriteLine("\n📅 DateTime Helper Examples:\n");

            DateTime past = DateTime.UtcNow.AddMinutes(-45);
            Console.WriteLine($"Original: {past}");
            Console.WriteLine($"ToHumanReadable (45 mins ago): {DateTimeHelper.ToHumanReadable(past)}");

            DateTime today = DateTime.Today;
            Console.WriteLine($"\nOriginal: {today}");
            Console.WriteLine($"IsWeekend (Today): {DateTimeHelper.IsWeekend(today)}");

            DateTime startDate = DateTime.Today.AddDays(-10);
            Console.WriteLine($"\nOriginal: {startDate}");
            DateTime endDate = DateTime.Today;
            Console.WriteLine($"\nOriginal: {endDate}");
            Console.WriteLine($"BusinessDaysBetween (-10 days to today): {DateTimeHelper.BusinessDaysBetween(startDate, endDate)}");

            Console.WriteLine("\n✅ Done.");
        }
    }
}
