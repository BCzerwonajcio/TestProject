using System;

namespace Portfolio.Helpers.Methods
{   
    public static class MethodExtension
    {
        public static string ShortDate(this DateTime dateTime) => 
            dateTime.ToString("dd.MM.yyyy");

        public static string YearFirstDate(this DateTime dateTime) => 
            dateTime.ToString("yyyy-MM-dd");

        public static string Time(this DateTime dateTime) => 
            dateTime.ToString("HH:mm");
    }
}
