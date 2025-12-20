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
        public int educator_class_assigned { get; set; }
        public int educator_section_assigned { get; set; }
        public string educator_subject_assigned { get; set; }
        public string educator_mobile_number { get; set; }
        public string educator_address { get; set; }
    }

    public class EducatorDetailsForDropdownADO
    {
        [Key]
        public int educator_registration_Id { get; set; }
        public string educator_name { get; set; }
    }
}
