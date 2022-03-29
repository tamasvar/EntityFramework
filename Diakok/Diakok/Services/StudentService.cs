using Diakok.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Diakok.Services
{
    public class StudentService
    {
        private readonly kkszkiContext context;

        public StudentService(kkszkiContext context) { 
            this.context = context;
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return context.Students.Include(student=> student.Subjects).ToList();
        }
        public Student GetStudentByEmail(int id)
        {
            return context.Students.Include(s => s.Subjects).First(s=>s.Id == id);
        }
    }
}
