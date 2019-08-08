using System.Linq;
using System;

namespace CreatePairs
{
    class Program
    {
        int MaximalSum(int[] data)
        {
            if (data.Length == 1) return data[0];

            return Maximizer.MaximizeSum(data);
        }

        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            Program createPairs = new Program();
            do
            {
                var split = input.Split(',');
                int[] data = split.Select(s => int.Parse(s)).ToArray();
                Console.WriteLine(createPairs.MaximalSum(data));
                input = Console.ReadLine();
            } while (input != "*");
        }
    }
}
