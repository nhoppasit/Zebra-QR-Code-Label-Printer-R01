using SlipPrinter.Model;
using SlipPrinter.Printing;
using SlipPrinter.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlipPrinter
{
    public  class PrintProcess
    {
        public static void Process(string[] args)
        {
           
            var language = (args[3] ?? "").ToLower();
            var data = new PrintingData()
            {
                Partner = args[0],
                Promotion = args[1],
                Description = args[2],
                Username = args[3],
                RemainingScore = args[4],
            };

            var printing = new PrintingDoc()
            {
                Template = new PrintTemplate001()
                {
                    Data = data,
                    Language = language
                },
            };
            printing.Print();

        }
    }
}
