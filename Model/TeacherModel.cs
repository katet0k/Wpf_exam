using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_exam.Model
{
        public class TeacherModel
        {
            public int TeacherId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Department { get; set; }

            public List<string> CoursesTaught { get; set; } // список курсів, які викладач веде

            public TeacherModel(int teacherId, string firstName, string lastName, string email, string department)
            {
                TeacherId = teacherId;
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                Department = department;
            }
        }

    
}
