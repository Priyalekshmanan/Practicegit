using System;

namespace Assignment_5
{
    interface IGovtRules
    {
        double CalculateEmployeePF(double basicSalary);
        string GetLeaveDetails();
        double CalculateGratuityAmount(float serviceCompleted, double basicSalary);
    }

    class TCS : IGovtRules
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desg { get; set; }
        public double BasicSalary { get; set; }

        public TCS(int empId, string name, string dept, string desg, double basicSalary)
        {
            EmpId = empId;
            Name = name;
            Dept = dept;
            Desg = desg;
            BasicSalary = basicSalary;
        }

        public double CalculateEmployeePF(double basicSalary)
        {
            return basicSalary * 0.24;
        }

        public string GetLeaveDetails()
        {
            return "Casual Leave: 1 day per month\nSick Leave: 12 days per year\nPrivilege Leave: 10 days per year";
        }

        public double CalculateGratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
            {
                return basicSalary * 3;
            }
            else if (serviceCompleted > 10)
            {
                return basicSalary * 2;
            }
            else if (serviceCompleted > 5)
            {
                return basicSalary;
            }
            else
            {
                return 0; // No gratuity
            }
        }
    }

    class Accenture : IGovtRules
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpDept { get; set; }
        public string EmpDesg { get; set; }
        public int EmpBasicSalary { get; set; }

        public Accenture(int id, string empName, string empDept, string empDesg, int empBasicSalary)
        {
            Id = id;
            EmpName = empName;
            EmpDept = empDept;
            EmpDesg = empDesg;
            EmpBasicSalary = empBasicSalary;
        }

        public double CalculateEmployeePF(double basicSalary)
        {
            return basicSalary * 0.24;
        }

        public string GetLeaveDetails()
        {
            return "Casual Leave: 2 days per month\nSick Leave: 5 days per year\nPrivilege Leave: 5 days per year";
        }

        public double CalculateGratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0; // Not applicable
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Choose a company: TCS (1) or Accenture (2)");
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid choice. Please enter 1 for TCS or 2 for Accenture.");
            }

            if (choice == 1)
            {
                TCS tcsEmployee = new TCS(101, "John Doe", "IT", "Software Engineer", 50000);
                DisplayEmployeeDetails(tcsEmployee);
            }
            else
            {
                Accenture accentureEmployee = new Accenture(102, "Jane Smith", "Consulting", "Business Analyst", 60000);
                DisplayEmployeeDetails(accentureEmployee);
            }
        }

        private static void DisplayEmployeeDetails(IGovtRules employee)
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Employee ID: {0}", employee is TCS tcs ? tcs.EmpId : ((Accenture)employee).Id);
            Console.WriteLine("Name: {0}", employee is TCS tcsName ? tcsName.Name : ((Accenture)employee).EmpName);
            Console.WriteLine("PF: {0:C}", employee.CalculateEmployeePF(employee is TCS tcsPF ? tcsPF.BasicSalary : ((Accenture)employee).EmpBasicSalary));
            Console.WriteLine("Leave Details: {0}", employee.GetLeaveDetails());
            Console.WriteLine("Gratuity Amount: {0:C}", employee.CalculateGratuityAmount(7, employee is TCS tcsGratuity ? tcsGratuity.BasicSalary : ((Accenture)employee).EmpBasicSalary));
        }
    }
}
