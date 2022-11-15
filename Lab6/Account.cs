using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Account
    {
        public static int count { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateofbirth { get; set; }
        public static readonly decimal minSum;
        static Account()
        {
            minSum = 1400000;
        }
        public Account(string firstName, string lastName, DateTime dateofbirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateofbirth = dateofbirth;
        }

        public void Report()
        {
            Console.WriteLine(lastName + " " + firstName + " " + dateofbirth + " ");
        }

        public static decimal GetSum(decimal sum, int period, AccountState state)
        {
            Console.WriteLine(state);
            if (sum > minSum)
            {
                return sum / period;

            }
            return 0;
        }
    }
}
