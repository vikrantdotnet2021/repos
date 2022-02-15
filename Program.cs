// write a program to calculate the grade.
using System; // System is a namespace

public class GradeComputation
{
    // Main method which starts the program execution.
    public static void Main()
    {
        string[] studentId = { "STU01", "STU02", "STU03", "STU04", "STU05" };
        int[] marks = { 76, 83, 92, 65, 34 };
        Console.WriteLine("Finds the grade for each student");
        for (int i = 0; i < studentId.Length; i++)
        {
            if (marks[i] > 90)
            {
                Console.WriteLine(studentId[i] + " Grade: " + "A");
            }
            else if (marks[i] > 80)
            {
                Console.WriteLine(studentId[i] + " Grade: " + "B");
            }
            else if (marks[i] > 70)
            {
                Console.WriteLine(studentId[i] + " Grade: " + "C");
            }
            else if (marks[i] > 50)
            {
                Console.WriteLine(studentId[i] + " Grade: " + "D");
            }
            else
            {
                Console.WriteLine(studentId[i] + " Grade: " + "FAIL");
            }
        }
        Console.ReadKey();
    }
}


