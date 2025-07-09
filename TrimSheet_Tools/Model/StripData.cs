// Trim sheet strip data class
using System;
using System.Drawing;
using Bunifu.UI.WinForms;

namespace TrimSheet_Tools.Model
{
    public class StripData
    {
        public BunifuShapes StripShape { get; set; }
        public Color StripColor { get; set; }
        public String StripName { get; set; }
        public float StripSize { get; set; }


        public Bitmap GetBitmap()
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(StripColor);
                g.DrawRectangle(Pens.Gray, 0, 0, bmp.Width - 1, bmp.Height - 1);
            }

            return bmp;
        }
    }
}
