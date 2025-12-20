using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;
using SchoolManagementApplicationDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationBAL
{
    public class EducatorDetailsBAL
    {
        IEducatorDetails edudet = new EducatorDetailsRepo();
        public List<EducatorDetailsADO> GetEducatorDetails()
        {
            List<EducatorDetailsADO> eduDetails = new List<EducatorDetailsADO>();
            eduDetails = edudet.getAllEducatorDetails();
            return eduDetails;
        }

        public List<EducatorDetailsForDropdownADO> GetEducatorDetailsForDropdown()
        {
            List<EducatorDetailsForDropdownADO> detEduDrpDwn = new List<EducatorDetailsForDropdownADO>();
            detEduDrpDwn = edudet.getEducatorDetailsForDropDown();
            return detEduDrpDwn;
        }

        public List<EducatorDetailsADO> GetEducatorDetailsByRegistrationId(int selectedEduRegId)
        {
            List<EducatorDetailsADO> detEdubyRegId = new List<EducatorDetailsADO>();
            detEdubyRegId = edudet.getEducatorDetailsByRegistrationId(selectedEduRegId);
            return detEdubyRegId;
        }

    }
}
