using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksManager
{
    class Program
    {
        static void Main(string[] args)
        {

            MarksManager singleton = MarksManager.GetInstance();
            MarksManager second = MarksManager.GetInstance();

            singleton.CaptureMark(new ExamMark("123", "IRUD301", 80));
            second.CaptureMark(new ExamMark("111", "IMOB301", 70));

            singleton.Calculation(true);
            Console.WriteLine(second.CalculateStudent("111"));

            Console.ReadLine();
        }
    }
}
