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

        public static FamilyStatus MapFamilyStatusByText(string text)
        {
            return text switch
            {
                "רווק" => FamilyStatus.Single,
                "נשוי" => FamilyStatus.Married,
                "גרוש" => FamilyStatus.Divorced,
                "אלמן" => FamilyStatus.Widowed,
                _ => FamilyStatus.Unkown,
            };
        }
    }
}
