using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace manager_employees_1
{

    
    public partial class FormSplashScreen : Form
    {

        public FormSplashScreen()
        {       
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.MdiParent = this.MdiParent;
            formLogin.Show();
            this.Visible = false;
            timer.Enabled=false;
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
    }
}
