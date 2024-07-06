using Employees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Utils
{
    internal class FormUtils
    {
        public static bool IsAllTextBoxAreValid(List<TextBox> formTextBoxes)
        {
            bool isValid = true;

            foreach (TextBox textBox in formTextBoxes)
            {
                isValid &= !string.IsNullOrWhiteSpace(textBox.Text);
            }
            return isValid;
        }
    }
}
