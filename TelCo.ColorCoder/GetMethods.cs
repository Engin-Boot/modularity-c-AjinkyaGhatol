using System;
namespace TelCo.ColorCoder
{
    class GetMethods
    { 
        internal static ColorPair GetColorFromPairNumber(int pairNumber)
        {   int minorSize = ColorCodeData.colorMapMinor.Length;
            int majorSize = ColorCodeData.colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
            ColorPair pair = new ColorPair()
            {
                majorColor = ColorCodeData.colorMapMajor[majorIndex],
                minorColor = ColorCodeData.colorMapMinor[minorIndex]
            };
            return pair;
        }
        internal static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < ColorCodeData.colorMapMajor.Length; i++)
            {
                if (ColorCodeData.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            int minorIndex = -1;
            for (int i = 0; i < ColorCodeData.colorMapMinor.Length; i++)
            {
                if (ColorCodeData.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * ColorCodeData.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}