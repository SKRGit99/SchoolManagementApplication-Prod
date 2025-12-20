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
    public class StudentDetailsRepo : IStudentDetails
    {
        SqlConnection conObj = new SqlConnection("Server=LAPTOP-K1PVP9J6\\;Database=SchoolManagementAppDevDb;Integrated Security=True;");
        public List<StudentDetailsADO> getAllStudentDetails()
        {
            List<StudentDetailsADO> lstStdDetails = new List<StudentDetailsADO>();

            SqlCommand cmd = new SqlCommand("getStudentDetails", conObj);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                StudentDetailsADO studentDet = new StudentDetailsADO();
                studentDet.registration_Id = Convert.ToInt32(dr["RegistrationId"]);
                studentDet.student_name = dr["studentName"].ToString();
                studentDet.roll_number = Convert.ToInt32(dr["rollNumber"]);
                studentDet.student_class = Convert.ToInt32(dr["studentClass"]);
                studentDet.section = Convert.ToChar(dr["studentSection"]);
                studentDet.address = dr["studentAddress"].ToString();
                studentDet.mobile_number = dr["studentMobileNumber"].ToString();
                lstStdDetails.Add(studentDet);


            }

            return lstStdDetails;


        }

        public List<StudentsDetailsForDropdownADO> getStudentDetailsForDropDown()
        {
            List<StudentsDetailsForDropdownADO> lstStdDrpDwn = new List<StudentsDetailsForDropdownADO>();
            SqlCommand cmd = new SqlCommand("getStudentDetails", conObj);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                StudentsDetailsForDropdownADO studentDetailsByDropDown = new StudentsDetailsForDropdownADO();
                studentDetailsByDropDown.registration_Id = Convert.ToInt32(dr["RegistrationId"]);
                studentDetailsByDropDown.student_name = dr["studentName"].ToString();


                lstStdDrpDwn.Add(studentDetailsByDropDown);
            }
            return lstStdDrpDwn;
        }

        public List<StudentDetailsADO> getStudentDetailsByRegistrationId(int registrationId)
        {
            List<StudentDetailsADO> lstStdDetailsbyRegId = new List<StudentDetailsADO>();

            SqlCommand cmd = new SqlCommand("getStudentDetailsByRegId", conObj);
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
                StudentDetailsADO studentDetByRegId = new StudentDetailsADO();
                studentDetByRegId.registration_Id = Convert.ToInt32(dr["RegistrationId"]);
                studentDetByRegId.student_name = dr["studentName"].ToString();
                studentDetByRegId.roll_number = Convert.ToInt32(dr["rollNumber"]);
                studentDetByRegId.student_class = Convert.ToInt32(dr["studentClass"]);
                studentDetByRegId.section = Convert.ToChar(dr["studentSection"]);
                studentDetByRegId.address = dr["studentAddress"].ToString();
                studentDetByRegId.mobile_number = dr["studentMobileNumber"].ToString();
                lstStdDetailsbyRegId.Add(studentDetByRegId);


            }

            return lstStdDetailsbyRegId;
        }

    }


}
