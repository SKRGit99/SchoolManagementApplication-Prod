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
    public class StudentDetailsAccess
    {
       IStudentDetails stdet = new StudentDetailsRepo();
        public List<StudentDetailsModel> GetStudentDetails()
        {
            List<StudentDetailsModel> detStudent = new List<StudentDetailsModel>();
            detStudent = stdet.GetStudentDetails();
            return detStudent;
        }

        public List<StudentDetailsForDropdown> GetStudentDetailsForDropdown()
        {
            List<StudentDetailsForDropdown> detStudentDrpDwn = new List<StudentDetailsForDropdown>();
            detStudentDrpDwn = stdet.GetStudentDetailsForDroDown();
            return detStudentDrpDwn;
        }

    }
}
