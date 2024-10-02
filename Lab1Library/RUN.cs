using System;
using System.IO;
using Lab1Library; // Ensure you have the correct namespace for your library
using static Lab1Library.Student;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of StudentsData
        StudentsData studentsData = new StudentsData();

        // Create a new student object
        Student newStudent = new Student("Niklavs", "Zibailo", "100", "GroupA", "email@gmail.com");


        // Add the new student to the StudentsData instance
        studentsData.Add(newStudent);

        // Save the student list to an XML file
        try
        {
            studentsData.Save(StudentsData.DefaultFilename);
            Console.WriteLine("Student saved to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving student: {ex.Message}");
        }

        // Clear the current list and load students from the XML file
        try
        {
            studentsData = new StudentsData(); // Create a new instance to load data into
            studentsData.Load(StudentsData.DefaultFilename);
            Console.WriteLine("Student list loaded:");

            // Display the loaded students
            foreach (var student in studentsData.Students)
            {
                Console.WriteLine(student); // This will use the overridden ToString() method
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The specified file was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading students: {ex.Message}");
        }

        // Wait for a key press before exiting
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
