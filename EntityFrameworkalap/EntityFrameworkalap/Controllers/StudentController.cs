
using EntityFrameworkalap.Models;
using EntityFrameworkalap.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EntityFrameworkalap.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly StudentService studentService;

        public StudentController(StudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public IEnumerable<Student> GetAllStudents()
        {
            return studentService.GetAllStudents();
        }


        [HttpGet]
        [Route("{email}")]

        public Student GetAllStudents(string email)
        {
            return studentService.GetStudentByEmail(email);
        }
    }
}
