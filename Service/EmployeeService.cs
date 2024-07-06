using Employees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Employees.Service
{
    internal class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees;
        private readonly string _filePath = 
            $"{Directory.GetCurrentDirectory()}/file.json";
        

        public EmployeeService() 
        {
            _employees = [];
        }

        public EmployeeService(params Employee[] employees)
        {
            _employees = new List<Employee>(employees);
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }


        public void Delete(int id)
        {
            int index = -1;
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == id)
                {
                    index = i;
                }
            }
            if (index != -1)
            {
            _employees.RemoveAt(index);
            }
        }

        public Employee? Get(int id)
        {

            Employee? employee = null;
            foreach (Employee e in _employees)
            {
                if (e.Id == id) 
                {
                    employee = e;
                    break;
                }
            }
            return employee;
        }

        public List<Employee> GetAll()
        {
            return _employees;
                
        }

        public void Update(Employee employee)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == employee.Id)
                {
                    _employees[i] = employee;
                    break;
                }
            } 
        }

        private void WriteToJsonFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(_employees);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<Employee> ReadFromJsonFile()
        {
            List<Employee> employees = [];
            try
            {
                if (!File.Exists(_filePath))
                {
                    return employees; 
                }
                string json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<Employee>>(json) ?? employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return employees;
            }
           
        }

        public void InitiateEmployees()
        {
            _employees = ReadFromJsonFile();
        }

        public int GenerateId()
        {
           int max = 0;
            foreach (Employee employee in _employees)
            {
                if(employee.Id > max)
                {
                    max = employee.Id;
                }
            }
            return max + 1;
        }

        public void SaveChanges()
        {
            WriteToJsonFile();
        }
    }
}
