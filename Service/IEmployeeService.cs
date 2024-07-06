using Employees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Service
{
    internal interface IEmployeeService
    {
        void Add(Employee employee);

        void Update(Employee employee);

        void Delete(int id);

        Employee? Get(int id);

        List<Employee> GetAll();

        void InitiateEmployees();

        int GenerateId();

        public void SaveChanges();

    }
}
