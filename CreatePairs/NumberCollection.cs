using System.Collections.Generic;

namespace CreatePairs
{
    public class NumberCollection
    {
        public List<int> Negatives { get; private set; } = new List<int>();
        public List<int> Positives { get; private set; } = new List<int>();
        public bool ZeroPresent { get; private set; } = false;

        public NumberCollection(int[] data)
        {
            FindAppropriateCollectionForEachNumber(data);
            SortCollections();
        }
        private void FindAppropriateCollectionForEachNumber(int[] data)
        {
            foreach (var number in data)
            {
                if (number.IsNegative()) Negatives.Add(number);
                if (number.IsPositive()) Positives.Add(number);
                if (number == 0) ZeroPresent = true;
            }
        }
        private void SortCollections()
        {
            Negatives.Sort();
            // We want positives in descending order because logic uses it that way
            Positives.SortDescending();
        }
    }
}
