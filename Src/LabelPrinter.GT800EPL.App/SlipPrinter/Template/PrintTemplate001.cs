using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FontStyle = System.Drawing.FontStyle;

namespace SlipPrinter.Template
{
    public class PrintTemplate001 : IPrintTemplate
    {
        public override void Print(System.Drawing.Rectangle bound, System.Drawing.Graphics g)
        {
            bound.Width = 280;

            var logoWidth = 50;
            var logoHeight = 30;
            var logoLeftMargin = 4.5f;
            var logoTopMargin = 5;

            g.PageUnit = GraphicsUnit.Millimeter;
            g.DrawImage(Bitmap.FromFile(string.Format(@"C:\QR\{0}.jpg", Data.Partner)), logoLeftMargin, logoTopMargin, logoWidth, logoHeight);

        }
    }
}
