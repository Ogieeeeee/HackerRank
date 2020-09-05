using System;

//link for exercise: https://www.hackerrank.com/challenges/30-class-vs-instance/problem
class Person
{

    public int age { get; set; }

    public Person(int initialAge)
    {
        if (initialAge < 0)
        {
            System.Console.WriteLine("Age is not valid, setting age to 0.");
            age = 0;
        }
        else age = initialAge;
    }

    public void yearPasses() => age++;
    public string amIOld()
    {
        if (age < 13) return "You are young.";
        else if (age >= 13 && age < 18) return "You are a teenager.";
        else return "You are old.";
    }

}