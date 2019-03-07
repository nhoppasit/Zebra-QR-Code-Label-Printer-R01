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
            g.PageUnit = GraphicsUnit.Millimeter;

            var logoWidth = Data.Width;
            var logoHeight = Data.Height;
            var logoLeftMargin = Data.Left;
            var logoTopMargin = Data.Top;

            g.DrawString(Data.TopText, null, Brushes.Black, logoLeftMargin, logoTopMargin);
            g.DrawImage(Bitmap.FromFile(string.Format(@"C:\QR\{0}.jpg", Data.QrCode)), logoLeftMargin, logoTopMargin, logoWidth, logoHeight);
            g.DrawString(Data.TopText, null, Brushes.Black, logoLeftMargin, logoTopMargin + logoHeight);

        }
    }
}
