using Employees.Service;
using Employees.Model;
using Employees.Utils;

namespace Employees
{
    public partial class Form1 : Form
    {
        private IEmployeeService _employeeService;
        private int _activeIndex = 0;
        private FormState _formState;
        

        public Form1()
        {
            InitializeComponent();
            _formState = FormState.Read;
            _employeeService = new EmployeeService();
            _employeeService.InitiateEmployees();
            btForward.Enabled = _employeeService.GetAll().Count > 1;
            BindCurrentEmployee();
        }

        private void BindCurrentEmployee()
        {
            var employeesList = _employeeService.GetAll();
            if (employeesList.Count > 0)
            {
                var current = employeesList[_activeIndex];
                if (current != null)
                {
                    BindEmployeeToForm(current);
                    return;
                }
            }
            _formState = FormState.New;
            ClearForm();
        }

        private void BindEmployeeToForm(Employee employee)
        {
            txtCode.Text = employee.Id.ToString();
            txtId.Text = employee.IdentityNumber;
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtAge.Text = employee.Age.ToString();
            txtCellphone.Text = employee.CellphoneNumber;
            txtTelephone.Text = employee.PhoneNumber ?? string.Empty;
            txtStreet.Text = employee.Address.StreetName;
            txtCity.Text = employee.Address.City;
            txtStreetNumber.Text = employee.Address.StreetNumber.ToString();
            dtpDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            rdbMale.Checked = employee.Gender == Gender.Male;
            rdbFemale.Checked = employee.Gender == Gender.Female;

            switch (employee.FamilyStatus)
            {
                case FamilyStatus.Single:
                    rdbSingle.Checked = true;
                    break;
                case FamilyStatus.Married:
                    rdbMarried.Checked = true;
                    break;
                case FamilyStatus.Widowed:
                    rdbWidowed.Checked = true;
                    break;
                case FamilyStatus.Divorced:
                    rdbDivorced.Checked = true;
                    break;
            }
        }


        private void EnableNavigatinoButtons()
        {
            var employeesList = _employeeService.GetAll();
            btBack.Enabled = _activeIndex > 0;
            btForward.Enabled = _activeIndex < employeesList.Count - 1;
        }

        private void NextClick(object sender, EventArgs e)
        {
            var employeesList = _employeeService.GetAll();
            if (_activeIndex < employeesList.Count - 1)
            {
                ++_activeIndex;
                BindCurrentEmployee();
            }
            EnableNavigatinoButtons();
        }

        private void PrevClick(object sender, EventArgs e)
        {
            if (_activeIndex > 0)
            {
                --_activeIndex;
                BindCurrentEmployee();
            }
            EnableNavigatinoButtons();
        }

        private void ClearForm()
        {
            foreach (var textBox in new[] { 
                txtCode, txtId, txtFirstName, txtLastName, txtAge, 
                txtCellphone, txtTelephone, txtStreet, txtCity, txtStreetNumber 
            })
            {
                textBox.Text = string.Empty;
            }
            dtpDateOfBirth.Value = DateTime.Now;
            rdbMale.Checked = true;
            rdbSingle.Checked = true;
            dtpDateOfBirth.Text = DateTime.Now.ToShortTimeString();
            rdbMale.Checked = true;
            rdbSingle.Checked = true;
        }

        private void NewEmployee(object sender, EventArgs e)
        {
            _formState = FormState.New;
            ClearForm();
        }

        private FamilyStatus GetFamilyStatus ()
        {
            return rdbSingle.Checked switch
            {
                true => FamilyStatus.Single,
                _ when rdbMarried.Checked => FamilyStatus.Married,
                _ when rdbDivorced.Checked => FamilyStatus.Divorced,
                _ => FamilyStatus.Widowed,
            };
        }

        private Employee? CreateEmployeeViaUI()
        {
            List<TextBox> formTextBoxes = [
                           txtId, txtFirstName, txtLastName,
                txtCellphone, txtStreet, txtCity, txtStreetNumber,
            ];

            if (!FormUtils.IsAllTextBoxAreValid(formTextBoxes))
            {
                return null;
            }

            if (!DateOnly.TryParse(dtpDateOfBirth.Text, out var dob))
            {
                return null;
            }

            return new Employee(
                _formState == FormState.New ? _employeeService.GenerateId() : int.Parse(txtCode.Text),
                txtId.Text,
                txtFirstName.Text,
                txtLastName.Text,
                txtTelephone.Text,
                txtCellphone.Text,
                rdbMale.Checked ? Gender.Male : Gender.Female,
                GetFamilyStatus(),
                dob,
                new Address(txtCity.Text, txtStreet.Text, int.Parse(txtStreetNumber.Text))
            );
        }


        private void SaveEmployee(object sender, EventArgs e)
        {
            if (_formState != FormState.New)
            {
                MessageBox.Show("Please hit the new button before trying to save");
                return;
            }

            Employee? newEmployee = CreateEmployeeViaUI();
            if (newEmployee == null)
            {
                MessageBox.Show("This form is invalid. all fields must be filled out");
                return;
            }

            var employeesList = _employeeService.GetAll();
            _employeeService.Add(newEmployee);
            _activeIndex = employeesList.Count - 1;
            BindCurrentEmployee();
            EnableNavigatinoButtons();
            _employeeService.SaveChanges();
            _formState = FormState.Read;
        }

        void UpdateEmployee(object sender, EventArgs e)
        {
            Employee? updatedEmployee = CreateEmployeeViaUI();
            if (updatedEmployee == null)
            {
                MessageBox.Show("This form is invalid. all fields must be filled out");
                return;
            }
            _employeeService.Update(updatedEmployee);
            _employeeService.SaveChanges();
        }

        void DeleteEmployee(object sender, EventArgs e)
        {
            _employeeService.Delete(int.Parse(txtCode.Text));
            _activeIndex = Math.Max(0, _activeIndex - 1);
            _employeeService.SaveChanges();
            BindCurrentEmployee();
            EnableNavigatinoButtons();
        }

        private void OnNumericTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
