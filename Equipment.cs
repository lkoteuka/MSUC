using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Equipment
    {
        private string name { get; set; }
        private int year { get; set; }
        private string number { get; set; }

        public Equipment(string name, int d, string number)
        {
            this.name = name;
            this.year = d;
            this.number = number;
        }

        public override bool Equals(object obj)
        {
            return (name == (obj as Equipment).name) &&
                (year == (obj as Equipment).year) &&
                (number == (obj as Equipment).number);
        }

        public override string ToString()
        {
            return name + " " + year + " " + number;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator==(Equipment obj1, object obj2)
        {
            if (object.ReferenceEquals(obj1, null))
            {
                return object.ReferenceEquals(obj2, null);
            }

            return obj1.Equals(obj2);
        }

        public static bool operator!=(Equipment obj1, object obj2)
        {
            if (object.ReferenceEquals(obj1, null))
            {
                return !object.ReferenceEquals(obj2, null);
            }

            return !(obj1.Equals(obj2));
        }
    }
}
