using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace StudentCGPACalculator.Core
{
    public class ChechResult
    {
        public static void WeightPtCalculation(List<GradeSheet> Grade)
        {
            int TotalWeightPoint = 0;
            foreach (GradeSheet _Grade in Grade)
            {
                if (_Grade.courseScore >= 70.0)
                {
                    TotalWeightPoint = _Grade.courseUnit * 5 + TotalWeightPoint;
                    _Grade.weightPt = _Grade.courseUnit * 5;
                    _Grade.grade = 'A';
                    _Grade.remark = "Excellent";
                    _Grade.gradeUnit = 5;
                }
                else if (_Grade.courseScore >= 60.0 && _Grade.courseScore <= 69.0)
                {
                    TotalWeightPoint = _Grade.courseUnit * 4 + TotalWeightPoint;
                    _Grade.weightPt = _Grade.courseUnit * 4;
                    _Grade.grade = 'B';
                    _Grade.remark = "Very Good";
                    _Grade.gradeUnit = 4;
                }
                else if (_Grade.courseScore >= 50.0 && _Grade.courseScore <= 59.0)
                {
                    TotalWeightPoint = _Grade.courseUnit * 3 + TotalWeightPoint;
                    _Grade.weightPt = _Grade.courseUnit * 3;
                    _Grade.grade = 'C';
                    _Grade.remark = "Good";
                    _Grade.gradeUnit = 3;
                }
                else if (_Grade.courseScore >= 45.0 && _Grade.courseScore <= 49.0)
                {
                    TotalWeightPoint = _Grade.courseUnit * 2 + TotalWeightPoint;
                    _Grade.weightPt = _Grade.courseUnit * 2;
                    _Grade.grade = 'D';
                    _Grade.remark = "Fair";
                    _Grade.gradeUnit = 2;
                }
                else if (_Grade.courseScore >= 40.0 && _Grade.courseScore <= 44.0)
                {
                    TotalWeightPoint = _Grade.courseUnit + TotalWeightPoint;
                    _Grade.weightPt = _Grade.courseUnit;
                    _Grade.grade = 'E';
                    _Grade.remark = "Pass";
                    _Grade.gradeUnit = 1;
                }
                else if (_Grade.courseScore >= 0.0 && _Grade.courseScore <= 39.0)
                {
                    int courseUnit1 = _Grade.courseUnit;
                    TotalWeightPoint = 0 + TotalWeightPoint;
                    GradeSheet _GradeB = _Grade;
                    int courseUnit2 = _Grade.courseUnit;
                    _GradeB.weightPt = 0;
                    _Grade.grade = 'F';
                    _Grade.remark = "Fail";
                    _Grade.gradeUnit = 0;
                }
            }
            ResultTable.print(Grade, TotalWeightPoint);
            PrintGPA.print(Grade, TotalWeightPoint);
        }
    }
}
