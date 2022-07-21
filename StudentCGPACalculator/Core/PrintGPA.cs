using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCGPACalculator.Core
{
    public class PrintGPA
    {
        public static void print(List<GradeSheet> Grade, int TotalWeightPoint)
        {
            int One = 0;
            foreach (GradeSheet _Grade in Grade)
                One += _Grade.courseUnit;
            int CaseTwo = 0;
            foreach (GradeSheet _Grade in Grade)
                CaseTwo += _Grade.gradeUnit;
            Console.WriteLine();
            Console.WriteLine("Total Course Unit Registered is " + One.ToString());
            Console.WriteLine("Total Course Unit Passed is " + CaseTwo.ToString());
            Console.WriteLine("Total Weight Point is " + TotalWeightPoint.ToString());
            Console.WriteLine("Your GPA is = " + string.Format("{0:0.##}", (object)((double)TotalWeightPoint / (double)One)));
        }
    }
}
