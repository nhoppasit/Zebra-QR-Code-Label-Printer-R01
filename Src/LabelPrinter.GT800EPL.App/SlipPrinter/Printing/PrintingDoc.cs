using SlipPrinter.Model;
using SlipPrinter.Template;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SlipPrinter.Printing
{
    public class PrintingDoc : PrintDocument
    {
        public IPrintTemplate Template
        {
            get;
            set;
        }

        protected void SetPageControl(UserControl pageControl)
        {
            DefaultPageSettings.Landscape = false;
            DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            e.Graphics.SmoothingMode = SmoothingMode.None;
            e.Graphics.InterpolationMode = InterpolationMode.Low;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.None;

            Template.Print(e.MarginBounds, e.Graphics);
            
            e.Graphics.Dispose();
            GC.Collect();
        }
    }
}
