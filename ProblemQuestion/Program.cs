using System;

namespace ProblemQuestion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int FindNumber(int possition)
        {
            var numbers = new int[possition];
            numbers[0] = 1;
            int i2 = 0, i3 = 0, i5 = 0;
            int no2 = 2, no3 = 3, no5 = 5;

            for (int i = 1; i < possition; i++)
            {
                var min = FindMin(no2, no3, no5);

                numbers[i] = min;

                if (min == no2)
                {
                    i2++;
                    no2 = numbers[i2] * 2;
                }
                if (min == no3)
                {
                    i3++;
                    no3 = numbers[i3] * 3;
                }
                if (min == no5)
                {
                    i5++;
                    no5 = numbers[i5] * 5;
                }
            }

            return numbers[possition - 1];
        }

        private static int FindMin(int no2, int no3, int no5)
        {
            var no35 = no3 < no5 ? no3 : no5;
            return no2 < no35 ? no2 : no35;
        }
    }
}
