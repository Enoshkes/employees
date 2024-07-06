using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Model
{
    internal class Employee
    {
        public Employee(int id, string identityNumber, string firstName, string lastName, string? phoneNumber, string cellphoneNumber, Gender gender, FamilyStatus familyStatus, DateOnly dateOfBirth, Address address)
        {
            Id = id;
            IdentityNumber = identityNumber;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            CellphoneNumber = cellphoneNumber;
            Gender = gender;
            FamilyStatus = familyStatus;
            DateOfBirth = dateOfBirth;
            Address = address;
        }

        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string CellphoneNumber { get; set; }
        public Gender Gender { get; set; }
        public FamilyStatus FamilyStatus { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Address Address { get; set; }
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }

       
    }
}
