using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Resident
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int dormNum { get; set; }
        public int fee { get; set; }
        public  int floorNum { get; set; }

        public Resident(int id, string firstName, string lastName, int dormNum, int fee, int floorNum)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dormNum = dormNum;
            this.fee = fee;
            this.floorNum = floorNum;
        }

        public override string ToString()
        {
            return String.Format($"Welcome, {firstName} {lastName}, Dorm Number: {dormNum}, Fee: {fee}, Floor Number: {floorNum}");
        }

    }
}
