using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolManagementApplicationDAL.Model
{
    /*Model: Structure of Data */
    public class StudentDetailsADO
    {
        public int student_registration_Id { get; set; }
        public string? student_name { get; set; }
        public int roll_number { get; set; }
        public string? mobile_number { get; set; }
        public int student_class { get; set; }
        public int student_section_Id { get; set; }
        public string? student_address { get; set; }
        public string? guardian_name { get; set; }

    }

    public class StudentsDetailsForDropdownADO
    {
        public int student_registration_Id { get; set; }
        public string? student_name { get; set; }
    }


}
