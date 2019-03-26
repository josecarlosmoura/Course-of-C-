using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class StringExtension
    {
        public static string FirstLetterToUpper(this String str)
        {
            string firstLetter = str.Substring(0, 1);

            return firstLetter.ToUpper() + str.Substring(1);
        }

        public static string FirstLetterOfNameToUpper(this String str)
        {
            string[] listNames = str.Split(" ");

            string newName = string.Empty;

            foreach (var item in listNames)
            {
                newName += item.FirstLetterToUpper() + " ";
            }

            return newName;
        }
    }
}
