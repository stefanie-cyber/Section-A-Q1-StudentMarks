using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_A_Q1_StudentMarks
{
    internal class Program
    {
        private static object studentName;

        static void Main(string[] args)
        {
       Console.Write("Enter student name:");
          string STUDENTNAME = Console.ReadLine();

          int mark1 = ReadMark("Enter mark for subject 1: ");
           int mark2 = ReadMark("Enter mark for subject 2: ");
          int mark3 = ReadMark("Enter mark for subject 3: ");

            int totalMarks = mark1 + mark2 + mark3;
            double averageMarks = totalMarks / 3.0;

                string result = averageMarks >= 50 ? "PASS" : "FAIL";

           Console.WriteLine();
            Console.WriteLine("==== STUDENT RESULTS ====");
           Console.WriteLine($"Student Name: {studentName}");
           Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Average Marks: {averageMarks:F1}".Replace('.', '.'));
           Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Result Issued At: {DateTime.Now:dd MMM yyyy HH:mm:ss}");
          Console.WriteLine();
            Console.WriteLine("Press any Key to exit...");
        }
        static int ReadMark(string prompt)
        {
            int mark;
           Console.Write(prompt);

          while (!int.TryParse(Console.ReadLine(), out mark))
        {
               Console.Write("Invalid input. Please enter a number value: ");
            }
           return mark;


        }
    }
}
