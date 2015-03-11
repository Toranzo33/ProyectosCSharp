using System;

public class GradeBook
{
    public void DisplayMessage(string courseName)
    {
        Console.WriteLine("Welcome to the Grade Book for\n {0}!", courseName);
    }
}
  public class GradeBookTest
    {
      public static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook();
            Console.WriteLine("Please enter the code name:");
            string nameOfCourse = Console.ReadLine();
            Console.WriteLine();
            myGradeBook.DisplayMessage(nameOfCourse);
        }
    }

