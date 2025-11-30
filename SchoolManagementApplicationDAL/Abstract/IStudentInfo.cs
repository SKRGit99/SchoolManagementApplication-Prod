using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Abstract
{
    public interface IStudentInfo
    {
        public List<StudentInfoADO> fetchStudentInfo();
        public List<StudentsInfoForDropdownADO> fetchStudentInfoForDropDown();


    }
}
