namespace manager_employees_1
{
    partial class FormConsultaReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaReporte));
            this.BtnCancelarBusquedaEmpleado = new System.Windows.Forms.Button();
            this.BtnBuscarEmpleado = new System.Windows.Forms.Button();
            this.TxtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LbBuscar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelarBusquedaEmpleado
            // 
            this.BtnCancelarBusquedaEmpleado.Location = new System.Drawing.Point(166, 67);
            this.BtnCancelarBusquedaEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancelarBusquedaEmpleado.Name = "BtnCancelarBusquedaEmpleado";
            this.BtnCancelarBusquedaEmpleado.Size = new System.Drawing.Size(104, 25);
            this.BtnCancelarBusquedaEmpleado.TabIndex = 25;
            this.BtnCancelarBusquedaEmpleado.Text = "Cancelar";
            this.BtnCancelarBusquedaEmpleado.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarEmpleado
            // 
            this.BtnBuscarEmpleado.Location = new System.Drawing.Point(277, 67);
            this.BtnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBuscarEmpleado.Name = "BtnBuscarEmpleado";
            this.BtnBuscarEmpleado.Size = new System.Drawing.Size(104, 25);
            this.BtnBuscarEmpleado.TabIndex = 24;
            this.BtnBuscarEmpleado.Text = "Generar";
            this.BtnBuscarEmpleado.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarEmpleado
            // 
            this.TxtBuscarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBuscarEmpleado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtBuscarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarEmpleado.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtBuscarEmpleado.Location = new System.Drawing.Point(23, 14);
            this.TxtBuscarEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.TxtBuscarEmpleado.Name = "TxtBuscarEmpleado";
            this.TxtBuscarEmpleado.Size = new System.Drawing.Size(358, 32);
            this.TxtBuscarEmpleado.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(102)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(20, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "___________________________________________________________";
            // 
            // LbBuscar
            // 
            this.LbBuscar.AutoSize = true;
            this.LbBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(102)))), ((int)(((byte)(85)))));
            this.LbBuscar.Location = new System.Drawing.Point(20, 51);
            this.LbBuscar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbBuscar.Name = "LbBuscar";
            this.LbBuscar.Size = new System.Drawing.Size(152, 13);
            this.LbBuscar.TabIndex = 22;
            this.LbBuscar.Text = "Ingrese el codigo de empleado";
            // 
            // FormConsultaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(406, 108);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelarBusquedaEmpleado);
            this.Controls.Add(this.BtnBuscarEmpleado);
            this.Controls.Add(this.TxtBuscarEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultaReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelarBusquedaEmpleado;
        private System.Windows.Forms.Button BtnBuscarEmpleado;
        private System.Windows.Forms.TextBox TxtBuscarEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbBuscar;
    }
}