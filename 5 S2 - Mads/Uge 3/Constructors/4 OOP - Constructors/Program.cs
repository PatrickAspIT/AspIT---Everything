using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOP___Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        // Har lønperiode, skatteprocent, antal præsenterede timer i perioden og timeløn.
        public class Loenseddel
        {
            private (DateTime start, DateTime end) date;
            private double tax;
            private decimal hours;
            private decimal wage;

            public Loenseddel(DateTime firstDate, DateTime endDate, double taxPercent, decimal hoursAmount, decimal wageHour)
            {
                date.start = firstDate;
                date.end = endDate;
                tax = taxPercent;
                hours = hoursAmount;
                wage = wageHour;
            }

            public (DateTime start, DateTime end) Date
            {
                get { return (date.start, date.end); }
                set
                {
                    TimeSpan timeDifference = value.end - value.start;
                    if ((int)timeDifference.TotalDays != 14 && value.start.DayOfWeek != DayOfWeek.Monday || (int)timeDifference.TotalDays != 30)
                    {
                        throw new ArgumentException("Forkert 14 dag lønning.");
                    }
                    date.start = value.start;
                    date.end = value.end;
                }
            }

            public double Tax
            {
                get { return tax; }
                set
                {
                    if (value < 0.0 || value > 1.0)
                    {
                        throw new ArgumentException("Skatteprocenten skal være mellem 0.0 og 1.0.");
                    }
                    tax = value;
                }
            }

            public decimal Hours
            {
                get { return hours; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Timerne kan ikke være negative.");
                    }
                    hours = value;
                }
            }
        }
    }
}
