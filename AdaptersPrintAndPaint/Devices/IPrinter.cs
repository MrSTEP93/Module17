using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersPrintAndPaint.Devices
{
    public interface IPrinter
    {
        /// <summary>
        /// Интерфейс принтера
        /// </summary>
        
        public string Name { get; }

        public void Print()
        {
            Console.WriteLine("Базовая печать интерфейса");
        }

        public void Print(string text) 
        {
            text = string.IsNullOrEmpty(text) ? "<no parameter>" : text;
            Console.WriteLine($"печать интерфейса with parameter {text}");
        }
    }
}
