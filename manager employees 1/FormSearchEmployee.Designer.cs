namespace manager_employees_1
{
    partial class FormBuscarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarEmpleado));
            this.TxtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LbBuscar = new System.Windows.Forms.Label();
            this.BtnBuscarEmpleado = new System.Windows.Forms.Button();
            this.BtnCancelarBusquedaEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBuscarEmpleado
            // 
            this.TxtBuscarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtBuscarEmpleado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtBuscarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarEmpleado.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtBuscarEmpleado.Location = new System.Drawing.Point(14, 14);
            this.TxtBuscarEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.TxtBuscarEmpleado.Name = "TxtBuscarEmpleado";
            this.TxtBuscarEmpleado.Size = new System.Drawing.Size(306, 32);
            this.TxtBuscarEmpleado.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(102)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(18, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "___________________________________________________________";
            // 
            // LbBuscar
            // 
            this.LbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbBuscar.AutoSize = true;
            this.LbBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(102)))), ((int)(((byte)(85)))));
            this.LbBuscar.Location = new System.Drawing.Point(18, 53);
            this.LbBuscar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbBuscar.Name = "LbBuscar";
            this.LbBuscar.Size = new System.Drawing.Size(45, 14);
            this.LbBuscar.TabIndex = 17;
            this.LbBuscar.Text = "Buscar";
            // 
            // BtnBuscarEmpleado
            // 
            this.BtnBuscarEmpleado.Location = new System.Drawing.Point(232, 82);
            this.BtnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBuscarEmpleado.Name = "BtnBuscarEmpleado";
            this.BtnBuscarEmpleado.Size = new System.Drawing.Size(88, 25);
            this.BtnBuscarEmpleado.TabIndex = 19;
            this.BtnBuscarEmpleado.Text = "Buscar";
            this.BtnBuscarEmpleado.UseVisualStyleBackColor = true;
            // 
            // BtnCancelarBusquedaEmpleado
            // 
            this.BtnCancelarBusquedaEmpleado.Location = new System.Drawing.Point(136, 82);
            this.BtnCancelarBusquedaEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancelarBusquedaEmpleado.Name = "BtnCancelarBusquedaEmpleado";
            this.BtnCancelarBusquedaEmpleado.Size = new System.Drawing.Size(88, 25);
            this.BtnCancelarBusquedaEmpleado.TabIndex = 20;
            this.BtnCancelarBusquedaEmpleado.Text = "Cancelar";
            this.BtnCancelarBusquedaEmpleado.UseVisualStyleBackColor = true;
            this.BtnCancelarBusquedaEmpleado.Click += new System.EventHandler(this.BtnCancelarBusquedaEmpleado_Click);
            // 
            // FormBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(339, 121);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelarBusquedaEmpleado);
            this.Controls.Add(this.BtnBuscarEmpleado);
            this.Controls.Add(this.TxtBuscarEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbBuscar);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbBuscar;
        private System.Windows.Forms.Button BtnBuscarEmpleado;
        private System.Windows.Forms.Button BtnCancelarBusquedaEmpleado;
    }
}