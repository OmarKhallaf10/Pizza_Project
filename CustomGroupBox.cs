using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public class CustomGroupBox : GroupBox
    {
        private Color _borderColor = Color.Black;

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate(); // Causes control to be redrawn
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Draw your custom border
            int borderWidth = 1; // Set the width of the border here
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, _borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    _borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    _borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    _borderColor, borderWidth, ButtonBorderStyle.Solid);
        }
    }

}
