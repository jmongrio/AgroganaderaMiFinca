
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
            this.components = new System.ComponentModel.Container();
            this.dgvRaza = new System.Windows.Forms.DataGridView();
            this.razaAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoRazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrpcionRazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razaAnimalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRaza
            // 
            this.dgvRaza.AutoGenerateColumns = false;
            this.dgvRaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoRazaDataGridViewTextBoxColumn,
            this.descrpcionRazaDataGridViewTextBoxColumn});
            this.dgvRaza.DataSource = this.razaAnimalBindingSource;
            this.dgvRaza.Location = new System.Drawing.Point(136, 75);
            this.dgvRaza.Name = "dgvRaza";
            this.dgvRaza.RowHeadersWidth = 51;
            this.dgvRaza.RowTemplate.Height = 24;
            this.dgvRaza.Size = new System.Drawing.Size(375, 178);
            this.dgvRaza.TabIndex = 0;
            // 
            // razaAnimalBindingSource
            // 
            this.razaAnimalBindingSource.DataSource = typeof(AgroganaderaMiFinca.Finca);
            // 
            // codigoRazaDataGridViewTextBoxColumn
            // 
            this.codigoRazaDataGridViewTextBoxColumn.DataPropertyName = "CodigoRaza";
            this.codigoRazaDataGridViewTextBoxColumn.HeaderText = "CodigoRaza";
            this.codigoRazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoRazaDataGridViewTextBoxColumn.Name = "codigoRazaDataGridViewTextBoxColumn";
            this.codigoRazaDataGridViewTextBoxColumn.Width = 125;
            // 
            // descrpcionRazaDataGridViewTextBoxColumn
            // 
            this.descrpcionRazaDataGridViewTextBoxColumn.DataPropertyName = "DescrpcionRaza";
            this.descrpcionRazaDataGridViewTextBoxColumn.HeaderText = "DescrpcionRaza";
            this.descrpcionRazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descrpcionRazaDataGridViewTextBoxColumn.Name = "descrpcionRazaDataGridViewTextBoxColumn";
            this.descrpcionRazaDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Gray;
            this.btnAtras.Location = new System.Drawing.Point(550, 388);
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
            this.btnActualizar.Location = new System.Drawing.Point(13, 388);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(237, 49);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // PantallaMostrarRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvRaza);
            this.Name = "PantallaMostrarRaza";
            this.Text = "PantallaMostrarRaza";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razaAnimalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoRazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrpcionRazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource razaAnimalBindingSource;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnActualizar;
    }
}