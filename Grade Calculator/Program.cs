using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks (out of 100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            string grade = "F";
            if (marks > 75)
                grade = "A";
            else if (marks > 65)
                grade = "B";
            else if (marks > 55)
                grade = "C";
            else if (marks > 45)
                grade = "S";

            Console.WriteLine("Student: " + name + ", Grade: " + grade);
            Console.ReadLine();
        }

            static void Main(string[] args)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            if (name.All(char.IsDigit))
            {
                Console.WriteLine("Invalid student name");
            }

            else
            {
                Console.Write("Enter Marks (out of 100): ");
                string grade = "";

                try
                {
                    int marks = Convert.ToInt32(Console.ReadLine());
                    if (marks <= 100)
                    {
                        if (marks > 75)
                            grade = "A";
                        else if (marks > 65)
                            grade = "B";
                        else if (marks > 55)
                            grade = "C";
                        else if (marks > 45)
                            grade = "S";
                        else if (marks <= 45)
                            grade = "F";
                    }
                    else
                    {
                        Console.WriteLine("Invalid student marks");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid student marks");
                }

                Console.WriteLine("Student: " + name + ", Grade: " + grade);
                Console.ReadLine();
            }
        }
    }
}
