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
    public partial class FormBuscarEmpleado : Form
    {
        public FormBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void BtnCancelarBusquedaEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
