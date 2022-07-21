using System;
using StudentCGPACalculator.Core;

Console.WriteLine("WELCOME TO STUDENT GPA CALCULATION");
Console.WriteLine();

//DISPLAYING GRADING SYSTEM TO USER
Console.WriteLine("GRADING SYSTEM: ");
Console.WriteLine("SCORE     | GRADE  | GRADE UNIT  | REMARKS");
Console.WriteLine("==================================================");
Console.WriteLine("70 - 100  |  A     |  5          | EXCELLENT");
Console.WriteLine("60 - 69   |  B     |  4          | Very Good");
Console.WriteLine("50 - 59   |  C     |  3          | Good");
Console.WriteLine("45 - 49   |  D     |  2          | Fair");
Console.WriteLine("40 - 44   |  E     |  1          | Pass");
Console.WriteLine(" 0 - 39   |  F     |  0          | Fail");
Console.WriteLine("==================================================");
new GetGrades().inputCourse();