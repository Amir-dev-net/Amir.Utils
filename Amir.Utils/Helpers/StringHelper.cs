using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amir.Utils.Helpers
{
    public static class StringHelper
    {
        public static string ToTitleCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }

        public static string Slugify(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            input = input.ToLowerInvariant();
            input = System.Text.RegularExpressions.Regex.Replace(input, @"[^a-z0-9\s-]", "");
            input = System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ").Trim();
            input = input.Replace(" ", "-");

            return input;
        }

        public static string RemoveSpecialCharacters(string input)
        {
            return System.Text.RegularExpressions.Regex.Replace(input, @"[^a-zA-Z0-9\s]", "");
        }
    }
}
