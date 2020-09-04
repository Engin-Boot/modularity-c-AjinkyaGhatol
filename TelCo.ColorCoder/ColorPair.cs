using System.Drawing;
namespace TelCo.ColorCoder
{
    class ColorPair
    {
        internal Color majorColor;
        internal Color minorColor;
        internal ColorPair(){ }
        internal ColorPair(int number){
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
    }
}
