using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdaptersPrintAndPaint.Devices
{
    public class PaperPrinter : IPrinter
    {
        public string Name { get; private set; }

        public PaperPrinter(string name)
        {
            Name = name;
        }

        public void Print() 
        {
            Print("");
        }

        public void Print(string text)
        {
            text = string.IsNullOrEmpty(text) ? "test page" : text;
            Console.WriteLine($"{Name} prints {text}");
        }
    }
}
