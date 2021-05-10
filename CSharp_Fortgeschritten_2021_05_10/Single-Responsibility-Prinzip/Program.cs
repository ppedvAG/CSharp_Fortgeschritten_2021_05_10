using System;

namespace Single_Responsibility_Prinzip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class EmployeeBad
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        public void InsertIntoEmployeeTable(EmployeeBad employee)
        {
            //Speichere

            return;
        }
        public void GenerateReport(EmployeeBad em)
        {

        }
    }


    //Bessere Variante

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ReportGenerator
    {
        public void GenerateReport()
        {

        }
    }

    public class EmployeeRepository
    {
        public void GenerateReport(EmployeeBad em)
        {

        }
    }

}
