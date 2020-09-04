using System;
using System.Drawing;
namespace TelCo.ColorCoder
{
     static internal class ColorCodeData
    {
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
        }
        
    }
}
