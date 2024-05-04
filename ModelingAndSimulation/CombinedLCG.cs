using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAndSimulation
{
    public class CombinedLCG
    {
        private const int NumGenerators = 4;
        private const int Modulus = 2147483647; // 2^31 - 1
        private const int Multiplier = 48271;
        private const int Increment = 0;

        private int[] seeds;

        public CombinedLCG(int[] seeds)
        {
            if (seeds.Length != NumGenerators)
                throw new ArgumentException($"The number of seeds must be equal to {NumGenerators}");

            this.seeds = seeds;
        }

        public int Next()
        {
            for (int i = 0; i < NumGenerators; i++)
            {
                seeds[i] = (Multiplier * seeds[i] + Increment) % Modulus;
            }

            // Combine the results of individual generators
            return (seeds[0] + seeds[1] + seeds[2] + seeds[3]) % Modulus;
        }
    }
}
