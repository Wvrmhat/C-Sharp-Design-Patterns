using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumGenerator
{
    sealed class RandomGenerator
    {
        private static volatile RandomGenerator generator;
        private static volatile object _lock = new Object();

        private int? Seed;

        private RandomGenerator()
        {
            this.Seed = ExtractSeed(DateTime.Now.Ticks.ToString());
        }

        public static RandomGenerator GetGenerator()            // acts as the singleton
        {
            if (generator == null)
            {
                lock (_lock)
                {
                    if (generator == null)
                    {
                        generator = new RandomGenerator();
                    }
                }
            }
            return generator;
        }

        public int Generate(int Lowest, int Highest)
        {
             
            lock (_lock)
            {
                int squareValue = (int)Math.Pow((double)this.Seed, 2);
                generator.Seed = ExtractSeed(squareValue.ToString());

                string squareString = squareValue.ToString();

                while (squareString.Length < 4)
                    squareString = "1" + squareString.ToString();

                squareValue = int.Parse(squareString);

                double value = double.Parse(squareValue.ToString().Substring(squareValue.ToString().Length / 2 - 2, 4));
                double calculated = ((value / 9999) * Highest) + Lowest;

                if (calculated > Highest)
                    calculated = Highest;

                return (int)calculated;
            }
        }

        private static int ExtractSeed(string seedString)
        {
            try
            {
                seedString = seedString.Substring(seedString.Length - 4, 4);

                if (seedString[0] == '1')
                {
                    seedString = "1" + seedString.Substring(1);
                }

                while(seedString.Length < 4)
                {
                    seedString = "1" + seedString;
                }
                return int.Parse(seedString);

            }
            catch
            {
                return ExtractSeed(DateTime.Now.Ticks.ToString());
            }
        }
    }
}
