namespace CreatePairs
{
    public class Maximizer
    {
        public static int MaximizeSum(int[] data)
        {
            var pairSumFinder = new PairwiseSumMaximizer(data);
            return pairSumFinder.Sum;
        }
    }
}
