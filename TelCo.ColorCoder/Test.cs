using System.Drawing;
using System.Diagnostics;
namespace TelCo.ColorCoder
{
    static class Test
    {
        internal static void TestByColorCode(ColorPair pair,Color major_color, Color minor_color)
        {
            Debug.Assert(pair.majorColor == major_color);
            Debug.Assert(pair.minorColor == minor_color);
        }
        internal static void TestByPairNumber(ColorPair pair, int actual_number)
        {
            int pairNumber_calulated;
            pairNumber_calulated = GetMethods.GetPairNumberFromColor(pair);
            Debug.Assert(pairNumber_calulated == actual_number);
        }
    }
}
