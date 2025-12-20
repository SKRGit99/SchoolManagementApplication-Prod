using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol;
using SchoolManagementApplicationBAL;
using SchoolManagementApplicationDAL;
using SchoolManagementApplicationDAL.Model;

namespace SchoolManagementApplication.Controllers
{
    public class AdminController : Controller
    {
       
        public IActionResult GetStudentDetails()
        {
            StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();
            List<StudentDetailsADO> studentDetails = new List<StudentDetailsADO>();


            studentDetails = studentDetailsBusiness.GetStudentDetails();

            /*This code is for grtting dropdown details*/
            List<StudentsDetailsForDropdownADO> student = new List<StudentsDetailsForDropdownADO>();
            student = studentDetailsBusiness.GetStudentDetailsForDropdown();
            ViewBag.studentList = new SelectList(student, "student_registration_Id", "student_name");
            /*code for grtting dropdown details ends*/

            return View(studentDetails);
        }


        [HttpGet]
        public IActionResult GetStudentDetailsByRegistrationId()
        {
            StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();

            /*This code is for getting dropdown details*/
            List<StudentsDetailsForDropdownADO> studentDetailsForDrpDwn = new List<StudentsDetailsForDropdownADO>();
            studentDetailsForDrpDwn = studentDetailsBusiness.GetStudentDetailsForDropdown();
            ViewBag.studentList = new SelectList(studentDetailsForDrpDwn, "student_registration_Id", "student_name");
            /*code for grtting dropdown details ends*/

            return View();
        }



        [HttpPost]
        public JsonResult GetStudentDetailsByRegistrationId(string value)
        {
            StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();
            List<StudentDetailsADO> studentDetails = new List<StudentDetailsADO>();


            studentDetails = studentDetailsBusiness.GetStudentDetailsByRegistrationId(Convert.ToInt32(value));

            return Json(studentDetails);
        }

        public IActionResult GetEducatorDetails()
        {
            EducatorDetailsBAL educatorDetailsBusiness = new EducatorDetailsBAL();
            List<EducatorDetailsADO> educatorDetails = new List<EducatorDetailsADO>();


            educatorDetails = educatorDetailsBusiness.GetEducatorDetails();

            /*This code is for grtting dropdown details*/
            List<EducatorDetailsForDropdownADO> educatorDetDrpDwn = new List<EducatorDetailsForDropdownADO>();
            educatorDetDrpDwn = educatorDetailsBusiness.GetEducatorDetailsForDropdown();
            ViewBag.studentList = new SelectList("educator", "educator_registration_Id", "educator_name");
            /*code for grtting dropdown details ends*/

            return View(educatorDetails);
        }

        [HttpGet]
        public IActionResult GetEducatorDetailsByRegistrationId()
        {
            EducatorDetailsBAL eduDetailsBAL = new EducatorDetailsBAL();

            /*This code is for grtting dropdown details*/
            List<EducatorDetailsForDropdownADO> educatorDetDrpDwn = new List<EducatorDetailsForDropdownADO>();
            educatorDetDrpDwn = eduDetailsBAL.GetEducatorDetailsForDropdown();
            ViewBag.EducatorList = new SelectList(educatorDetDrpDwn, "educator_registration_Id", "educator_name");
            /*code for grtting dropdown details ends*/

            return View();
        }

        [HttpPost]
        public JsonResult GetEducatorDetailsByRegistrationId(string value)
        {
            EducatorDetailsBAL eduDetailsDrpDwnBAL = new EducatorDetailsBAL();
            List<EducatorDetailsADO> educatDetails = new List<EducatorDetailsADO>();


            educatDetails = eduDetailsDrpDwnBAL.GetEducatorDetailsByRegistrationId(Convert.ToInt32(value));

            return Json(educatDetails);
        }

    }
}
