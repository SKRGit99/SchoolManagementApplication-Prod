using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Abstract
{
    public interface IEducatorDetails
    {
        public List<EducatorDetailsADO> getAllEducatorDetails();
        public List<EducatorDetailsForDropdownADO> getEducatorDetailsForDropDown();
        public List<EducatorDetailsADO> getEducatorDetailsByRegistrationId(int registrationId);
    }
}
