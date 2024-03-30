using AdaptersPrintAndPaint.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersPrintAndPaint
{
    public class PainterToPrintAdapter : IPrinter
    {
        public string Name { get; }
        IPainter _painter = new CanvasPainter();

        public PainterToPrintAdapter(IPainter painter)
        {
            _painter = painter;
        }

        public void Print()
        {
            _painter.Paint();
        }

    }
}
