using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAndSimulation
{

    public class LinearCongruentialRandom
    {
        private int seed;
        private int multiplier;
        private int increment;
        private int modulus;

        public LinearCongruentialRandom(int seed, int multiplier, int increment, int modulus)
        {
            this.seed = seed;
            this.multiplier = multiplier;
            this.increment = increment;
            this.modulus = modulus;
        }

        public int Next()
        {
            seed = (multiplier * seed + increment) % modulus;
            return seed;
        }
    }

   
        
           
        
    
}
