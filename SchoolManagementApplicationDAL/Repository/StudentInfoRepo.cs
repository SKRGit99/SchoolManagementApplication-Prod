using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApplicationDAL.Abstract;

namespace SchoolManagementApplicationDAL.Repository
{
    /*Repository: Functionality of Data */
    public class StudentInfoRepo : IStudentInfo
    {
        SqlConnection conObj = new SqlConnection("Server=LAPTOP-K1PVP9J6\\;Database=SchoolManagementAppDevDb;Integrated Security=True;");
        public List<StudentInfoADO> fetchStudentInfo()
        {
            List<StudentInfoADO> lstStdDetails = new List<StudentInfoADO>();

            SqlCommand cmd = new SqlCommand("fetchStudentDetails", conObj);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                StudentInfoADO studentDet = new StudentInfoADO();
                studentDet.student_registration_Id = Convert.ToInt32(dr["student_registration_Id"]);
                studentDet.student_name = dr["student_name"].ToString();
                studentDet.roll_number = Convert.ToInt32(dr["student_roll_number"]);
                studentDet.mobile_number = dr["student_mobile_number"].ToString();
                studentDet.student_class = Convert.ToInt32(dr["student_class"]);
                studentDet.student_section_Id = Convert.ToInt32(dr["student_section_Id"]);
                studentDet.student_address = dr["student_address"].ToString();
                studentDet.guardian_name = dr["student_Guardian_name"].ToString();
                lstStdDetails.Add(studentDet);


            }

            return lstStdDetails;


        }

        public List<StudentsInfoForDropdownADO> fetchStudentInfoForDropDown()
        {
            List<StudentsInfoForDropdownADO> lsdDrpDwn = new List<StudentsInfoForDropdownADO>();
            SqlCommand cmd = new SqlCommand("fetchStudentDetails", conObj);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                StudentsInfoForDropdownADO studentDetailsByDropDown = new StudentsInfoForDropdownADO();
                studentDetailsByDropDown.student_registration_Id = Convert.ToInt32(dr["student_registration_id"]);
                studentDetailsByDropDown.student_name = dr["student_name"].ToString();


                lsdDrpDwn.Add(studentDetailsByDropDown);
            }
            return lsdDrpDwn;
        }

        public List<StudentInfoADO> fetchStudentInfoByRegistrationId(int registrationId)
        {
            List<StudentInfoADO> lstStdDetailsbyRegId = new List<StudentInfoADO>();

            SqlCommand cmd = new SqlCommand("fetchStudentDetailsByRegId", conObj);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter
            {
                ParameterName = "@registrationId", //Parameter name defined in stored procedure
                SqlDbType = SqlDbType.Int, //Data Type of Parameter
                Value = registrationId, //Value passes to the paramtere
                Direction = ParameterDirection.Input //Specify the parameter as input
            };
            //Add the parameter to the Parameters property of SqlCommand object
            cmd.Parameters.Add(param1);
            conObj.Open();

            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                StudentInfoADO studentDet = new StudentInfoADO();
                studentDet.student_registration_Id = Convert.ToInt32(dr["student_registration_Id"]);
                studentDet.student_name = dr["student_name"].ToString();
                studentDet.roll_number = Convert.ToInt32(dr["student_roll_number"]);
                studentDet.mobile_number = dr["student_mobile_number"].ToString();
                studentDet.student_class = Convert.ToInt32(dr["student_class"]);
                studentDet.student_section_Id = Convert.ToInt32(dr["student_section_Id"]);
                studentDet.student_address = dr["student_address"].ToString();
                studentDet.guardian_name = dr["student_Guardian_name"].ToString();
                lstStdDetailsbyRegId.Add(studentDet);


            }

            return lstStdDetailsbyRegId;
        }

    }


}
