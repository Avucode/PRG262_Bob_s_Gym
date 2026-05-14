using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PRG262_Bob_s_Gym.DataAccess;

namespace PRG262_Bob_s_Gym
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            Application.Run(form);
            DateTime dt = form.dtp;

            // this is an example

            var newMember = new Member
            {
                FirstName = "Han",
                LastName = "Solo",
                DOB = dt,
                Gender = "Male",
                PhoneNumber = "0603311234",          // Keep as string
                Address = "3 Dingo Drive",
                TrainingProgram = "Weights",
                MembershipStartDate = dt,
                MembershipEndDate = dt
            };

            MemberDAO mdao = new MemberDAO();
            int newMemberID = mdao.AddMember(newMember);
            MessageBox.Show($"New member added successfully: {newMemberID}");
        }
    }
}
