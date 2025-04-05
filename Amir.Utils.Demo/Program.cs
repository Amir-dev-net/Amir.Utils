using System;
using Amir.Utils.Helpers;

namespace Amir.Utils.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringHelper.ToTitleCase("hello from amir!"));

            var readable = DateTimeHelper.ToHumanReadable(DateTime.UtcNow.AddMinutes(-45));
            Console.WriteLine(readable);
        }
    }
}
