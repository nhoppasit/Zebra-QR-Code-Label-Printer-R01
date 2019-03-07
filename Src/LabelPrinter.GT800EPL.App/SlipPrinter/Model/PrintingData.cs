using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipPrinter.Model
{
    public class PrintingData
    {
        public string Partner { get; set; }
        public string Promotion { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string Cost { get; set; }
        public string RemainingScore { get; set; }
    }

    public class QrCodeModel
    {
        public string QrCode { get; set; }
        public string TopText { get; set; }
        public string BottomText { get; set; }
        public float Left { get; set; }
        public float Top { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }        
    }
}
