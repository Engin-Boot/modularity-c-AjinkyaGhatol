using System;
using System.Drawing;
namespace TelCo.ColorCoder
{
     static public class ColorCodeData
    {
        static internal int manualMinSize;
        static string manualStart = "------------------------------------------------------------------------\n|Pair no.\t\t\t|Major color\t\t|Minor color\t\t|\n------------------------------------------------------------------------\n";

        /// <summary>
        /// Array of Major colors
        /// </summary>
        internal static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        internal static Color[] colorMapMinor;
        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static ColorCodeData()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
            manualMinSize = manualStart.Length;
        }
        public static string manualToString()
        {   string manual ="";
            manual += manualStart;
            int pairNumber = 1;
            int minorSize = ColorCodeData.colorMapMinor.Length;
            int majorSize = ColorCodeData.colorMapMajor.Length;
            for (int i = 1; i <= majorSize; i++)
            {
                for (int j = 1; j <= minorSize; j++)
                {
                    manual+= "|" + pairNumber.ToString() + "\t\t\t|" + colorMapMajor[i - 1].Name + "\t\t\t|" + colorMapMinor[j - 1].Name + "\t\t\t|\n";
                    pairNumber++;
                }
                manual = manual + "------------------------------------------------------------------------\n";
            }
            return manual;
        }
    }
}
