// Trim sheet strip data class
using System;
using System.Drawing;
using Bunifu.UI.WinForms;

namespace TrimSheet_Tools.Model
{
    public class StripData
    {
        // Public Variables
        public BunifuShapes StripShape { get; set; }
        public Color StripColor { get; set; }
        public String StripName { get; set; }
        public Vector2D StripSize { get; set; }
        public float StripDensity { get; set; }

        // Internal
        private bool _stripSplited = false;


        // Methods
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

        public void Split()
        { _stripSplited = true; }
        public void Unspli()
        { _stripSplited = false; }
        public bool CheckSplit()
        { return _stripSplited; }
    }
}
