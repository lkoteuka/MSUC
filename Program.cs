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
            Equipment equipment2 = new Equipment("EQ1", 2010, "000");
            Equipment equipment4 = new Equipment("EQ2", 2010, "001");
            Equipment equipment3 = null;

            lab.AddEquipments(equipment1, equipment4);

            System.Console.Write(lab.ToString());

            System.Console.WriteLine(equipment1 == equipment2);
            System.Console.WriteLine(equipment3 == equipment2);
            System.Console.WriteLine(equipment3 == null);

            lab.RemoveEquipmentAt(1);
            System.Console.Write(lab.ToString());
        }
    }
}
