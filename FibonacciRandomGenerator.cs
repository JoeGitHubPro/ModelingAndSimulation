using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAndSimulation
{
    public class FibonacciRandomGenerator
    {
        private int a;
        private int b;

        public FibonacciRandomGenerator()
        {
            // Initialize the generator with arbitrary seed values
            a = 987654321;
            b = 123456789;
        }

        public int Next()
        {
            int result = a + b;

            // Update seed values for the next iteration
            a = b;
            b = result;

            // Take the lower bits to avoid integer overflow
            return result & int.MaxValue;
        }
    }
}
