using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG262_Bob_s_Gym.Classes
{
    public class GymClass
    {

        public int ClassID { get; set; }

        public string ClassName { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public string Instructor { get; set; } = string.Empty;
        public string Schedule { get; set; } = string.Empty;

        public int Capacity { get; set; }
        public int Duration { get; set; }


        public GymClass()
        {

        }

        public GymClass(string className, string desc, string instructor,
            string schedule, int cap, int duration) {
            this.ClassName = className;
            this.Desc = desc;
            this.Instructor = instructor;
            this.Schedule = schedule;
            this.Duration = duration;
        }

    }
}
