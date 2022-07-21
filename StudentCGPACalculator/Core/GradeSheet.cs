using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCGPACalculator.Core
{
    public class GradeSheet
    {
        public string courseCode { get; set; }

        public int courseUnit { get; set; }

        public double courseScore { get; set; }

        public string remark { get; set; }

        public int weightPt { get; set; }

        public char grade { get; set; }

        public int gradeUnit { get; set; }

        public GradeSheet(
          string courseCode,
          int courseUnit,
          double courseScore,
          string remark,
          int weightPt,
          char grade,
          int gradeUnit)
        {
            this.courseCode = courseCode;
            this.courseUnit = courseUnit;
            this.courseScore = courseScore;
            this.remark = remark;
            this.weightPt = weightPt;
            this.grade = grade;
            this.gradeUnit = gradeUnit;
        }
    }
}
