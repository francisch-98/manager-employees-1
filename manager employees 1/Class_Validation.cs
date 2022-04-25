using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager_employees_1
{
    internal class Class_Validation
    {
        public static void textbox_Validating(String textbox)
        {
            if (textbox.Length == 0)
            {
                MessageBox.Show("Debe llenar el campo");
            }
        }
    }
}
