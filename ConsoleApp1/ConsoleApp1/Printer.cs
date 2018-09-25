using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum PrinterType : int { Laser, Ink };

    class Printer:Equipment
    {
        public PrinterType type { get; set; }
        public bool color { get; set; }

        public Printer(Equipment p, PrinterType t, bool c):base(p.name, p.year, p.number)
        {
            type = t;
            color = c;
        }

        public override string ToString()
        {
            return base.ToString() + " " + type + " " + color;
        }
    }
}
