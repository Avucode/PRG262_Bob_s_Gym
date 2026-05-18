using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG262_Bob_s_Gym.Models
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int FailedAttempts { get; set; } = 0;
        public bool IsLocked { get; set; } = false;

        public string Status => IsLocked ? "LOCKED" : "Active";

        public User() { }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        //public string GetUsername(string username)
        //{
        //    return this.Username = username;
        //}
    }
}
