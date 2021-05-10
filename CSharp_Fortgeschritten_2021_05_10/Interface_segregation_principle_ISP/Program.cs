using System;
using System.Collections.Generic;

namespace Interface_segregation_principle_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            IReadonlyRepository readonlyRepository = new EmployeeRepository();
            //readonlyRepository.GetAll
            //readonlyRepository.GetById

            IRepository repo = new EmployeeRepository();
            //readonlyRepository.GetAll
            //readonlyRepository.GetById

            //readonlyRepository.Insert / Delete / Update
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Birthday { get; set; }
    }



    #region BadCode
    public interface IReadonlyRepository
    {
        Employee GetById(int Id);
        IList<Employee> GetAll();
    }

    public interface IRepository : IReadonlyRepository
    {
        void Update(int id, Employee em);
        void Insert(Employee em);
        void Delete(int id);
    }

    public class EmployeeRepository : IRepository
    {
        public void Delete(int id)
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

        public void Insert(Employee em)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Employee em)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Better
    //https://github.com/SharpRepository/SharpRepository/blob/develop/SharpRepository.Repository/Traits/ICanDelete.cs
    public interface ICanAdd
    {
        void Insert(Employee employee);
    }

    public interface ICanUpdate
    {
        void Update(int Id, Employee modifiedEmployee);
    }

    public interface ICanDelete
    {
        void Delete(int Id);
    }

    public interface ICanRead
    {
        IList<Employee> ReadAll();

        Employee GetEmployeeById(int Id);
    }

    public class BetterRepository : ICanAdd, ICanUpdate, ICanDelete, ICanRead
    {
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> ReadAll()
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
