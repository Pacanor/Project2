namespace StatMedian
{
    public class FindMedian : IFindMedian
    {
        public static dynamic result;

        public dynamic Median(dynamic a)
        {
            result = StatisticOperations.StatMedian.Median(a);
            return result;
        }
    }
}