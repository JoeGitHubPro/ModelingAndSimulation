using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAndSimulation
{
    public class MidSquareRandom
    {
        private int seed;

        public MidSquareRandom(int seed)
        {
            this.seed = seed;
        }

        public int Next()
        {
            int square = seed * seed;
            string squareString = square.ToString();

            // Pad the square with leading zeros if necessary
            while (squareString.Length < 8)
            {
                squareString = "0" + squareString;
            }

            // Extract the middle 4 digits as the next random number
            string middleDigits = squareString.Substring(2, 4);
            int nextRandom = int.Parse(middleDigits);

            // Update the seed for the next iteration
            seed = nextRandom;

            return nextRandom;
        }
    }
}
