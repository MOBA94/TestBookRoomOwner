using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPMAClient.Model {
    /// <summary>
    /// <author>
    /// Mick O. B. Andersen
    /// Anders S. Brygger
    /// Peter S. Clausen
    /// Anders B. Larsen
    /// Mads G. Ranzau
    /// </author>
    /// </summary>
    public class EscapeRoom 
        {
        /// <summary>
        /// Get and set for EscapeRoomID
        /// </summary>
        public int EscapeRoomID {
            get; set;
        }

        /// <summary>
        /// Get and set for Name
        /// </summary>
        public string Name {
            get; set;
        }

        /// <summary>
        /// Get and set for Price
        /// </summary>
        public decimal Price {
            get; set;
        }

        /// <summary>
        /// Get and set for Rating
        /// </summary>
        public decimal Rating {
            get; set;
        }

        /// <summary>
        /// Get and set for CleanTime
        /// </summary>
        public decimal CleanTime {
            get; set;
        }

        /// <summary>
        /// Get and set for MacClearTime
        /// </summary>
        public decimal MaxClearTime {
            get; set;
        }

        /// <summary>
        /// Get and set for ChechList
        /// </summary>
        public List<string> CheckList {
            get; set;
        }

        /// <summary>
        /// Get and set for Description
        /// </summary>
        public string Description {
            get; set;
        }

        /// <summary>
        /// Get and set for Employee
        /// </summary>
        public Employee Emp {
            get; set;
        }

        /// <summary>
        /// Get and set for AvalibleTimes
        /// </summary>
        public List<TimeSpan> AvalibleTimes {
            get; set;
        }

        /// <summary>
        /// Get and set for Image
        /// </summary>
        public byte[] Image {
            get; set;
        }

        /// <summary>
        /// Constructor for EscapeRoom with the following parameters
        /// + Checklist with AvalibleTimes
        /// </summary>
        /// <param name="escapeRoomID"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="cleanTime"></param>
        /// <param name="maxClearTime"></param>
        /// <param name="description"></param>
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

        /// <summary>
        /// Constructor for EscapeRoom with the following parameters
        /// + Checklist with AvalibleTimes
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="cleanTime"></param>
        /// <param name="maxClearTime"></param>
        /// <param name="description"></param>
        public EscapeRoom(string name, decimal price, decimal cleanTime, decimal maxClearTime, string description) {
            this.Name = name;
            this.Price = price;
            this.CleanTime = cleanTime;
            this.MaxClearTime = maxClearTime;
            this.Description = description;
            CheckList = new List<string>();
            this.AvalibleTimes = AddTimesToList();
        }

        /// <summary>
        /// EscapeRoom only with CheckList of AvalibleTimes
        /// </summary>
        public EscapeRoom() {
            CheckList = new List<string>();
            this.AvalibleTimes = AddTimesToList();
        }

        /// <summary>
        /// Method to add "item" to list
        /// </summary>
        /// <param name="item"></param>
        public void AddToList(string item) {
            CheckList.Add(item);
        }

        /// <summary>
        /// Adds the avalible times to a list
        /// </summary>
        /// <returns></returns>
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
