using System;
using System.Drawing;

namespace Programming.Model
{
    public static class AppColors
    {
        public static System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        public static System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        public static System.Drawing.Color IsCollision = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        public static System.Drawing.Color IsNotCollision = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        public static System.Drawing.Color Spring = ColorTranslator.FromHtml("#559c45");

        public static System.Drawing.Color Autumn = ColorTranslator.FromHtml("#e29c45");
    }
}
