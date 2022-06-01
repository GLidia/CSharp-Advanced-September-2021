using System;
using System.Collections.Generic;
using System.Text;

namespace _05_DateModifier
{
    public class DateModifier
    {
        private DateTime dateOne;
        private DateTime dateTwo;

        public DateTime DateOne
        {
            get { return this.dateOne; }
            set { this.dateOne = value; }
        }

        public DateTime DateTwo
        {
            get { return this.dateTwo; }
            set { this.dateTwo = value; }
        }

        public DateModifier(string one, string two)
        {
            string[] arrayOne = one.Split();
            int year = int.Parse(arrayOne[0]);
            int month = int.Parse(arrayOne[1]);
            int day = int.Parse(arrayOne[2]);
            this.DateOne = new DateTime(year, month, day);

            string[] arrayTwo = two.Split();
            int yearTwo = int.Parse(arrayTwo[0]);
            int monthTwo = int.Parse(arrayTwo[1]);
            int dayTwo = int.Parse(arrayTwo[2]);
            this.DateTwo = new DateTime(yearTwo, monthTwo, dayTwo);
        }

        public int CalculateDifference()
        {
            return Math.Abs((this.DateTwo - this.DateOne).Days);
        }

    }
}
