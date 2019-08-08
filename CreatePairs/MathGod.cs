using System.Collections.Generic;

namespace CreatePairs
{
    public static class MathGod
    {
        public static bool IsNegative (this int number)
        {
            return number < 0;
        }
        public static bool IsPositive(this int number)
        {
            return number > 0;
        }
        public static void SortDescending(this List<int> list)
        {
            list.Sort();
            list.Reverse();
        }
    }
}
