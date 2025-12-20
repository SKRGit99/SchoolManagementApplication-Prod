using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;
using SchoolManagementApplicationDAL.Repository;

namespace SchoolManagementApplicationBAL
{
    public class StudentDetailsBAL
    {
        IStudentDetails stdet = new StudentDetailsRepo();
        public List<StudentDetailsADO> GetStudentDetails()
        {
            List<StudentDetailsADO> detStudent = new List<StudentDetailsADO>();
            detStudent = stdet.getAllStudentDetails();
            return detStudent;
        }

        public List<StudentsDetailsForDropdownADO> GetStudentDetailsForDropdown()
        {
            List<StudentsDetailsForDropdownADO> detStudentDrpDwn = new List<StudentsDetailsForDropdownADO>();
            detStudentDrpDwn = stdet.getStudentDetailsForDropDown();
            return detStudentDrpDwn;
        }

        public List<StudentDetailsADO> GetStudentDetailsByRegistrationId(int selectedStudentRegId)
        {
            List<StudentDetailsADO> detStudentbyRegId = new List<StudentDetailsADO>();
            detStudentbyRegId = stdet.getStudentDetailsByRegistrationId(selectedStudentRegId);
            return detStudentbyRegId;
        }

    }
}
