using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksManager
{
    class ExamMark
    {
        public string StudentNumber { get; private set; }
        public string SubjectCode { get; private set; }
        public double Percentage { get; private set; }

        public ExamMark(string StudentNumber, string SubjectCode, double Percentage)
        {
            this.StudentNumber = StudentNumber;
            this.SubjectCode = SubjectCode;
            this.Percentage = Percentage;
        }
    }
}
