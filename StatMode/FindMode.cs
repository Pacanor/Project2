namespace StatMode
{
    public class FindMode : IFindMode
    {
        public static dynamic result;

        public dynamic Mode(dynamic a)
        {
            result = StatisticOperations.StatMode.Mode(a);
            return result;
        }
    }
}