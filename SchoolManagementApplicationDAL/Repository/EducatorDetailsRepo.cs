using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Repository
{
    public class EducatorDetailsRepo: IEducatorDetails
    {
        SqlConnection conObj = new SqlConnection("Server=LAPTOP-K1PVP9J6\\;Database=SchoolManagementAppDevDb;Integrated Security=True;");
        public List<EducatorDetailsADO> getAllEducatorDetails()
        {
            List<EducatorDetailsADO> lstEduDetails = new List<EducatorDetailsADO>();

            SqlCommand cmd = new SqlCommand("getEducatorDetails", conObj);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                EducatorDetailsADO eduDet = new EducatorDetailsADO();
                eduDet.educator_registration_Id = Convert.ToInt32(dr["RegistrationId"]);
                eduDet.educator_name = dr["educatorName"].ToString();
                eduDet.educator_department = dr["educatorDepartment"].ToString();
                eduDet.class_assigned = dr["classAssigned"].ToString();
                eduDet.section_assigned = Convert.ToChar(dr["sectionAssigned"]);
                eduDet.subject_assigned = (dr["subjectAssigned"]).ToString();
                eduDet.address = dr["educatorAddress"].ToString();
                eduDet.mobile_number = dr["mobileNumber"].ToString();
                

                lstEduDetails.Add(eduDet);


            }

            return lstEduDetails;


        }

        public List<EducatorDetailsForDropdownADO> getEducatorDetailsForDropDown()
        {
            List<EducatorDetailsForDropdownADO> lstEduDrpDwn = new List<EducatorDetailsForDropdownADO>();
            SqlCommand cmd = new SqlCommand("getEducatorDetails", conObj);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                EducatorDetailsForDropdownADO educatorDetailsByDropDown = new EducatorDetailsForDropdownADO();
                educatorDetailsByDropDown.educator_registration_Id = Convert.ToInt32(dr["RegistrationId"]);
                educatorDetailsByDropDown.educator_name = dr["educatorName"].ToString();


                lstEduDrpDwn.Add(educatorDetailsByDropDown);
            }
            return lstEduDrpDwn;
        }

        public List<EducatorDetailsADO> getEducatorDetailsByRegistrationId(int registrationId)
        {
            List<EducatorDetailsADO> lstEduDetailsbyRegId = new List<EducatorDetailsADO>();

            SqlCommand cmd = new SqlCommand("getEducatorDetailsByRegId", conObj);
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
                EducatorDetailsADO EduDetails = new EducatorDetailsADO();
                EduDetails.educator_registration_Id = Convert.ToInt32(dr["RegistrationId"]);
                EduDetails.educator_name = dr["educatorName"].ToString();
                EduDetails.educator_department = dr["educatorDepartment"].ToString();
                EduDetails.class_assigned = dr["classAssigned"].ToString();
                EduDetails.section_assigned = Convert.ToChar(dr["sectionAssigned"]);
                EduDetails.subject_assigned = (dr["subjectAssigned"]).ToString();
                EduDetails.address = dr["educatorAddress"].ToString();
                EduDetails.mobile_number = dr["mobileNumber"].ToString();
                lstEduDetailsbyRegId.Add(EduDetails);


            }

            return lstEduDetailsbyRegId;
        }


    }
}
