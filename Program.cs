using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee s1 = new Employee() { Name = "John Doe", Age = 21 };
            Employee s2 = new Employee() { Name = "Maria Doe", Age = 24 };
            Employee s3 = new Employee() { Name = "David Evans", Age = 32 };
            Employee s4 = new Employee() { Name = "David Doe", Age = 26 };

            Project p1 = new Project() { Title = "Weekly Report" };
            Project p2 = new Project() { Title = "Website Rebuild" };
            Project p3 = new Project() { Title = "Logo Ideas" };
            Project p4 = new Project() { Title = "Marketing Plan" };
            Project p5 = new Project() { Title = "Front-End Redesign" };
            Project p6 = new Project() { Title = "Database Migration" };
            Project p7 = new Project() { Title = "Server Room Clean Up" };
            Project p8 = new Project() { Title = "Interview" };

            //assign to each student multiple projects and to each project a student

            List<Project> Projects_s1 = new List<Project>() { p1, p2 };
            s1.Projects.AddRange(Projects_s1);
            p1.Employee = s1;
            p2.Employee = s1;

            List<Project> Projects_s2 = new List<Project>() { p3, p4, p5 };
            s2.Projects.AddRange(Projects_s2);
            p3.Employee = s2;
            p4.Employee = s2;
            p5.Employee = s2;

            List<Project> Projects_s3 = new List<Project>() { p6, p7 };
            s3.Projects.AddRange(Projects_s3);
            p6.Employee = s3;
            p7.Employee = s3;

            List<Project> Projects_s4 = new List<Project>() { p8};
            s4.Projects.AddRange(Projects_s4);
            p8.Employee = s4;

            //add the projects and the employees to a list

            List<Employee> employees = new List<Employee>() { s1, s2, s3, s4 };

            List<Project> projects = new List<Project>() { p1, p2, p3, p4, p5, p6, p7, p8 };

            Console.WriteLine();
            Console.WriteLine("Projects PER Emloyees");
            Console.WriteLine();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}");

                foreach (var project in employee.Projects)
                {
                    Console.WriteLine($"\t{project.Title}");
                }
            }

            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("Employees PER ProjectS");
            Console.WriteLine();

            foreach (var project in projects)
            {
                Console.WriteLine($"{project.Title, -25} {project.Employee.Name}");
            }

        }
    }
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
    class Project
    {
        public string Title { get; set; }
        public Employee Employee { get; set; }
    }
}
