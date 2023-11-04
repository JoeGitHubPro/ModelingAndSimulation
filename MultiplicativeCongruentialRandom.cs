using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAndSimulation
{

    public class MultiplicativeCongruentialRandom
    {
        private int seed;
        private int multiplier;
        private int modulus;

        public MultiplicativeCongruentialRandom(int seed, int multiplier, int modulus)
        {
            this.seed = seed;
            this.multiplier = multiplier;
            this.modulus = modulus;
        }

        public int Next()
        {
            seed = (multiplier * seed) % modulus;
            return seed;
        }
    }
}
