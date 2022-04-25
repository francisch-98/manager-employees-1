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
    public partial class FormModuleAccess : Form
    {
        public FormModuleAccess()
        {
            InitializeComponent();
        }

        private void BtnGuardarRegEmpleado_Click(object sender, EventArgs e)
        {
            validation_employee();
        }
       
        private void BtnGuardarRLaboral_Click(object sender, EventArgs e)
        {
            Validation_RLaboral();
        }
        public void validation_employee()
        {
            Class_Validation.textbox_Validating(TxtPNombre.Text);
            Class_Validation.textbox_Validating(TxtSNombre.Text);
            Class_Validation.textbox_Validating(TxtTNombre.Text);
            Class_Validation.textbox_Validating(TxtPApellido.Text);
            Class_Validation.textbox_Validating(TxtSApellido.Text);
            Class_Validation.textbox_Validating(TxtCApellido.Text);
            Class_Validation.textbox_Validating(TxtNoLicencia.Text);
            Class_Validation.textbox_Validating(TxtCodIGSS.Text);
            Class_Validation.textbox_Validating(TxtCui.Text);
            Class_Validation.textbox_Validating(TxtNit.Text);
            Class_Validation.textbox_Validating(TxtExtendida.Text);
            Class_Validation.textbox_Validating(TxtEmailEmpleado.Text);
            Class_Validation.textbox_Validating(TxtNoCelular.Text);
            Class_Validation.textbox_Validating(TxtNoTelefonoCasa.Text);
            Class_Validation.textbox_Validating(TxtIDEmpleado.Text);
            Class_Validation.textbox_Validating(TxtNombreContacto2.Text);
            Class_Validation.textbox_Validating(TxtCuiContacto2.Text);
            Class_Validation.textbox_Validating(TxtNoTelefonoContacto2.Text);
            Class_Validation.textbox_Validating(TxtNombreContacto1.Text);
            Class_Validation.textbox_Validating(TxtCuiContacto1.Text);
            Class_Validation.textbox_Validating(TxtNoTelefonoContacto1.Text);
            Class_Validation.textbox_Validating(TxtNBanco.Text);
            Class_Validation.textbox_Validating(TxtNoCuentaBancaria.Text);
            Class_Validation.textbox_Validating(TxtNoColegiado.Text);
            Class_Validation.textbox_Validating(TxtNoColegio.Text);
            Class_Validation.textbox_Validating(TxtProfesion.Text);
            Class_Validation.textbox_Validating(TxtPuesto.Text);
            Class_Validation.textbox_Validating(TxtGradoAcademico.Text);
            Class_Validation.textbox_Validating(TxtDDireccion.Text);
            Class_Validation.textbox_Validating(TxtNacionalidad.Text);
            Class_Validation.textbox_Validating(TxtLNacimiento.Text);
        }

        public void Validation_RLaboral()
        {
            Class_Validation.textbox_Validating(TxtNPGRLaboral.Text);
            Class_Validation.textbox_Validating(TxtNoContratoRLaboral.Text);
            Class_Validation.textbox_Validating(CbPuestoFuncionalRLaboral.Text);
            Class_Validation.textbox_Validating(TxtEstadoLaboral.Text);
            Class_Validation.textbox_Validating(TxtRRelacionRLaboral.Text);
            Class_Validation.textbox_Validating(TxtUActaServicioRLaboral.Text);
            Class_Validation.textbox_Validating(TxtMAnualRLaboral.Text);
            Class_Validation.textbox_Validating(TxtMMensualRLaboral.Text);
            Class_Validation.textbox_Validating(TxtSalarioRLaboral.Text);
            Class_Validation.textbox_Validating(TxtObGeneralRLaboral.Text);
            Class_Validation.textbox_Validating(TxtPPresupuestariaRLaboral.Text);
        }

        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FormBuscarEmpleado formSE = new FormBuscarEmpleado();
            formSE.MdiParent = this.MdiParent;
            formSE.Show();
        }
    }
}
