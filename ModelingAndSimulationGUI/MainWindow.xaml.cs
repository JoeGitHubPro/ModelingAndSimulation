using ModelingAndSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModelingAndSimulationGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblHead.Content = "Suez canal university";
            lblHead1.Content = "Faculty of science";
            lblHead2.Content = "Mathematics Department";
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            List<int> lst = new List<int>();
            int select = cbxMethods.SelectedIndex;
            if (select == -1)
            {
                MessageBox.Show("please select Generation Method!!!","Warning",MessageBoxButton.OK,MessageBoxImage.Warning);
                return;
            }

          int Rounds = 0;
            
          bool result =   Int32.TryParse(txtNoitr.Text, out Rounds);
            if (!result)
            {
                MessageBox.Show( "please enter numbers only!!!","Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            switch (select)
            {

                case 0:
                    #region MidSquareRandomRegion
                    lblHeading.Content = "Mid-Square Random";
                    lblDescp.Text = "\r\nThe Mid-Square Random algorithm is a simple method for generating pseudo-random numbers. It involves repeatedly squaring a seed value and extracting the middle digits to produce the next random number. While easy to understand and implement, this method has limitations, including a potential for short periods and patterns in the generated sequence. For more robust and statistically reliable random number generation, especially in applications requiring high-quality randomness, more advanced algorithms are generally preferred.";
                    // Create a new instance of the MidSquareRandom class with a seed value
                    MidSquareRandom midRandomGenerator = new MidSquareRandom(1234);

                    // Generate and print 10 random numbers
                    for (int i = 0; i < Rounds; i++)
                    {
                        int randomNumber = midRandomGenerator.Next();
                        lst.Add(randomNumber);

                    }

                    #endregion
                    break;
                case 1:
                    #region LinearCongruentialRandomRegion
                    lblHeading.Content = "Linear Congruential Random";
                    lblDescp.Text = "Linear Congruential Generators (LCGs) generate pseudo-random numbers using a linear recurrence relation. The process involves a seed value, a multiplier, an increment, and a modulus. LCGs are straightforward but can exhibit limitations, such as short periods and patterns in sequences. They are suitable for basic applications, but for more advanced or cryptographic needs, more sophisticated generators are preferred.";
                    // Create a new instance of the LinearCongruentialRandom class with parameters
                    LinearCongruentialRandom linearRandomGenerator = new LinearCongruentialRandom(1234, 48271, 0, 2147483647);

                    // Generate and print 10 random numbers
                    for (int i = 0; i < Rounds; i++)
                    {
                        int randomNumber = linearRandomGenerator.Next();
                        lst.Add(randomNumber);
                    }

                    #endregion
                    break;
                case 2:
                    #region MultiplicativeCongruentialRandomRegion
                    lblHeading.Content = "Multiplicative Congruential Random";
                    lblDescp.Text = "The Multiplicative Congruential Random algorithm is a simple method for generating pseudo-random numbers. Here's a brief description:\r\nSeed Initialization: Start with an initial seed value (an integer).\r\nMultiplicative Recurrence Relation: Multiply the seed by a constant multiplier \r\na and take the result modulo \r\nm to obtain the next random number:\r\n\r\nXn+1=(a⋅Xn)modm\r\n\r\nUse as Next Seed: The result becomes the seed for the next iteration.";
                    // Create a new instance of the MultiplicativeCongruentialRandom class with parameters
                    MultiplicativeCongruentialRandom multiplicativeRandomGenerator = new MultiplicativeCongruentialRandom(1234, 48271, 2147483647);

                    // Generate and print 10 random numbers
                    for (int i = 0; i < Rounds; i++)
                    {
                        int randomNumber = multiplicativeRandomGenerator.Next();
                        lst.Add(randomNumber);
                    }

                    #endregion
                    break;
                case 3:
                    #region FibonacciRandomGeneratorRegion
                    FibonacciRandomGenerator randomGenerator = new FibonacciRandomGenerator();
                    lblHeading.Content = "Fibonacci Random Generator";
                    lblDescp.Text = "A Fibonacci Random Generator is a type of pseudo-random number generator that uses the Fibonacci sequence to generate a sequence of seemingly random numbers. Here's a simple description:\r\nSeed Initialization: Start with two initial seed values (integers), typically referred to as a and b.\r\nFibonacci Recurrence Relation: Generate the next random number by adding the two previous seeds:\r\n\r\nXn+1=Xn+Xn−1\r\n\r\nUpdate Seeds: Set the current \r\na to the previous \r\nb and the current \r\nb to the result.\r\nUse as Random Number: The result is the generated pseudo-random number.";
                    // Generate and print a sequence of random numbers
                    for (int i = 0; i < Rounds; i++)
                    {
                        int randomNumber = randomGenerator.Next();
                        lst.Add(randomNumber);
                    }
                    #endregion
                    break;
                case 4:
                    #region CombinedLCGRegion
                    int[] seeds = { 123, 456, 789, 321 };
                    CombinedLCG clcg = new CombinedLCG(seeds);
                    lblHeading.Content = "Combined LCG";
                    lblDescp.Text = "A Combined Linear Congruential Generator (CombinedLCG) is a type of pseudo-random number generator that combines multiple Linear Congruential Generators (LCGs) to generate a sequence of pseudo-random numbers. Here's a concise description:\r\n\r\nMultiple LCGs: Use several Linear Congruential Generators, each with its own set of parameters (multiplier a, increment c, and modulus m).\r\nParallel Generation: Run the LCGs in parallel to generate multiple pseudo-random sequences.\r\nCombine Results: Combine the results of individual LCGs, often through addition or bitwise operations.\r\nProduce Final Result: The combined result serves as the pseudo-random number.";
                    // Generate and print a sequence of random numbers
                    for (int i = 0; i < Rounds; i++)
                    {
                        int randomNumber = clcg.Next();
                        lst.Add(randomNumber);
                    }
                    #endregion
                    break;
                case 5:
                    #region Random-NumberStreamsRegion
                    // Create a random-number stream with a seed
                    Random random = new Random(42); // 42 is the seed
                    lblHeading.Content = "Random-Number Streams";
                    lblDescp.Text = "Random-number streams are sequences of pseudo-random numbers generated by a random number generator (RNG) with an initial seed. If you use the same seed, you get the same sequence, providing determinism for applications like simulations and games. Random-number streams find applications in various fields, and programming languages offer libraries for their generation.";
                    // Generate and print a sequence of random numbers
                    for (int i = 0; i < Rounds; i++)
                    {
                        int randomNumber = random.Next();
                        lst.Add(randomNumber);
                    }
                    #endregion
                    break;
                default:
                    lst.Add(0);
                    break;
            }
            lstvResult.Items.Clear();

            for (int i = 0; i < lst.Count; i++)
            {
                lstvResult.Items.Add(lst[i]);
            }

        }

        private void lstvResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}
    }
}
