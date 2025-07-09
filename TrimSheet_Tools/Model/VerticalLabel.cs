// Label class with possibility of vertical positioning
using System.Drawing;
using System.Windows.Forms;

namespace TrimSheet_Tools.Model
{
    public class VerticalLabel : System.Windows.Forms.Label
    {
        public bool DrawVertically { get; set; } = false;

        protected override void OnPaint(PaintEventArgs e)
        {
            if (DrawVertically)
            {
                e.Graphics.TranslateTransform(0, this.Height);
                e.Graphics.RotateTransform(-90);

                using (SolidBrush brush = new SolidBrush(this.ForeColor))
                using (StringFormat format = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                })
                {
                    e.Graphics.DrawString(this.Text, this.Font, brush,
                        new RectangleF(0, 0, this.Height, this.Width), format);
                }
            }
            else
            {
                base.OnPaint(e);
            }
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            if (DrawVertically)
            {
                Size baseSize = base.GetPreferredSize(proposedSize);
                return new Size(baseSize.Height, baseSize.Width);
            }
            return base.GetPreferredSize(proposedSize);
        }
    }
}
