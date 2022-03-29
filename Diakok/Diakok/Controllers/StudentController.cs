using Diakok.Models;
using Diakok.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Diakok.Controllers
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
            return studentService.GetAllStudent();
        }
        [HttpGet]
        [Route("{id}")]
        public Student GetAllStudents(int id)
        {
            return studentService.GetStudentByEmail(id);
        }
    }
}
