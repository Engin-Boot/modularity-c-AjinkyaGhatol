using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;
namespace TelCo.ColorCoder
{
    /// <summary>
    /// data type defined to hold the two colors of clor pair
    /// </summary>
    class ColorPair
    {
        internal Color majorColor;
        internal Color minorColor;
        internal ColorPair()
        { }
        internal ColorPair(int number)
        {
            ColorPair temp=ColorCodeData.GetColorFromPairNumber(number);
            this.majorColor = temp.majorColor;
            this.minorColor = temp.minorColor;
        }
        internal ColorPair(Color major_color,Color minor_color)
        {
            
            this.majorColor = major_color;
            this.minorColor = minor_color;
        }
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
        internal void changeByNumber(int pairNumber)
        {
            ColorPair temp = ColorCodeData.GetColorFromPairNumber(pairNumber);
            this.majorColor = temp.majorColor;
            this.minorColor = temp.minorColor;
        }
        internal void changeByColor(Color major_color,Color minor_color)
        {
            this.majorColor = major_color;
            this.minorColor = minor_color;
        }
        internal void TestColorCode(Color major_color, Color minor_color)
        {
            Debug.Assert(majorColor == major_color);
            Debug.Assert(minorColor == minor_color);
        }
        internal void TestPairNumber(int actual_number)
        {
            int pairNumber_calulated;
            pairNumber_calulated = ColorCodeData.GetPairNumberFromColor(this);
            Debug.Assert(pairNumber_calulated == actual_number);
        }
    }
}
