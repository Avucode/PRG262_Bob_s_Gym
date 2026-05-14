using PRG262_Bob_s_Gym.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG262_Bob_s_Gym.DataAccess
{
    public class ClassDAO
    {
        public int AddClass(GymClass gymClass)
        {
            SqlParameter[] paramters =
            {
                new SqlParameter("@ClassName", gymClass.ClassName),
                new SqlParameter("@Description", gymClass.Desc),
                new SqlParameter("@Instructor", gymClass.Instructor),
                new SqlParameter("@Schedule", gymClass.Schedule),
                new SqlParameter("@Capacity", gymClass.Capacity),
                new SqlParameter("@Duration", gymClass.Duration)
            };
            object result = DBHelper.ExecuteScalarVal("sp_CreateClass", CommandType.StoredProcedure, paramters);
            return Convert.ToInt32(result);
        }

        public DataTable GetAllClasses()
        {
            return DBHelper.ExecDataTable("sp_GetAllClasses", CommandType.StoredProcedure);

        }

        public bool UpdateClass(GymClass gymClass)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@ClassID", gymClass.ClassID),
                new SqlParameter("@ClassName", gymClass.ClassName),
                new SqlParameter("@Description", gymClass.Desc),
                new SqlParameter("@Instructor", gymClass.Instructor),
                new SqlParameter("@Schedule", gymClass.Schedule),
                new SqlParameter("@Capacity", gymClass.Capacity),
                new SqlParameter("@Duration", gymClass.Duration)
            };

            int rowsAffected = DBHelper.ExecuteNonQ("sp_UpdateClass", CommandType.StoredProcedure, parameters);

            return rowsAffected > 0;

        }

        public bool DeleteClass(int classID)
        {
            SqlParameter[] parameter = { new SqlParameter("@ClassID", classID) };
            int rowsAffected = DBHelper.ExecuteNonQ("sp_DeleteClass", CommandType.StoredProcedure, parameter);
            return rowsAffected > 0;
        }
    }
}
