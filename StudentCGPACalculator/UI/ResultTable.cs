using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCGPACalculator.Core
{
    public class ResultTable
    {
        public static void print(List<GradeSheet> Grade, int TotalWeightPoint)
        {
            Console.WriteLine("|--------------|------------|------|-----------|-----------|----------------|");
            Console.WriteLine("|COURSE & CODE |COURSE UNIT |GRADE |GRADE-UNIT |WEIGHT Pt. |REMARK          |");
            Console.WriteLine("|--------------|------------|------|-----------|-----------|----------------|");
            foreach (GradeSheet _Grade in Grade)
                Console.WriteLine("|{0,-14}|{1,-12}|{2,-6}|{3,-11}|{4,-11}|{5,-16}|", (object)_Grade.courseCode, (object)_Grade.courseUnit, (object)_Grade.grade, (object)_Grade.gradeUnit, (object)_Grade.weightPt, (object)_Grade.remark);
            Console.WriteLine("|--------------|------------|------|-----------|-----------|----------------|");
        }
    }
}
