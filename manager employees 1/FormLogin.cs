using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager_employees_1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FormModuleAccess formMA = new FormModuleAccess();
            formMA.MdiParent = this.MdiParent;
            formMA.Show();
            this.Visible = false;
        }
    }
}
