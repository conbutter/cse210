using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Harmond Row", "Economics Fundamentals");
        assignment1.GetSummary();

        MathAssignment assignment2 = new MathAssignment("Ben Anderson", "Math in the Real World II", "3.4", "4-5");
        assignment2.GetSummary();
        assignment2.GetHomeworkList();

        WritingAssignment assignment3 = new WritingAssignment("Carter Buttermeld", "Writing Fundamentals Final", "Modern Data Protection in the Modern Web");
        assignment3.GetSummary();
        assignment3.GetWritingInformation();
    }
}