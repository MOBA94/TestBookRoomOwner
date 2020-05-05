using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Model
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
        

        public List<TimeSpan> AvalibleTimes {
            get; set;
        }

        public byte[] Image {
            get; set;
        }

        public EscapeRoom(int escapeRoomID, string name, decimal price, decimal cleanTime, decimal maxClearTime, string description) {
            this.EscapeRoomID = EscapeRoomID;
            this.Name = name;
            this.Price = price;
            this.CleanTime = cleanTime;
            this.MaxClearTime = maxClearTime;
            this.Description = description;
            CheckList = new List<string>();
            this.AvalibleTimes = AddTimesToList();
        }
        public EscapeRoom(string name, decimal price, decimal cleanTime, decimal maxClearTime, string description) {
            this.Name = name;
            this.Price = price;
            this.CleanTime = cleanTime;
            this.MaxClearTime = maxClearTime;
            this.Description = description;
            CheckList = new List<string>();
            this.AvalibleTimes = AddTimesToList();
        }

        public EscapeRoom() {
            CheckList = new List<string>();
            this.AvalibleTimes = AddTimesToList();
        }

        public void AddToList(string item) {
            CheckList.Add(item);
        }

        public List<TimeSpan> AddTimesToList() {
            TimeSpan time1, time2, time3, time4, time5;
            time1 = new TimeSpan(16, 00, 00);
            time2 = new TimeSpan(18, 00, 00);
            time3 = new TimeSpan(20, 00, 00);
            time4 = new TimeSpan(22, 00, 00);
            time5 = new TimeSpan(00, 00, 00);

            List<TimeSpan> TimeList = new List<TimeSpan>() { time1, time2, time3, time4, time5 };

            return TimeList;


        }

    }
}
