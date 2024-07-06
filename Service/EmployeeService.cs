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
            _employees = [];

            foreach (var employee in employees)
            {
                Add(employee);
            }
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }


        public void Delete(int id)
        {
            Employee? employee = Get(id);
            if (employee != null)
            {
                _employees.Remove(employee);
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

        public void WriteToJsonFile()
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

        public List<Employee> ReadFromJsonFile()
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
            List<Employee> employees = ReadFromJsonFile();
            if (employees.Count != 0)
            {
                _employees = employees;
            }
            else
            {
                List<Employee> newList = [
                    new Employee(1, "333432", "Enosh", "Tsur", null, "0525864932", Gender.Male, FamilyStatus.Married, new DateOnly(1990,3, 24),
                        new Address("Rishon", "Rambam", 46)
                    ),
                    new Employee(2, "333433", "Elly", "Rotman", null, "0523861930", Gender.Male, FamilyStatus.Single, new DateOnly(1997, 5, 1),
                        new Address("Rishon", "Givati", 22)
                    ),
                    new Employee(3, "333433", "Rachel", "Levi", "036498865", "0527884812", Gender.Female, FamilyStatus.Divorced, new DateOnly(2000, 7, 12),
                        new Address("Tel Aviv", "Aliya", 15)
                    )
                ];

                _employees = newList;
                WriteToJsonFile();
            }
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
    }
}
