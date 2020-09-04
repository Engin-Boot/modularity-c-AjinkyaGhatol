using System.Drawing;
using System.Diagnostics;
namespace TelCo.ColorCoder
{
    static class Test
    {
        internal static void TestColorCode(ColorPair pair,Color major_color, Color minor_color)
        {
            Debug.Assert(pair.majorColor == major_color);
            Debug.Assert(pair.minorColor == minor_color);
        }
        internal static void TestPairNumber(ColorPair pair, int actual_number)
        {
            int pairNumber_calulated;
            pairNumber_calulated = ColorCodeData.GetPairNumberFromColor(pair);
            Debug.Assert(pairNumber_calulated == actual_number);
        }
    }
}
