
namespace AgroganaderaMiFinca
{
    partial class PantallaRegistrarRaza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistrarRaza));
            this.pnlRegistroRaza = new System.Windows.Forms.Panel();
            this.txtDescripcionRaza = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoRaza = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrarRaza = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRegistroRaza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistroRaza
            // 
            this.pnlRegistroRaza.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlRegistroRaza.Controls.Add(this.txtDescripcionRaza);
            this.pnlRegistroRaza.Controls.Add(this.label3);
            this.pnlRegistroRaza.Controls.Add(this.label2);
            this.pnlRegistroRaza.Controls.Add(this.txtCodigoRaza);
            this.pnlRegistroRaza.Location = new System.Drawing.Point(128, 137);
            this.pnlRegistroRaza.Name = "pnlRegistroRaza";
            this.pnlRegistroRaza.Size = new System.Drawing.Size(856, 352);
            this.pnlRegistroRaza.TabIndex = 1;
            this.pnlRegistroRaza.MouseLeave += new System.EventHandler(this.pnlRegistroRaza_MouseLeave);
            // 
            // txtDescripcionRaza
            // 
            this.txtDescripcionRaza.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDescripcionRaza.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcionRaza.Location = new System.Drawing.Point(415, 197);
            this.txtDescripcionRaza.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionRaza.Name = "txtDescripcionRaza";
            this.txtDescripcionRaza.Size = new System.Drawing.Size(217, 36);
            this.txtDescripcionRaza.TabIndex = 22;
            this.txtDescripcionRaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescripcionRaza.TextChanged += new System.EventHandler(this.txtDescripcionRaza_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(111, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descripción de raza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(176, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Código de raza:";
            // 
            // txtCodigoRaza
            // 
            this.txtCodigoRaza.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCodigoRaza.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigoRaza.Location = new System.Drawing.Point(415, 107);
            this.txtCodigoRaza.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoRaza.Name = "txtCodigoRaza";
            this.txtCodigoRaza.Size = new System.Drawing.Size(217, 36);
            this.txtCodigoRaza.TabIndex = 18;
            this.txtCodigoRaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoRaza.TextChanged += new System.EventHandler(this.txtCodigoRaza_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(698, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(401, 48);
            this.label8.TabIndex = 23;
            this.label8.Text = "Registro de Raza";
            // 
            // btnRegistrarRaza
            // 
            this.btnRegistrarRaza.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistrarRaza.Enabled = false;
            this.btnRegistrarRaza.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistrarRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRaza.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRaza.ForeColor = System.Drawing.Color.Gray;
            this.btnRegistrarRaza.Location = new System.Drawing.Point(13, 564);
            this.btnRegistrarRaza.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarRaza.Name = "btnRegistrarRaza";
            this.btnRegistrarRaza.Size = new System.Drawing.Size(237, 49);
            this.btnRegistrarRaza.TabIndex = 25;
            this.btnRegistrarRaza.Text = "Registrar";
            this.btnRegistrarRaza.UseVisualStyleBackColor = false;
            this.btnRegistrarRaza.Click += new System.EventHandler(this.btnRegistrarRaza_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Gray;
            this.btnAtras.Location = new System.Drawing.Point(855, 564);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(237, 49);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PantallaRegistrarRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 626);
            this.Controls.Add(this.btnRegistrarRaza);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlRegistroRaza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaRegistrarRaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de raza";
            this.pnlRegistroRaza.ResumeLayout(false);
            this.pnlRegistroRaza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistroRaza;
        private System.Windows.Forms.MaskedTextBox txtDescripcionRaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCodigoRaza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrarRaza;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}