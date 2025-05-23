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

        static void Main(string[] args)
        {
            Console.Write("Do you want to add multiple entry? (Y/N):");
            string choice = Console.ReadLine();
            if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                List<string> studentRecords = new List<string>();
                int gradeA = 0, gradeB = 0, gradeC = 0, gradeS = 0, gradeF = 0;

                Console.Write("Enter how many students you want to enter: ");
                int entry = Convert.ToInt32(Console.ReadLine());
                int count = 0;

                while (count < entry)
                {
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();

                    if (name.All(char.IsDigit))
                    {
                        Console.WriteLine("Invalid student name\n");
                        continue;
                    }

                    Console.Write("Enter Marks (out of 100): ");
                    try
                    {
                        int marks = Convert.ToInt32(Console.ReadLine());
                        string grade = "";

                        if (marks >= 0 && marks <= 100)
                        {
                            if (marks > 75)
                            {
                                grade = "A"; gradeA++;
                            }
                            else if (marks > 65)
                            {
                                grade = "B"; gradeB++;
                            }
                            else if (marks > 55)
                            {
                                grade = "C"; gradeC++;
                            }
                            else if (marks > 45)
                            {
                                grade = "S"; gradeS++;
                            }
                            else
                            {
                                grade = "F"; gradeF++;
                            }

                            // Add formatted string to list
                            studentRecords.Add(string.Format("Student: {0}, Marks: {1}, Grade: {2}", name, marks, grade));
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid marks. Must be between 0 and 100.\n");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Please enter numeric marks.\n");
                    }
                }

                // Show all student records
                Console.WriteLine("\n--- All Student Records ---");
                foreach (string record in studentRecords)
                {
                    Console.WriteLine(record);
                }

                Console.WriteLine("\nPress Enter to exit...");
                Console.ReadLine();
            }
            else
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
}
