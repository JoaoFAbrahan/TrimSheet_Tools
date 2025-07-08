// 
using System.Drawing;
using Bunifu.UI.WinForms;

namespace TrimSheet_Tools.Model
{
    internal class TrimStrips
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public float HeightPercent { get; set; }
        public float TextDensity { get; set; }
        public Bunifu.UI.WinForms.BunifuShapes ShapeControl { get; set; }
    }
}
