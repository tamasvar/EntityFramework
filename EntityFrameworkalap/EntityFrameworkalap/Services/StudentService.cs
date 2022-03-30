
using EntityFrameworkalap.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkalap.Services
{
    public class StudentService
    {
        private readonly kkszkiContext context;

        public StudentService(kkszkiContext context)
        {
            this.context = context;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            
            return context.Students.Include(Student => Student.Subjects).Include(Student => Student.Grades).ToList();
        }

        public Student GetStudentByEmail(string email)
        {
            return context.Students.First(Student => Student.Email == email);
        }
        
    }
}
