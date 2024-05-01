using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICETASK6
{
    public class Band
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int MemberCount { get; set; }
        public DateTime TimeSlot { get; set; }

        public Band(string name, string genre, int totalMembers, DateTime timeSlot)
        {
            Name = name;
            Genre = genre;
            MemberCount = totalMembers;
            TimeSlot = timeSlot;
        }
    }
}
