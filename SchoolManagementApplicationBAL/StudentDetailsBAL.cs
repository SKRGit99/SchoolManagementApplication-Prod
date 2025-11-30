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
        IStudentInfo stdet = new StudentInfoRepo();
        public List<StudentInfoADO> GetStudentDetails()
        {
            List<StudentInfoADO> detStudent = new List<StudentInfoADO>();
            detStudent = stdet.fetchStudentInfo();
            return detStudent;
        }

        public List<StudentsInfoForDropdownADO> GetStudentDetailsForDropdown()
        {
            List<StudentsInfoForDropdownADO> detStudentDrpDwn = new List<StudentsInfoForDropdownADO>();
            detStudentDrpDwn = stdet.fetchStudentInfoForDropDown();
            return detStudentDrpDwn;
        }

    }
}
