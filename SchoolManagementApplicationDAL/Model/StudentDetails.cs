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
        public int registration_Id { get; set; }
        public string student_name { get; set; }
        public int roll_number { get; set; }
        public int student_class { get; set; }
        public char section { get; set; }
        public string address { get; set; }
        public string mobile_number { get; set; }
        
      

    }

    public class StudentsDetailsForDropdownADO
    {
        public int registration_Id { get; set; }
        public string student_name { get; set; }
    }


}
