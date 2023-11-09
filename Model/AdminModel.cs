using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_exam.Model
{
    public class AdminModel
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string AdminRole { get; set; } // роль адміна в системі (наприклад, "Системний адміністратор")

        // Конструктор класу
        public AdminModel(int adminId, string firstName, string lastName, string email)
        {
            AdminId = adminId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }

}
