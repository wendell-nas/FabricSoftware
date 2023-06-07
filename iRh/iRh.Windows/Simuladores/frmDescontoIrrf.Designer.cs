namespace iRh.Windows.Simuladores
{
    partial class frmDescontoIrrf
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelaResultado = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe seu Salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(16, 32);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(28, 58);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular IRRF";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResultado.Location = new System.Drawing.Point(32, 84);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "resultado";
            this.lblResultado.Visible = false;
            // 
            // panelaResultado
            // 
            this.panelaResultado.BackColor = System.Drawing.Color.Transparent;
            this.panelaResultado.Location = new System.Drawing.Point(28, 84);
            this.panelaResultado.Name = "panelaResultado";
            this.panelaResultado.Size = new System.Drawing.Size(87, 30);
            this.panelaResultado.TabIndex = 8;
            this.panelaResultado.Visible = false;
            // 
            // frmDescontoIrrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.download2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 328);
            this.Controls.Add(this.panelaResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Name = "frmDescontoIrrf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desconto IRRF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panelaResultado;
    }
}