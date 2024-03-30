using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersPrintAndPaint.Devices
{
    public interface IPainter
    {
        /// <summary>
        /// Интерфейс устройства, печатающего на холсте
        /// </summary>
        public void Paint()
        {
            Console.WriteLine("Базовое рисование интерфейса");
        }

        public void Paint(string text)
        {
            text = string.IsNullOrEmpty(text) ? "<no parameter>" : text;
            Console.WriteLine($"Interface painting with parameter {text}");
        }
    }
}
