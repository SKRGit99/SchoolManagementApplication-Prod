using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Abstract
{
    public interface IStudentDetails
    {
        public List<StudentDetailsModel> GetStudentDetails();
        public List<StudentDetailsForDropdown> GetStudentDetailsForDroDown();


    }
}
