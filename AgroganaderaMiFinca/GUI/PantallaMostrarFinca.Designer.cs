
namespace AgroganaderaMiFinca
{
    partial class PantallaMostrarFinca
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaMostrarFinca));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFinca = new System.Windows.Forms.DataGridView();
            this.btnActualizarFincas = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.fincaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroFincaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreFincaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanoFincaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionFincaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fincaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dgvFinca);
            this.panel1.Location = new System.Drawing.Point(114, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 456);
            this.panel1.TabIndex = 0;
            // 
            // dgvFinca
            // 
            this.dgvFinca.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroFincaDataGridViewTextBoxColumn,
            this.nombreFincaDataGridViewTextBoxColumn,
            this.tamanoFincaDataGridViewTextBoxColumn,
            this.direccionFincaDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.dgvFinca.DataSource = this.fincaBindingSource;
            this.dgvFinca.Location = new System.Drawing.Point(29, 17);
            this.dgvFinca.Name = "dgvFinca";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinca.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinca.RowHeadersWidth = 51;
            this.dgvFinca.RowTemplate.Height = 24;
            this.dgvFinca.Size = new System.Drawing.Size(705, 390);
            this.dgvFinca.TabIndex = 0;
            // 
            // btnActualizarFincas
            // 
            this.btnActualizarFincas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizarFincas.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizarFincas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarFincas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarFincas.ForeColor = System.Drawing.Color.Gray;
            this.btnActualizarFincas.Location = new System.Drawing.Point(20, 564);
            this.btnActualizarFincas.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarFincas.Name = "btnActualizarFincas";
            this.btnActualizarFincas.Size = new System.Drawing.Size(237, 49);
            this.btnActualizarFincas.TabIndex = 25;
            this.btnActualizarFincas.Text = "Actualizar";
            this.btnActualizarFincas.UseVisualStyleBackColor = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Gray;
            this.btnAtras.Location = new System.Drawing.Point(862, 564);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(237, 49);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // fincaBindingSource
            // 
            this.fincaBindingSource.DataSource = typeof(AgroganaderaMiFinca.Finca);
            // 
            // numeroFincaDataGridViewTextBoxColumn
            // 
            this.numeroFincaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFinca";
            this.numeroFincaDataGridViewTextBoxColumn.HeaderText = "NumeroFinca";
            this.numeroFincaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroFincaDataGridViewTextBoxColumn.Name = "numeroFincaDataGridViewTextBoxColumn";
            this.numeroFincaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreFincaDataGridViewTextBoxColumn
            // 
            this.nombreFincaDataGridViewTextBoxColumn.DataPropertyName = "NombreFinca";
            this.nombreFincaDataGridViewTextBoxColumn.HeaderText = "NombreFinca";
            this.nombreFincaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreFincaDataGridViewTextBoxColumn.Name = "nombreFincaDataGridViewTextBoxColumn";
            this.nombreFincaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tamanoFincaDataGridViewTextBoxColumn
            // 
            this.tamanoFincaDataGridViewTextBoxColumn.DataPropertyName = "TamanoFinca";
            this.tamanoFincaDataGridViewTextBoxColumn.HeaderText = "TamanoFinca";
            this.tamanoFincaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tamanoFincaDataGridViewTextBoxColumn.Name = "tamanoFincaDataGridViewTextBoxColumn";
            this.tamanoFincaDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionFincaDataGridViewTextBoxColumn
            // 
            this.direccionFincaDataGridViewTextBoxColumn.DataPropertyName = "DireccionFinca";
            this.direccionFincaDataGridViewTextBoxColumn.HeaderText = "DireccionFinca";
            this.direccionFincaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionFincaDataGridViewTextBoxColumn.Name = "direccionFincaDataGridViewTextBoxColumn";
            this.direccionFincaDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // PantallaMostrarFinca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 626);
            this.Controls.Add(this.btnActualizarFincas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaMostrarFinca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaMostrarFinca";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fincaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFinca;
        private System.Windows.Forms.Button btnActualizarFincas;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFincaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreFincaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanoFincaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionFincaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fincaBindingSource;
    }
}