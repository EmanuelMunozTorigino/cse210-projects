using System;

class Program
{
    static void Main(string[] args)
    {
        //    Console.WriteLine("Hello Prep1 World!");

        //  Ask for user's name

        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name? ");

        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");



        Console.WriteLine("What was your grade? ");
        string grade = Console.ReadLine();
        gradeNumber = int.Parse(grade)

        if (gradeNumber >= 90)
        {
            Console.WriteLine("You get an 'A'");
        }
        elif(gradeNumber >= 80)
            {
            Console.WriteLine("You get a 'B'");
        }

        elif(gradeNumber >= 70)
        {
            Console.WriteLine("You get a 'C'");
        }

        elif(gradeNumber >= 60)
            {
            Console.WriteLine("You get a 'D'");
        }

        elif(gradeNumber < 60)
            {
            Console.WriteLine("You get a 'F'");
        }

        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed the class");
        }
        else
        {
            Console.WriteLine("Sorry, try next semester, you can do it");
        }
    }


}


