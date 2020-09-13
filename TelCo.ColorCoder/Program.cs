using System;
using System.Drawing;
namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int pairNumber = 4;
            ColorPair testPair1 = new ColorPair(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Test.TestByColorCode(testPair1,Color.White, Color.Brown);
            
            pairNumber = 5;
            testPair1.changeByNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Test.TestByColorCode(testPair1,Color.White, Color.SlateGray);
            
            pairNumber = 23;
            testPair1.changeByNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Test.TestByColorCode(testPair1,Color.Violet, Color.Green);

            ColorPair testPair2 = new ColorPair(Color.Yellow, Color.Green);
            pairNumber = GetMethods.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Test.TestByPairNumber(testPair2,18);

            testPair2.changeByColor(Color.Red, Color.Blue);
            pairNumber = GetMethods.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Test.TestByPairNumber(testPair2,6);

            string manual = ColorCodeData.manualToString();
            Console.WriteLine(manual);
        }
    }
}