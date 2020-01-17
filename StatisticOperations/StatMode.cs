using System;
using System.Collections.Generic;

namespace StatisticOperations
{
    public class StatMode
    {
        public static int Mode(int[] values)
        {
            int mode = default;
            int length = values.Length;
            if (length > 0)
            {
                Dictionary<int, int> counts = new Dictionary<int, int>();

                foreach (int a in values)
                {
                    if (counts.ContainsKey(a))
                        counts[a]++;
                    else
                        counts.Add(a, 1);
                }

                int max = 0;
                foreach (KeyValuePair<int, int> count in counts)
                {
                    if (count.Value > max)
                    {
                        // Update the mode
                        mode = count.Key;
                        max = count.Value;
                    }
                }
                if (max > 1)
                {
                    return mode;
                }
                else
                {
                    throw new OperationCanceledException("There is no Mode in this array");
                }
            }
            else
            {
                throw new InvalidOperationException("This array is empty");
            }
        }

        public static double Mode(double[] values)
        {
            double mode = default;
            int length = values.Length;
            if (length > 0)
            {
                Dictionary<double, int> counts = new Dictionary<double, int>();

                foreach (double a in values)
                {
                    if (counts.ContainsKey(a))
                        counts[a]++;
                    else
                        counts.Add(a, 1);
                }

                int max = 0;
                foreach (KeyValuePair<double, int> count in counts)
                {
                    if (count.Value > max)
                    {
                        // Update the mode
                        mode = count.Key;
                        max = count.Value;
                    }
                }
                if (max > 1)
                {
                    return mode;
                }
                else
                {
                    throw new OperationCanceledException("There is no Mode in this array");
                }
            }
            else
            {
                throw new InvalidOperationException("This array is empty");
            }
        }
    }
}