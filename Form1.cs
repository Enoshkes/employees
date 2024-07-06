using Employees.Service;
using Employees.Model;

namespace Employees
{
    public partial class Form1 : Form
    {
        private IEmployeeService _employeeService;
        private List<Employee> _employeesList;
        private int _activeIndex = 0;
        

        public Form1()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            _employeeService.InitiateEmployees();
            _employeesList = _employeeService.GetAll();
            BindCurrentEmployee();
        }

        private void BindCurrentEmployee()
        {
            if (_employeesList.Count > 0) 
            {
                var current = _employeesList[_activeIndex];
                if (current != null) 
                {
                    txtCode.Text = $"{current.Id}";
                    txtId.Text = current.IdentityNumber;
                    txtFirstName.Text = current.FirstName;
                    txtLastName.Text = current.LastName;
                    txtAge.Text = $"{current.Age}";
                    txtCellphone.Text = current.CellphoneNumber;
                    txtTelephone.Text = current.PhoneNumber ?? "";
                    txtStreet.Text = current.Address.StreetName;
                    txtCity.Text = current.Address.City;
                    txtStreetNumber.Text = $"{current.Address.StreetNumber}";
                    dtpDateOfBirth.Text = current.DateOfBirth.ToShortDateString();
                    switch (current.Gender) 
                    {
                        case Gender.Male:
                            rdbMale.Checked = true; break;
                        case Gender.Female:
                            rdbFemale.Checked = true; break;
                    }
                    switch (current.FamilyStatus)
                    {
                        case FamilyStatus.Single:
                            rdbSingle.Checked = true; break;
                        case FamilyStatus.Married:
                            rdbMarride.Checked = true; break;
                        case FamilyStatus.Widowed:
                            rdbWidowed.Checked = true; break;
                        case FamilyStatus.Divorced:
                            rdbDivorce.Checked = true; break;
                    }
                }
            }
        }

        private void SetNavigationButtonsEnabled()
        {
            btBack.Enabled = _activeIndex > 0;
            btForward.Enabled = _activeIndex < _employeesList.Count - 1;
        }

        private void NextClick(object sender, EventArgs e)
        {
            if (_activeIndex < _employeesList.Count - 1)
            {
                ++_activeIndex;
                BindCurrentEmployee();
            }
            SetNavigationButtonsEnabled();
        }

        private void PrevClick(object sender, EventArgs e)
        {
            if (_activeIndex > 0)
            {
                --_activeIndex;
                BindCurrentEmployee();
            }
            SetNavigationButtonsEnabled();
        }


    }
}
