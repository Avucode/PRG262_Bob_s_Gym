using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG262_Bob_s_Gym.Classes;
namespace PRG262_Bob_s_Gym.DataAccess
{

    /// <summary>
    /// Methods to Create/Read/Update/Delete users on the DB.
    /// </summary>
    public class MemberDAO
    {
        /// <summary>
        /// Used to create a member.
        /// </summary>
        /// <returns>the result as an int</returns>
        public int AddMember(Member member)
        {
            SqlParameter[] parameter = {
                new SqlParameter("@FirstName", member.FirstName),
                new SqlParameter("@LastName", member.LastName),
                new SqlParameter("@DateOfBirth", member.DOB),
                new SqlParameter("@Gender", member.Gender),
                new SqlParameter("@PhoneNumber", member.PhoneNumber),
                new SqlParameter("@Address", member.Address),
                new SqlParameter("@TrainingProgram", member.TrainingProgram),
                new SqlParameter("@MembershipStartDate", member.MembershipStartDate),
                new SqlParameter("@MembershipEndDate", member.MembershipEndDate),
            };

            object result = DBHelper.ExecuteScalarVal("sp_CreateMember", CommandType.StoredProcedure, parameter);
            return Convert.ToInt32(result);
        }

        public DataTable GetAllMembers(int memberID)
        {
            SqlParameter[] parameter = { new SqlParameter("@MemberID", memberID) };
            return DBHelper.ExecDataTable("sp_GetMemberByID", CommandType.StoredProcedure, parameter);
        }

        /// <summary>
        /// Updates the data table 
        /// 
        /// </summary>
        /// 
        public bool UpdateMember(Member member)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MemberID", member.MemberID),
                new SqlParameter("@FirstName", member.FirstName),
                new SqlParameter("@LastName", member.LastName),
                new SqlParameter("@DateOFBirth", member.DOB),
                new SqlParameter("@Gender", member.Gender),
                new SqlParameter("@PhonNumber", member.PhoneNumber),
                new SqlParameter("@Address", member.Address),
                new SqlParameter("@TrainingProgram", member.TrainingProgram),
                new SqlParameter("@MembershipStartDate", member.MembershipStartDate),
                new SqlParameter("@MembershipEndDate", member.MembershipEndDate),
            };
            int rowsAffected = DBHelper.ExecuteNonQ("sp_UpdateMember", CommandType.StoredProcedure, parameters);

            return rowsAffected > 0;

        }

        public DataTable SearchMembers(string searchTerm)
        {
            SqlParameter[] parameter = { new SqlParameter("@SearchTerm", searchTerm ?? "") };
            return DBHelper.ExecDataTable("sp_SearchMembers", CommandType.StoredProcedure, parameter);
        }
    }
}
