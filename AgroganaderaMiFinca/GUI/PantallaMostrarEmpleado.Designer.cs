
namespace AgroganaderaMiFinca
{
    partial class PantallaMostrarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaMostrarEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dgvEmpleado);
            this.panel1.Location = new System.Drawing.Point(94, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 456);
            this.panel1.TabIndex = 32;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvEmpleado.Location = new System.Drawing.Point(27, 25);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.RowHeadersWidth = 51;
            this.dgvEmpleado.RowTemplate.Height = 24;
            this.dgvEmpleado.Size = new System.Drawing.Size(844, 405);
            this.dgvEmpleado.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "1er apellodo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "2er apellodo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Salario";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizarEmpleado.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.ForeColor = System.Drawing.Color.Gray;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(17, 543);
            this.btnActualizarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(237, 49);
            this.btnActualizarEmpleado.TabIndex = 31;
            this.btnActualizarEmpleado.Text = "Actualizar";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Gray;
            this.btnAtras.Location = new System.Drawing.Point(859, 543);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(237, 49);
            this.btnAtras.TabIndex = 30;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // PantallaMostrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaMostrarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaMostrarEmpleado";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}