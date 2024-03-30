using AdaptersPrintAndPaint.Devices;
using System;

namespace AdaptersPrintAndPaint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var drawer1 = new ImageDrawer();
            
            var epson = new PaperPrinter("epson");
            drawer1.DrawWith(epson);
            drawer1.TextForPrint = "New promo message!!!";
            drawer1.DrawWith(epson);

            Console.WriteLine();
            var drawer2 = new ImageDrawer();
            drawer2.TextForPrint = "What God has placed on her soul...";

            var ele = new CanvasPainter();
            IPrinter eleAsPrinter = new PainterToPrintAdapter(ele);
            drawer2.DrawWith(eleAsPrinter);
        }
    }
}
