namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioDepositoFgts
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcularFgts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(12, 21);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(183, 20);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Digite seu sálario abaixo:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(16, 46);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(138, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResultado.Location = new System.Drawing.Point(30, 106);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(56, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "resultado";
            this.lblResultado.Visible = false;
            // 
            // btnCalcularFgts
            // 
            this.btnCalcularFgts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcularFgts.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFgts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcularFgts.Location = new System.Drawing.Point(16, 72);
            this.btnCalcularFgts.Name = "btnCalcularFgts";
            this.btnCalcularFgts.Size = new System.Drawing.Size(91, 23);
            this.btnCalcularFgts.TabIndex = 3;
            this.btnCalcularFgts.Text = "Calcular FGTS";
            this.btnCalcularFgts.UseVisualStyleBackColor = false;
            this.btnCalcularFgts.Click += new System.EventHandler(this.btnCalcularFgts_Click);
            // 
            // frmBeneficioDepositoFgts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.download2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 235);
            this.Controls.Add(this.btnCalcularFgts);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBeneficioDepositoFgts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benefício Deposito FGTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcularFgts;
    }
}