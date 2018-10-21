using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        private int difference;
        public int Difference
        {
            get
            {
                return this.difference;
            }
            set
            {
                this.difference = value;
            }
        }


        public static int CalculateDifference(string d1, string d2)
        {
            int[] date1tokens = d1.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] date2tokens = d2.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            DateTime date1 = new DateTime(date1tokens[0], date1tokens[1], date1tokens[2]);
            DateTime date2 = new DateTime(date2tokens[0], date2tokens[1], date2tokens[2]);
            return Math.Abs((date1 - date2).Days);
        }
    }
}
