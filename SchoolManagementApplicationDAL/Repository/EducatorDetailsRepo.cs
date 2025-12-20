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
                eduDet.educator_registration_Id = Convert.ToInt32(dr["educator_registration_Id"]);
                eduDet.educator_name = dr["educator_name"].ToString();
                eduDet.educator_class_assigned = Convert.ToInt32(dr["educator_class_assigned"]);
                eduDet.educator_section_assigned = Convert.ToInt32(dr["educator_section_assigned"]);
                eduDet.educator_subject_assigned = (dr["educator_subject_assigned"]).ToString();
                eduDet.educator_mobile_number = dr["educator_mobile_number"].ToString();
                eduDet.educator_address = dr["educator_address"].ToString();

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
                educatorDetailsByDropDown.educator_registration_Id = Convert.ToInt32(dr["educator_registration_Id"]);
                educatorDetailsByDropDown.educator_name = dr["educator_name"].ToString();


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
                EduDetails.educator_registration_Id = Convert.ToInt32(dr["educator_registration_Id"]);
                EduDetails.educator_name = dr["educator_name"].ToString();
                EduDetails.educator_class_assigned = Convert.ToInt32(dr["educator_class_assigned"]);
                EduDetails.educator_section_assigned = Convert.ToInt32(dr["educator_section_assigned"]);
                EduDetails.educator_subject_assigned = dr["educator_subject_assigned"].ToString();
                EduDetails.educator_mobile_number = dr["educator_mobile_number"].ToString();
                EduDetails.educator_address = dr["educator_address"].ToString();
                lstEduDetailsbyRegId.Add(EduDetails);


            }

            return lstEduDetailsbyRegId;
        }


    }
}
