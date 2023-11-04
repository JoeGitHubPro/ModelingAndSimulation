namespace ModelingAndSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choise;
            
            Console.WriteLine("Choose method No...\n1-Mid Square Random\n2-Linear Congruential Random\n3-Multiplicative Congruential Random ");

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
                default:
                    Console.WriteLine("there is no choise");
                    break;
            }


        }
    }
}