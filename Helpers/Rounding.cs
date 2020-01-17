using System;

namespace Helpers
{
    public class Rounding
    {
        public static dynamic RoundOffTwoPlaces(dynamic value)
        {
            return Math.Round(value, 2, MidpointRounding.ToEven);
        }

        public static dynamic RoundOFFThreePlaces(dynamic value)
        {
            return Math.Round(value, 3, MidpointRounding.ToEven);
        }
    }
}