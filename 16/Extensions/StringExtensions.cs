using System;

namespace 16.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int count)
        {
            if (thisObj.Lenght <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObje.Substring(0, count) + "...";
            }
        }
    }
}