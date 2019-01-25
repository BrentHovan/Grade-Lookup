using System;

namespace Grade_Lookup
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    Console.WriteLine("What percent grade, as a whole number from 0 to 100, do you expect to get in ISM 4300?");
                    int percentGrade;
                    string letterGrade;

                    string input = Console.ReadLine();
                    percentGrade = int.Parse(input);

                    //Conditional Logic
                    if (percentGrade >= 98)
                        letterGrade = "A+\nCongratulations, you are really an overachiever!";
                    else if (percentGrade >= 92)
                        letterGrade = "A";
                    else if (percentGrade >= 90)
                        letterGrade = "A-\nDon't you hate the +/- system?";
                    else if (percentGrade >= 88)
                        letterGrade = "B+";
                    else if (percentGrade >= 82)
                        letterGrade = "B";
                    else if (percentGrade >= 80)
                        letterGrade = "B-\nDon't you hate the +/- system?";
                    else if (percentGrade >= 78)
                        letterGrade = "C+";
                    else if (percentGrade >= 72)
                        letterGrade = "C\nC's get degrees!";
                    else if (percentGrade >= 70)
                        letterGrade = "C-\nYou must *really* hate the +/- system!\nSee you next semester!";
                    else if (percentGrade >= 68)
                        letterGrade = "D+\nSee you next semester!";
                    else if (percentGrade >= 62)
                        letterGrade = "D\nSee you next semester!";
                    else if (percentGrade >= 60)
                        letterGrade = "D-\nSee you next semester!";
                    else
                        letterGrade = "F\nShhh... It happens.";
                    Console.WriteLine("Your letter grade will be: " + letterGrade);
                    Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Invalid grade entered.");
                Console.ReadKey();
            }
        }
    }
}