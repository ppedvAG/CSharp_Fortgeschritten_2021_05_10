using System;
using System.Collections.Generic;

namespace Solid_Übung3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    #region BadCod
    public interface IRepository
    {
        Employee GetById(int Id);
        IList<Employee> GetAll();


        void Update(int Id, Employee modifiedEmployee);
        void Insert(Employee employee);

        void Delete(int Id);
    }


    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
    }

    public class EmployeeRepository : IRepository
    {
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Employee modifiedEmployee)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
