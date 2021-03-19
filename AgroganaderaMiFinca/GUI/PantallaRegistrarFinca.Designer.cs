
namespace AgroganaderaMiFinca
{
    partial class PantallaRegistrarFinca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistrarFinca));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroFinca = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreFinca = new System.Windows.Forms.MaskedTextBox();
            this.txtTamanoFinca = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccionFinca = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pnlRegistroFinca = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarFinca = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRegistroFinca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de la finca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la finca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(38, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamaño de la finca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(21, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección de la finca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(150, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // txtNumeroFinca
            // 
            this.txtNumeroFinca.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNumeroFinca.ForeColor = System.Drawing.Color.Gray;
            this.txtNumeroFinca.Location = new System.Drawing.Point(265, 29);
            this.txtNumeroFinca.Name = "txtNumeroFinca";
            this.txtNumeroFinca.Size = new System.Drawing.Size(226, 31);
            this.txtNumeroFinca.TabIndex = 5;
            this.txtNumeroFinca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroFinca.TextChanged += new System.EventHandler(this.txtNumeroFinca_TextChanged);
            // 
            // txtNombreFinca
            // 
            this.txtNombreFinca.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNombreFinca.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreFinca.Location = new System.Drawing.Point(265, 80);
            this.txtNombreFinca.Name = "txtNombreFinca";
            this.txtNombreFinca.Size = new System.Drawing.Size(226, 31);
            this.txtNombreFinca.TabIndex = 6;
            this.txtNombreFinca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreFinca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtNombreFinca_MaskInputRejected);
            // 
            // txtTamanoFinca
            // 
            this.txtTamanoFinca.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTamanoFinca.ForeColor = System.Drawing.Color.Gray;
            this.txtTamanoFinca.Location = new System.Drawing.Point(265, 129);
            this.txtTamanoFinca.Name = "txtTamanoFinca";
            this.txtTamanoFinca.Size = new System.Drawing.Size(226, 31);
            this.txtTamanoFinca.TabIndex = 7;
            this.txtTamanoFinca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTamanoFinca.TextChanged += new System.EventHandler(this.txtTamanoFinca_TextChanged);
            // 
            // txtDireccionFinca
            // 
            this.txtDireccionFinca.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDireccionFinca.ForeColor = System.Drawing.Color.Gray;
            this.txtDireccionFinca.Location = new System.Drawing.Point(265, 181);
            this.txtDireccionFinca.Name = "txtDireccionFinca";
            this.txtDireccionFinca.Size = new System.Drawing.Size(226, 31);
            this.txtDireccionFinca.TabIndex = 8;
            this.txtDireccionFinca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDireccionFinca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefono.Location = new System.Drawing.Point(265, 234);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(226, 31);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.TextAlignChanged += new System.EventHandler(this.txtTelefono_TextAlignChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(508, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "héctareas.";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Gray;
            this.btnAtras.Location = new System.Drawing.Point(644, 457);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(178, 40);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pnlRegistroFinca
            // 
            this.pnlRegistroFinca.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlRegistroFinca.Controls.Add(this.txtNumeroFinca);
            this.pnlRegistroFinca.Controls.Add(this.label1);
            this.pnlRegistroFinca.Controls.Add(this.label6);
            this.pnlRegistroFinca.Controls.Add(this.label2);
            this.pnlRegistroFinca.Controls.Add(this.txtTelefono);
            this.pnlRegistroFinca.Controls.Add(this.txtNombreFinca);
            this.pnlRegistroFinca.Controls.Add(this.txtDireccionFinca);
            this.pnlRegistroFinca.Controls.Add(this.txtTamanoFinca);
            this.pnlRegistroFinca.Controls.Add(this.label3);
            this.pnlRegistroFinca.Controls.Add(this.label5);
            this.pnlRegistroFinca.Controls.Add(this.label4);
            this.pnlRegistroFinca.Location = new System.Drawing.Point(87, 133);
            this.pnlRegistroFinca.Name = "pnlRegistroFinca";
            this.pnlRegistroFinca.Size = new System.Drawing.Size(642, 286);
            this.pnlRegistroFinca.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(494, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Registro de Finca";
            // 
            // btnRegistrarFinca
            // 
            this.btnRegistrarFinca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistrarFinca.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistrarFinca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarFinca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarFinca.ForeColor = System.Drawing.Color.Gray;
            this.btnRegistrarFinca.Location = new System.Drawing.Point(12, 457);
            this.btnRegistrarFinca.Name = "btnRegistrarFinca";
            this.btnRegistrarFinca.Size = new System.Drawing.Size(178, 40);
            this.btnRegistrarFinca.TabIndex = 15;
            this.btnRegistrarFinca.Text = "Registrar";
            this.btnRegistrarFinca.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PantallaRegistrarFinca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 509);
            this.Controls.Add(this.btnRegistrarFinca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlRegistroFinca);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaRegistrarFinca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Finca";
            this.Load += new System.EventHandler(this.PantallaRegistrarFinca_Load);
            this.pnlRegistroFinca.ResumeLayout(false);
            this.pnlRegistroFinca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtNumeroFinca;
        private System.Windows.Forms.MaskedTextBox txtNombreFinca;
        private System.Windows.Forms.MaskedTextBox txtTamanoFinca;
        private System.Windows.Forms.MaskedTextBox txtDireccionFinca;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel pnlRegistroFinca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarFinca;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}