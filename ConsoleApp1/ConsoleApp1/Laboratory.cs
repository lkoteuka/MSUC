using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Laboratory
    {
        private string nameLab;
        private DateTime date;
        private List<Equipment> listEq = new List<Equipment>();

        public Laboratory(string name, DateTime date)
        {
            this.nameLab = name;
            this.date = date;
        }

        public override string ToString()
        {
            string toString = this.ToShortString() + ":\n";
            for (int i = 0; i < listEq.Count; i++)
            {
                toString += "       " + listEq[i].ToString() + '\n';
            }
            return toString;
        }

        public string ToShortString()
        {
            return nameLab + " " + date.ToString();
        }

        public void AddEquipments(params Equipment[] equipments)
        {
            bool flag = true;
            for(int i = 0; i < equipments.Length; i++)
            {
                if(object.ReferenceEquals(equipments[i], null))
                {
                    System.Console.WriteLine("Попытка добавить null в список Equipments");
                    continue;
                }
                for(int j = 0; j < listEq.Count; j++)
                {
                    if(listEq[j].Equals(equipments[i]))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    listEq.Add(equipments[i]);
                    flag = true;
                }
            }
        }

        public void RemoveEquipmentAt(int index)
        {
            if (index >= listEq.Count) return;
            listEq.RemoveAt(index);
        }
    }
}
