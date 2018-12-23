using SlipPrinter.Model;
using SlipPrinter.Printing;
using SlipPrinter.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlipPrinter
{
    public class PrintProcess
    {
        public static void Process(string[] args)
        {
            var data = new QrCodeModel()
            {
                QrCode = args[0],
                Left = float.Parse(args[1] == "" ? "0" : args[1] ?? "0"),
                Top = float.Parse(args[2] == "" ? "0" : args[2] ?? "0"),
                Width = float.Parse(args[3] == "" ? "0" : args[3] ?? "0"),
                Height = float.Parse(args[4] == "" ? "0" : args[4] ?? "0"),
            };

            var printing = new PrintingDoc()
            {
                Template = new PrintTemplate001()
                {
                    Data = data,
                },
            };
            printing.Print();

        }
    }
}
