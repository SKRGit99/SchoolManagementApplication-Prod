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
        [HttpGet]
        public IActionResult GetStudentDetails()
        {
            StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();
            List<StudentInfoADO> studentDetails = new List<StudentInfoADO>();


            studentDetails = studentDetailsBusiness.GetStudentDetails();

            /*This code is for grtting dropdown details*/
            List<StudentsInfoForDropdownADO> student = new List<StudentsInfoForDropdownADO>();
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
            List<StudentsInfoForDropdownADO> studentDetailsForDrpDwn = new List<StudentsInfoForDropdownADO>();
            studentDetailsForDrpDwn = studentDetailsBusiness.GetStudentDetailsForDropdown();
            ViewBag.studentList = new SelectList(studentDetailsForDrpDwn, "student_registration_Id", "student_name");
            /*code for grtting dropdown details ends*/

            return View();
        }



        [HttpPost]
        public JsonResult GetStudentDetailsByRegistrationId(string value)
        {
            StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();
            List<StudentInfoADO> studentDetails = new List<StudentInfoADO>();


            studentDetails = studentDetailsBusiness.GetStudentDetailsByRegistrationId(Convert.ToInt32(value));

            return Json(studentDetails);
        }


    }
}
