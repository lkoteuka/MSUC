using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum ComputerType : int { Desktop, Notebook, Workstation };

    class Computer: Equipment
    { 
        public ComputerType type { get; set; }
        public int cores { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + type + " " + cores;
        }

        public Computer(Equipment p, ComputerType type, int cores) : base(p.name, p.year, p.number)
        {
            this.type = type;
            this.cores = cores;
        }
    }
}
