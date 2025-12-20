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
        public List<StudentDetailsADO> getAllStudentDetails();

        public List<StudentsDetailsForDropdownADO> getStudentDetailsForDropDown();
        public List<StudentDetailsADO> getStudentDetailsByRegistrationId(int registrationId);


    }
}
