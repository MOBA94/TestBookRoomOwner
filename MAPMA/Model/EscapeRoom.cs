using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMA.Model
{
    public class EscapeRoom
    {
        public int EscapeRoomID {
            get; set;
        }

        
        public string Name {
            get; set;
        }
        
        public decimal Price {
            get; set;
        }
        
        public decimal Rating {
            get; set;
        }
        
        public decimal CleanTime {
            get; set;
        }
        
        public decimal MaxClearTime {
            get; set;
        }
        
        public List<string> CheckList {
            get; set;
        }


        public string Description {
            get; set;
        }
        
        public Employee Emp {
            get; set;
        }

        public EscapeRoom(int escapeRoomID, string name, decimal price, decimal cleanTime, decimal maxClearTime, string description) {
            this.EscapeRoomID = escapeRoomID;
            this.Name = name;
            this.Price = price;
            this.CleanTime = cleanTime;
            this.MaxClearTime = maxClearTime;
            this.Description = description;
            CheckList = new List<string>();
        }
        public EscapeRoom(string name, decimal price, decimal cleanTime, decimal maxClearTime, string description) {
            this.Name = name;
            this.Price = price;
            this.CleanTime = cleanTime;
            this.MaxClearTime = maxClearTime;
            this.Description = description;
            CheckList = new List<string>();
        }

        public EscapeRoom() {
            CheckList = new List<string>();
        }

        public void AddToList(string item) {
            CheckList.Add(item);
        }

    }
}
