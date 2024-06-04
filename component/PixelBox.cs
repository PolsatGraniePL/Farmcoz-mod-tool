using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmcoz_mod_tool.component
{
    class PixelBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            base.OnPaint(pe);
        }
    }
}
