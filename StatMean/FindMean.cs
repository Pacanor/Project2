namespace StatMean
{
    public class FindMean : IFindMean
    {
        public static dynamic result;

        public dynamic Mean(dynamic a)
        {
            result = StatisticOperations.StatMean.Mean(a);
            return result;
        }
    }
}