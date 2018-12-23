using SlipPrinter.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipPrinter.Template
{
    public abstract class IPrintTemplate
    {
        public QrCodeModel Data { get; set; }
        public abstract void Print(Rectangle bound, Graphics g);
    }
}
