using System;

namespace RandomNumbers
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
            double temp = random.Next(minInt, maxInt) * random.NextDouble();
            double number = Math.Round(temp, 2, MidpointRounding.ToEven);
            return number;
        }
        
        public static double[] RandomDoubles(int num)
        {
            double[] numbers = new double[num];
            int i = 0;
            while (i < num)
            {
                double temp = random.Next(100) * random.NextDouble();
                numbers[i] = Math.Round(temp, 2, MidpointRounding.ToEven);
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
                numbers[i] = random.Next(100);
                i++;
            }
            return numbers;
        }

        public static double[] RandomDoubles(int num, double min, double max)
        {
            int minInt = Convert.ToInt32(min);
            int maxInt = Convert.ToInt32(max);
            double[] numbers = new double[num];
            int i = 0;
            while (i < num)
            {
                double temp = random.Next(minInt, maxInt) * random.NextDouble();
                numbers[i] = Math.Round(temp, 2, MidpointRounding.ToEven);
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
                numbers[i] = random.Next(min, max);
                i++;
            }
            return numbers;
        }

    }
}
