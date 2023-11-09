using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_exam.Model
{
    public class SubjectModel
    {
        // Основні властивості предмету
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }

       
        public int Credits { get; set; } // кількість кредитів, присвоєних предмету

        // Конструктор класу
        public SubjectModel(int subjectId, string subjectName, string description)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            Description = description;
        }
    }

}
