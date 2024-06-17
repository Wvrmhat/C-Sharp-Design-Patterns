using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksManager
{
    sealed class MarksManager
    {
        private static volatile MarksManager _instance;
        private static readonly object _lock = new object();

        private bool CalculateMode = false;
        private List<ExamMark> Marks = new List<ExamMark>();

        private MarksManager()
        {

        }

        public static MarksManager GetInstance()
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new MarksManager();
                    }
                }
            }
            return _instance;

        }

        public void Calculation(bool Target)
        {
            this.CalculateMode = Target;
        }

        public void CaptureMark(ExamMark Target)
        {
            if(!CalculateMode)          // meaning its false
            {
                Marks.Add(Target);
            }
        }

        public double CalculateStudent(string StudentNumber)
        {
            double Average = -1;

            if(CalculateMode == true)
            {
                double total = 0;
                int count = 0;

                foreach(ExamMark current in Marks)
                {
                    if(current.StudentNumber == StudentNumber)
                    {
                        total += current.Percentage;
                        count++;
                    }
                }

                Average = total / count;
            }
            return Average;
        }
    }
}
