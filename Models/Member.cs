using System;

namespace PRG262_Bob_s_Gym
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string TrainingProgram { get; set; } = string.Empty;

        public DateTime MembershipStartDate { get; set; }
        public DateTime MembershipEndDate { get; set; }

        // Helper property for displaying fullname (useful in grids)
        public string FullName => $"{FirstName} {LastName}";

        public Member() { }

        // Optional for quick creation
        public Member(string firstName, string lastName, DateTime dob, string gender,
            string phone, string address, string program, DateTime startDate, DateTime endDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DOB = dob;
            this.Gender = gender;
            this.PhoneNumber = phone;
            this.Address = address;
            this.TrainingProgram = program;
            this.MembershipStartDate = startDate;
            this.MembershipEndDate = endDate;
        }


    }
}