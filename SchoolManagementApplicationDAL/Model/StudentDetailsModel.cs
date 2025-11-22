using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolManagementApplicationDAL.Model
{
    public class StudentDetailsModel
    {
        public int student_registration_Id { get; set; }
        public string? student_name { get; set; }
        public int student_roll_number { get; set; }
        public string? student_mobile_number { get; set; }
        public int student_class { get; set; }
        public string? student_section_name { get; set; }
        public string? student_address { get; set; }

        

    }

    public class StudentDetailsForDropdown
    {
        public int student_registration_Id { get; set; }
        public string? student_name { get; set; }
    }


}
