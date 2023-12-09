namespace ModelingAndSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choise;

            Console.WriteLine("Choose method No...\n1-Mid Square Random\n2-Linear Congruential Random\n3-Multiplicative Congruential Random\n4-Fibonacci Random\n5-Combined LCG\n6-Random-Number Streams");

            choise = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("======================================================================");

            switch (choise)
            {

                case 1:
                    #region MidSquareRandomRegion

                    // Create a new instance of the MidSquareRandom class with a seed value
                    MidSquareRandom midRandomGenerator = new MidSquareRandom(1234);

                    // Generate and print 10 random numbers
                    for (int i = 0; i < 10; i++)
                    {
                        int randomNumber = midRandomGenerator.Next();
                        Console.WriteLine(randomNumber);
                    }

                    #endregion
                    break;
                case 2:
                    #region LinearCongruentialRandomRegion

                    // Create a new instance of the LinearCongruentialRandom class with parameters
                    LinearCongruentialRandom linearRandomGenerator = new LinearCongruentialRandom(1234, 48271, 0, 2147483647);

                    // Generate and print 10 random numbers
                    for (int i = 0; i < 10; i++)
                    {
                        int randomNumber = linearRandomGenerator.Next();
                        Console.WriteLine(randomNumber);
                    }

                    #endregion
                    break;
                case 3:
                    #region MultiplicativeCongruentialRandomRegion

                    // Create a new instance of the MultiplicativeCongruentialRandom class with parameters
                    MultiplicativeCongruentialRandom multiplicativeRandomGenerator = new MultiplicativeCongruentialRandom(1234, 48271, 2147483647);

                    // Generate and print 10 random numbers
                    for (int i = 0; i < 10; i++)
                    {
                        int randomNumber = multiplicativeRandomGenerator.Next();
                        Console.WriteLine(randomNumber);
                    }

                    #endregion
                    break;
                case 4:
                    #region FibonacciRandomGeneratorRegion
                    FibonacciRandomGenerator randomGenerator = new FibonacciRandomGenerator();

                    // Generate and print a sequence of random numbers
                    for (int i = 0; i < 10; i++)
                    {
                        int randomNumber = randomGenerator.Next();
                        Console.WriteLine(randomNumber);
                    }
                    #endregion
                    break;
                case 5:
                    #region CombinedLCGRegion
                    int[] seeds = { 123, 456, 789, 321 };
                    CombinedLCG clcg = new CombinedLCG(seeds);

                    // Generate and print a sequence of random numbers
                    for (int i = 0; i < 10; i++)
                    {
                        int randomNumber = clcg.Next();
                        Console.WriteLine(randomNumber);
                    }
                    #endregion
                    break;
                case 6:
                    #region Random-NumberStreamsRegion
                    // Create a random-number stream with a seed
                    Random random = new Random(42); // 42 is the seed

                    // Generate and print a sequence of random numbers
                    for (int i = 0; i < 10; i++)
                    {
                        int randomNumber = random.Next();
                        Console.WriteLine(randomNumber);
                    }
                    #endregion
                    break;
                default:
                    Console.WriteLine("there is no choise");
                    break;
            }

            Console.ReadKey();
        }
    }
}