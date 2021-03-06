﻿using System;

namespace MiniPay
{
    public static class StringExtensions
    {
        public static bool Matches(this string v1, string v2)
        {
            return v1.Equals(v2, StringComparison.InvariantCultureIgnoreCase);
        }

        public static string ToCamelCase(this string s)
        {
            return Char.ToLowerInvariant(s[0]) + s.Substring(1);
        }

        public static string OrDefault(this string s, string s2 = "")
        {
            return string.IsNullOrWhiteSpace(s) ? s2 : s;
        }

        public static string Without(this string s, string s2)
        {
            return s.Replace(s2, "");
        }

        public static string Required(this string s, string name)
        {
            if (string.IsNullOrWhiteSpace(s))
                throw new ArgumentNullException($"String '{name}' was null or empty.");
            return s;
        }

        public static bool ContainsAnyCase(this string s, string substring)
        {
            return s.ToLowerInvariant().Contains(substring.ToLowerInvariant());
        }
    }
}
