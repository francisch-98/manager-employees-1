namespace manager_employees_1
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvBusquedaGeneral = new System.Windows.Forms.DataGridView();
            this.TxtBusquedaGeneral = new System.Windows.Forms.TextBox();
            this.CbBusquedaGeneral = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvBusquedaGeneral);
            this.groupBox1.Controls.Add(this.TxtBusquedaGeneral);
            this.groupBox1.Controls.Add(this.CbBusquedaGeneral);
            this.groupBox1.Controls.Add(this.label65);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // DgvBusquedaGeneral
            // 
            this.DgvBusquedaGeneral.AllowUserToAddRows = false;
            this.DgvBusquedaGeneral.AllowUserToDeleteRows = false;
            this.DgvBusquedaGeneral.AllowUserToOrderColumns = true;
            this.DgvBusquedaGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvBusquedaGeneral.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvBusquedaGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvBusquedaGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBusquedaGeneral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvBusquedaGeneral.Location = new System.Drawing.Point(3, 52);
            this.DgvBusquedaGeneral.Name = "DgvBusquedaGeneral";
            this.DgvBusquedaGeneral.ReadOnly = true;
            this.DgvBusquedaGeneral.Size = new System.Drawing.Size(795, 298);
            this.DgvBusquedaGeneral.TabIndex = 61;
            // 
            // TxtBusquedaGeneral
            // 
            this.TxtBusquedaGeneral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtBusquedaGeneral.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.TxtBusquedaGeneral.Font = new System.Drawing.Font("Adobe Heiti Std R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtBusquedaGeneral.Location = new System.Drawing.Point(342, 21);
            this.TxtBusquedaGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBusquedaGeneral.Multiline = true;
            this.TxtBusquedaGeneral.Name = "TxtBusquedaGeneral";
            this.TxtBusquedaGeneral.Size = new System.Drawing.Size(395, 23);
            this.TxtBusquedaGeneral.TabIndex = 60;
            // 
            // CbBusquedaGeneral
            // 
            this.CbBusquedaGeneral.BackColor = System.Drawing.Color.White;
            this.CbBusquedaGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbBusquedaGeneral.Font = new System.Drawing.Font("Adobe Heiti Std R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CbBusquedaGeneral.FormattingEnabled = true;
            this.CbBusquedaGeneral.Location = new System.Drawing.Point(102, 21);
            this.CbBusquedaGeneral.Name = "CbBusquedaGeneral";
            this.CbBusquedaGeneral.Size = new System.Drawing.Size(233, 23);
            this.CbBusquedaGeneral.TabIndex = 59;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(102)))), ((int)(((byte)(85)))));
            this.label65.Location = new System.Drawing.Point(11, 25);
            this.label65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(84, 15);
            this.label65.TabIndex = 58;
            this.label65.Text = "Busqueda por";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda General";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbBusquedaGeneral;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.DataGridView DgvBusquedaGeneral;
        private System.Windows.Forms.TextBox TxtBusquedaGeneral;
    }
}