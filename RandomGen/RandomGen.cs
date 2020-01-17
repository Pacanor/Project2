using System;

namespace RandomGen
{
    public class RandomGen
    {
        private static readonly Random random = new Random();

        public static int RandomInt()
        {
            return random.Next(100);
        }

        public static double RandomDouble()
        {
            double temp = random.Next(100) * random.NextDouble();
            double number = Math.Round(temp, 2, MidpointRounding.ToEven);
            return number;
        }

        public static int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        public static double RandomNumber(double min, double max)
        {
            int minInt = Convert.ToInt32(min);
            int maxInt = Convert.ToInt32(max);
            double temp = -10000.00;
            while (min >= temp || temp >= max)
            {
                var temp2 = random.Next(minInt, maxInt) * random.NextDouble();
                temp = Math.Round(temp2, 2, MidpointRounding.AwayFromZero);
            }
            double number = temp;
            return number;
        }

        public static double[] RandomDoubles(int num)
        {
            double[] numbers = new double[num];
            int i = 0;
            while (i < num)
            {
                numbers[i] = RandomDouble();
                i++;
            }
            return numbers;
        }

        public static int[] RandomInts(int num)
        {
            int[] numbers = new int[num];
            int i = 0;
            while (i < num)
            {
                numbers[i] = RandomInt();
                i++;
            }
            return numbers;
        }

        public static double[] RandomDoubles(int num, double min, double max)
        {
            double[] numbers = new double[num];
            int i = 0;
            while (i < num)
            {
                numbers[i] = RandomNumber(min, max);
                i++;
            }
            return numbers;
        }

        public static int[] RandomInts(int num, int min, int max)
        {
            int[] numbers = new int[num];
            int i = 0;
            while (i < num)
            {
                numbers[i] = RandomNumber(min, max);
                i++;
            }
            return numbers;
        }
    }
}