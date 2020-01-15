namespace StatZScore
{
    public class FindZScore : IFindZScore
    {
        public static dynamic result;

        public double ZScore(dynamic score, dynamic values)
        {
            result = StatisticOperations.StatZScore.ZScore(score, values);
            return result;
        }
    }
}