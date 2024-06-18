using System;

// initialize variables - graded assignments 
int examAssignments = 5;
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

int[] sophia = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrew = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emma = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] logan = new int[] { 90, 95, 87, 88, 96, 96 };
int[] becky = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chris = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] eric = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregor = new int[] { 91, 91, 91, 91, 91, 91, 91 }; 

Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\tExtra Credit\n");

foreach(string currentName in studentNames) 
{
  string currentStudent = currentName;

  if(currentStudent == "Sophia") 
    studentScores = sophia;
  else if(currentStudent == "Andrew") 
    studentScores = andrew;
  else if(currentStudent == "Emma") 
    studentScores = emma;
  else if(currentStudent == "Logan") 
    studentScores = logan;
  else if (currentStudent == "Becky")
    studentScores = becky;
  else if (currentStudent == "Chris")
      studentScores = chris;
  else if (currentStudent == "Eric")
      studentScores = eric;
  else if (currentStudent == "Gregor")
      studentScores = gregor;
  else
      continue;

  int currentStudentSum = 0;
  int currentStudentExamSum = 0;
  int currentStudentExtraCreditSum = 0;
  decimal currentStudentOverallGrade = 0;
  decimal currentStudentExamGrade = 0;
  decimal currentStudentExtraCreditPointsIncrease = 0;
  int gradedAssignments = 0;

  foreach (int grade in studentScores) 
  {
    gradedAssignments += 1;
    
    if(gradedAssignments <= examAssignments)
      {
        currentStudentSum += grade;
        currentStudentExamSum += grade;
      }
    else
    {
      currentStudentExtraCreditSum += grade;
      currentStudentSum += grade/10;
    }
  }

  currentStudentOverallGrade = (decimal)currentStudentSum / examAssignments;
  currentStudentExamGrade = (decimal)currentStudentExamSum / examAssignments;
  currentStudentExtraCreditPointsIncrease = (decimal)currentStudentOverallGrade - currentStudentExamGrade;

  if (currentStudentOverallGrade >= 97)
    currentStudentLetterGrade = "A+";
  else if (currentStudentOverallGrade >= 93)
    currentStudentLetterGrade = "A";
  else if (currentStudentOverallGrade >= 90)
    currentStudentLetterGrade = "A-";
  else if (currentStudentOverallGrade >= 87)
    currentStudentLetterGrade = "B+";
  else if (currentStudentOverallGrade >= 83)
    currentStudentLetterGrade = "B";
  else if (currentStudentOverallGrade >= 80)
    currentStudentLetterGrade = "B-";
  else if (currentStudentOverallGrade >= 77)
    currentStudentLetterGrade = "C+";
  else if (currentStudentOverallGrade >= 73)
    currentStudentLetterGrade = "C";
  else if (currentStudentOverallGrade >= 70)
    currentStudentLetterGrade = "C-";
  else if (currentStudentOverallGrade >= 67)
    currentStudentLetterGrade = "D+";
  else if (currentStudentOverallGrade >= 63)
    currentStudentLetterGrade = "D";
  else if (currentStudentOverallGrade >= 60)
    currentStudentLetterGrade = "D-";
  else
    currentStudentLetterGrade = "F";

 
  Console.WriteLine($"{currentStudent}\t\t{currentStudentExamGrade}\t\t{currentStudentOverallGrade}\t{currentStudentLetterGrade}\t\t{currentStudentExtraCreditSum} ({currentStudentExtraCreditPointsIncrease} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
