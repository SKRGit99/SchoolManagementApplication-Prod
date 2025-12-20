using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Model
{
    public class EducatorDetailsADO
    {
        [Key]
        public int educator_registration_Id { get; set; }
        public string educator_name { get; set; }
        public string educator_department {  get; set; }
        public string class_assigned { get; set; }
        public char section_assigned { get; set; }
        public string subject_assigned { get; set; }
        public string mobile_number { get; set; }
        public string address { get; set; }
    }

    public class EducatorDetailsForDropdownADO
    {
        [Key]
        public int educator_registration_Id { get; set; }
        public string educator_name { get; set; }
    }
}
