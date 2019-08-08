using System.Linq;

namespace CreatePairs
{
    public class PairwiseSumMaximizer
    {
        private NumberCollection NumberCollection;
        public int Sum { get; private set; }

        public PairwiseSumMaximizer(int[] data)
        {
            this.NumberCollection = new NumberCollection(data);
            Summation();
        }

        private void Summation()
        {
            Sum = 0;
            Sum += MaximizeNegativePairSum();
            Sum += MaximizePositivePairsSum();
        }

        private int MaximizePositivePairsSum()
        {
            int sum = 0;
            for (int i = 0; i < this.NumberCollection.Positives.Count / 2; i++)
            {
                int item = this.NumberCollection.Positives[2 * i] * this.NumberCollection.Positives[2 * i + 1];
                sum += item != 1 ? item : 0;
            }
            if (this.NumberCollection.Positives.Count % 2 == 1)
            {
                int item = this.NumberCollection.Positives[this.NumberCollection.Positives.Count - 1];
                if (item != 1) sum += item;
            }

            sum += this.NumberCollection.Positives.Count(i => i == 1);
            return sum;
        }

        private int MaximizeNegativePairSum()
        {
            int sum = 0;
            for (int i = 0; i < this.NumberCollection.Negatives.Count / 2; i++)
            {
                sum += this.NumberCollection.Negatives[2 * i] * this.NumberCollection.Negatives[2 * i + 1];
            }
            if (this.NumberCollection.Negatives.Count % 2 == 1)
            {
                if (this.NumberCollection.ZeroPresent == false)
                    sum += this.NumberCollection.Negatives[this.NumberCollection.Negatives.Count - 1];
            }

            return sum;
        }
    }
}
