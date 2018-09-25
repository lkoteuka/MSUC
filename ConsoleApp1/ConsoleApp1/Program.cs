using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2018, 09, 13);
            Laboratory lab = new Laboratory("Lab", date);
            Equipment equipment1 = new Equipment("EQ1", 2010, "000");
            Equipment equipment2 = new Equipment("EQ2", 2010, "001");
            Equipment equipment3 = new Equipment("EQ3", 2010, "002");
            Equipment equipment4 = new Equipment("EQ4", 2010, "019");

            Equipment equipment5 = new Equipment("EQ4", 2010, "003");
            Equipment equipment6 = new Equipment("EQ5", 2010, "004");
            Equipment equipment7 = new Equipment("EQ6", 2010, "005");

            lab.AddEquipments(new Computer(equipment1, ComputerType.Desktop, 1),
                new Computer(equipment2, ComputerType.Notebook, 4),
                new Computer(equipment3, ComputerType.Workstation, 1),
                new Computer(equipment4, ComputerType.Workstation, 2),
                new Printer(equipment5, PrinterType.Laser, false),
                new Printer(equipment6, PrinterType.Ink, true),
                new Printer(equipment7, PrinterType.Laser, true));

            System.Console.Write(lab.ToString());

            Console.WriteLine();

            foreach (Equipment c in lab)
                Console.WriteLine(c + " ");

            Console.WriteLine();

            foreach (Equipment c in lab.MyItr())
                Console.WriteLine(c + " ");
        }
    }
}
