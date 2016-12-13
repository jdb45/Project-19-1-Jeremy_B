using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_19_1_Jeremy_B
{
    class Validator
    {
        //creating a method to check if the text box is blank or not
        public static bool IsPresent(Control control, string name)
        {
            if (control.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
                return false;
            }
            return true;
        }

        public static bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer, please enter an integer.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }

        }
    }
}