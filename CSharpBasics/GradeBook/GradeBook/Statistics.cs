using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Statistics
    {
        public double high;
        public double low;
        public double average;
        public char letter
        {
            get
            {
                switch (average)
                {
                    case var d when d >= 90:
                        return 'A';
                        
                    case var d when d >= 80:
                        return 'B';
                       
                    case var d when d >= 70:
                        return 'C';
                       
                    case var d when d < 70:
                        return 'D';
                        
                    default:
                        return 'F';
                        
                }
            }
        }
        List<double> numbers;

        public Statistics(List<double> n)
        {
            high = double.MinValue;
            low = double.MaxValue;
            average = 0;
            numbers = n;
        }

        public void computeStats()
        {
            foreach (var number in numbers)
            {
                high = Math.Max(number, high);
                low = Math.Min(number, low);
                average += number;
            }

            average /= numbers.Count;
            
        }

        
    }
}
