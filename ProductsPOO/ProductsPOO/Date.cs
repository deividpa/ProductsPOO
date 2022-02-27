using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsPOO
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = checkMonth(month);
            _day = checkDay(year, month, day);
        }

        private int checkDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day > 0 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException($"Invalid day: {day}");
        }

        private bool IsLeapYear(int year)
        {

            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

        }

        private int checkMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            throw new monthException($"Invalid month: {month}");
        }

        public override string ToString()
        {
            return $"{_year:00}/{_month:00}/{_day:00}";
        }
    }
}
