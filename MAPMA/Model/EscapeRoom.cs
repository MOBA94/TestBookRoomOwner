using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMA.Model
{
    class EscapeRoom
    {
        public List<string> checkList { get => checkList; set => checkList = value; }
        public string description { get => description; set => description = value; }
        public double maxClearTime { get => maxClearTime; set => maxClearTime = value; }
        public string name { get => name; set => name = value; }
        public double price { get => price; set => price = value; }
        public double rating { get => rating; set => rating = value; }
        public double cleanTime { get => cleanTime; set => cleanTime = value; }

        public EscapeRoom(string description, string name, double price) 
        {
            this.description = description;
            this.name = name;
            this.price = price;

            checkList = new List<string>();
        }

        public void AddToCheckList(string item)
        {
            checkList.Add(item);
        }
    }
}
