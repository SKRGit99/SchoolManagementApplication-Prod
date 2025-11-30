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
    public class StudentDetailsRepo:IStudentDetails
    {
        SqlConnection conObj = new SqlConnection("Server=LAPTOP-K1PVP9J6\\;Database=schoolmanagementdb;Integrated Security=True;");
        public List<StudentDetailsModel> GetStudentDetails()
        {
            List<StudentDetailsModel> lstStdDetails = new List<StudentDetailsModel>();


            SqlCommand cmd = new SqlCommand("getStudentDetails", conObj);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                StudentDetailsModel studentDet = new StudentDetailsModel();
                studentDet.student_registration_Id = Convert.ToInt32(dr["student_registration_Id"]);
                studentDet.student_name = dr["student_name"].ToString();
                studentDet.student_roll_number = Convert.ToInt32(dr["student_roll_number"]);
                studentDet.student_mobile_number = dr["student_mobile_number"].ToString();
                studentDet.student_class = Convert.ToInt32(dr["student_class"]);
                studentDet.student_section_name = dr["student_section_name"].ToString();
                studentDet.student_address = dr["student_address"].ToString();

                lstStdDetails.Add(studentDet);


            }

            return lstStdDetails;


        }

        public List<StudentDetailsForDropdown> GetStudentDetailsForDroDown()
        {
            List<StudentDetailsForDropdown> lsdDrpDwn = new List<StudentDetailsForDropdown>();
            SqlCommand cmd = new SqlCommand("getStudentDetails", conObj);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                StudentDetailsForDropdown studentDetailsByDropDown = new StudentDetailsForDropdown();
                studentDetailsByDropDown.student_registration_Id = Convert.ToInt32(dr["student_registration_id"]);
                studentDetailsByDropDown.student_name = dr["student_name"].ToString();


                lsdDrpDwn.Add(studentDetailsByDropDown);
            }
            return lsdDrpDwn;
        }
    }

    
}
