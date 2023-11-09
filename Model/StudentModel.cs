using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_exam.Model
{
   
        public class StudentModel
        {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string StudentCode { get; set; }

            public List<string> Courses { get; set; } // список курсів

            public StudentModel(int studentId, string firstName, string lastName, string email, string studentCode)
            {
                StudentId = studentId;
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                StudentCode = studentCode;
            }
        }
}
