namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            this.lblAdicionalNoturno = new System.Windows.Forms.Label();
            this.txtHorasMensais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoraNoturna = new System.Windows.Forms.TextBox();
            this.btnCalcularAdicional = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAdicionalNoturno
            // 
            this.lblAdicionalNoturno.AutoSize = true;
            this.lblAdicionalNoturno.BackColor = System.Drawing.Color.Transparent;
            this.lblAdicionalNoturno.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionalNoturno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdicionalNoturno.Location = new System.Drawing.Point(12, 85);
            this.lblAdicionalNoturno.Name = "lblAdicionalNoturno";
            this.lblAdicionalNoturno.Size = new System.Drawing.Size(205, 40);
            this.lblAdicionalNoturno.TabIndex = 0;
            this.lblAdicionalNoturno.Text = "Informe quantas horas voce\r\ntrabalha mensalmente:";
            // 
            // txtHorasMensais
            // 
            this.txtHorasMensais.Location = new System.Drawing.Point(16, 128);
            this.txtHorasMensais.Name = "txtHorasMensais";
            this.txtHorasMensais.Size = new System.Drawing.Size(100, 20);
            this.txtHorasMensais.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe quantas horas \r\nnoturna a mais trabalhou:";
            // 
            // txtHoraNoturna
            // 
            this.txtHoraNoturna.Location = new System.Drawing.Point(16, 205);
            this.txtHoraNoturna.Name = "txtHoraNoturna";
            this.txtHoraNoturna.Size = new System.Drawing.Size(100, 20);
            this.txtHoraNoturna.TabIndex = 3;
            // 
            // btnCalcularAdicional
            // 
            this.btnCalcularAdicional.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcularAdicional.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularAdicional.Location = new System.Drawing.Point(15, 237);
            this.btnCalcularAdicional.Name = "btnCalcularAdicional";
            this.btnCalcularAdicional.Size = new System.Drawing.Size(116, 42);
            this.btnCalcularAdicional.TabIndex = 4;
            this.btnCalcularAdicional.Text = "Calcular Adicional Noturno";
            this.btnCalcularAdicional.UseVisualStyleBackColor = false;
            this.btnCalcularAdicional.Click += new System.EventHandler(this.btnCalcularAdicional_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResultado.Location = new System.Drawing.Point(147, 250);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 17);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSalario.Location = new System.Drawing.Point(12, 29);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(161, 20);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Informe o seu sálario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(16, 52);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 7;
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.download3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 333);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularAdicional);
            this.Controls.Add(this.txtHoraNoturna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHorasMensais);
            this.Controls.Add(this.lblAdicionalNoturno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBeneficioAdicionalNoturno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benefício Adicional Noturno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionalNoturno;
        private System.Windows.Forms.TextBox txtHorasMensais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoraNoturna;
        private System.Windows.Forms.Button btnCalcularAdicional;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
    }
}