
namespace AgroganaderaMiFinca
{
    partial class PantallaMostrarRaza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaMostrarRaza));
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRaza = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaza)).BeginInit();
            this.SuspendLayout();
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
            this.btnAtras.TabIndex = 25;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Gray;
            this.btnActualizar.Location = new System.Drawing.Point(13, 564);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(237, 49);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dgvRaza);
            this.panel1.Location = new System.Drawing.Point(94, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 456);
            this.panel1.TabIndex = 33;
            // 
            // dgvRaza
            // 
            this.dgvRaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvRaza.Location = new System.Drawing.Point(27, 25);
            this.dgvRaza.Name = "dgvRaza";
            this.dgvRaza.RowHeadersWidth = 51;
            this.dgvRaza.RowTemplate.Height = 24;
            this.dgvRaza.Size = new System.Drawing.Size(844, 405);
            this.dgvRaza.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // PantallaMostrarRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaMostrarRaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raza de animales";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoRazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrpcionRazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}