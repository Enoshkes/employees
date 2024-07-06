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
            UpdateCurrentEmployeeTextBoxes();
        }

        private void UpdateCurrentEmployeeTextBoxes()
        {
            var employeesList = _employeeService.GetAll();
            if (employeesList.Count > 0) 
            {
                var current = employeesList[_activeIndex];
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
                UpdateCurrentEmployeeTextBoxes();
            }
            SetNavigationButtonsEnabled();
        }

        private void PrevClick(object sender, EventArgs e)
        {
            if (_activeIndex > 0)
            {
                --_activeIndex;
                UpdateCurrentEmployeeTextBoxes();
            }
            SetNavigationButtonsEnabled();
        }

        private void NewEmployee(object sender, EventArgs e)
        {
            _formState = FormState.New;
            List<TextBox> formTextBoxes = [
                txtCode, txtId, txtFirstName, txtLastName,
                txtAge, txtCellphone, txtTelephone,
                txtStreet, txtCity, txtStreetNumber,
            ];

            foreach (TextBox formTextBox in formTextBoxes)
            {
                formTextBox.Text = string.Empty;
            }
            dtpDateOfBirth.Text = DateTime.Now.ToShortTimeString();
            rdbMale.Checked = true;
            rdbSingle.Checked = true;
        }

        private void SaveEmployee(object sender, EventArgs e)
        {
            if (_formState != FormState.New)
            {
                MessageBox.Show("Please hit the new button before trying to save");
                return;
            }
            
            List<TextBox> formTextBoxes = [
                txtId, txtFirstName, txtLastName,
                txtCellphone, txtStreet, txtCity, txtStreetNumber,
            ];

            if (!FormUtils.IsAllTextBoxAreValid(formTextBoxes))
            {
                MessageBox.Show("This form is invalid. all fields must be filled out");
                return;
            }

            var success = DateOnly.TryParse(dtpDateOfBirth.Text, out DateOnly dob);
            if (!success)
            {
                MessageBox.Show("Invalid date format");
                return;
            }

            string familyStatusText = string.Empty;
            List<RadioButton> radioButtons = [rdbSingle, rdbMarride, rdbDivorce, rdbWidowed];
            foreach (RadioButton status in radioButtons)
            {
                if (status.Checked)
                {
                    familyStatusText = status.Text;
                }
            }

            Employee newEmployee = new Employee(
            _employeeService.GenerateId(),
            txtId.Text,
            txtFirstName.Text,
            txtLastName.Text,
            txtTelephone.Text,
            txtCellphone.Text,
            rdbMale.Checked ? Gender.Male : Gender.Female,
            FormUtils.MapFamilyStatusByText(familyStatusText),
            dob,
            new Address(txtCity.Text, txtStreet.Text, int.Parse(txtStreetNumber.Text))
            );


            var employeesList = _employeeService.GetAll();
            _employeeService.Add(newEmployee);
            _activeIndex = employeesList.Count - 1;
            UpdateCurrentEmployeeTextBoxes();
            SetNavigationButtonsEnabled();
            _employeeService.WriteToJsonFile();
            _formState = FormState.Read;
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
