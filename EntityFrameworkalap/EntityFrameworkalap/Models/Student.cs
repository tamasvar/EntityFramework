using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace EntityFrameworkalap.Models
{
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string StudentName { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
