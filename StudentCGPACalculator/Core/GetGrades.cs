using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StudentCGPACalculator.Core
{
    public class GetGrades
    {
        private List<GradeSheet> students = new List<GradeSheet>();

        // INPUT VALIDATION
        public static int correctUnit()
        {
            int _Scores;
            while (true)
            {
                Console.Write("Enter Your Course Unit: ");
                if (int.TryParse(Console.ReadLine(), out _Scores))
                {
                    if (_Scores > 5)
                        Console.WriteLine("Invalid course unit: Your courses unit are less than 5");
                    else if (_Scores < 0)
                        Console.WriteLine("Invalid course unit: Can not have a negative course unit");
                    else
                        break;
                }
                else
                    Console.WriteLine("ERROR: Enter only numbers");
            }
            return _Scores;
        }

        //  SCORE VALIDATION
        public static double correctScore()
        {
            double _Scores;
            while (true)
            {
                Console.Write("Enter Your Correct Score: ");
                if (double.TryParse(Console.ReadLine(), out _Scores))
                {
                    if (_Scores > 100.0)
                        Console.WriteLine("This is not a valid score: Your examination score should be less than 100");
                    else if (_Scores < 0.0)
                        Console.WriteLine("Not a valid score: Cannot have a negative score input");
                    else
                        break;
                }
                else
                    Console.WriteLine("ERROR: Enter only numbers from 1 - 100");
            }
            return _Scores;
        }

        // NAME VALIDATION
        public static string correctCourseName()
        {
            bool Looping = true;
            string result;
            do
            {
                Console.Write("Enter Your Course Name and Code: ");
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result))
                    Console.WriteLine("ERROR: Course code must not be empty");
                else if (result.Length == 1)
                    Console.WriteLine("Invalid Course name: Enter a valid course code E.g MTH101");
                else if (result.Length == 2)
                    Console.WriteLine("Invalid Course name: Enter a valid course code E.g MTH101");
                else if (result.Length >= 3)
                {
                    if (!Regex.IsMatch(result, "^[a-zA-Z0-9]+$"))
                        Console.WriteLine("ERROR: Your Course and code should be alphaNumeric E.g GST222");
                    else
                        break;
                }
            }
            while (Looping);
            return result;
        }

        //  RESULTS CALCULATIONS
        public void inputCourse()
        {
            while (true)
            {
                Console.WriteLine("PLEASE ENTER YOUR EXAMINATION GRADES HERE: ");
                Console.WriteLine("NOTE: YOUR INPUTED COURSES MUST BE MORE THAN TWO FOR GPA CALCULATIONS");
                while (true)
                {
                    Console.WriteLine("Enter Grade details");
                    this.students.Add(new GradeSheet(GetGrades.correctCourseName(), GetGrades.correctUnit(), GetGrades.correctScore(), string.Empty, 0, char.MinValue, 0));
                    Console.WriteLine();
                    if (this.students.Count >= 2)
                    {
                        Console.WriteLine("Press \"Y\" for YES to get Calculation or Press enter to Add more results");
                        if (Console.ReadLine().ToLower() == "y")
                            break;
                    }
                }

                // PASSING STUDENT RESULT TO RESULT CALCULATOR CLASS
                ChechResult.WeightPtCalculation(this.students);

                // ASK FOR ANOTHER USER RESULT DETAILS
                Console.WriteLine();
                Console.WriteLine("Press \"Y\" for YES to Calculate another CGPA or press enter exit Program");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.Clear();
                    this.students.Clear();
                }
                else
                    break;
            }
        }
    }
}
