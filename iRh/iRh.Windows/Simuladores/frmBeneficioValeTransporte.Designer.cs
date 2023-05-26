namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
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
            this.btnCalcularValeTransporte = new System.Windows.Forms.Button();
            this.lblUtilizoMeioTransporte = new System.Windows.Forms.Label();
            this.checkBoxUtilizoTransporte = new System.Windows.Forms.CheckBox();
            this.checkBoxNaoUtilizoTransporte = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidadeVales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorPassagem = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.checkBoxNaoGostaria = new System.Windows.Forms.CheckBox();
            this.checkBoxSimGostaria = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSalario.Location = new System.Drawing.Point(22, 81);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(135, 20);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Informe seu Sálario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(25, 104);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(138, 25);
            this.txtSalario.TabIndex = 1;
            // 
            // btnCalcularValeTransporte
            // 
            this.btnCalcularValeTransporte.BackColor = System.Drawing.Color.DarkGray;
            this.btnCalcularValeTransporte.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularValeTransporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcularValeTransporte.Location = new System.Drawing.Point(26, 274);
            this.btnCalcularValeTransporte.Name = "btnCalcularValeTransporte";
            this.btnCalcularValeTransporte.Size = new System.Drawing.Size(138, 28);
            this.btnCalcularValeTransporte.TabIndex = 2;
            this.btnCalcularValeTransporte.Text = "Calcular Vale Transporte";
            this.btnCalcularValeTransporte.UseVisualStyleBackColor = false;
            this.btnCalcularValeTransporte.Click += new System.EventHandler(this.btnCalcularValeTransporte_Click);
            // 
            // lblUtilizoMeioTransporte
            // 
            this.lblUtilizoMeioTransporte.AutoSize = true;
            this.lblUtilizoMeioTransporte.BackColor = System.Drawing.Color.Transparent;
            this.lblUtilizoMeioTransporte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizoMeioTransporte.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUtilizoMeioTransporte.Location = new System.Drawing.Point(21, 18);
            this.lblUtilizoMeioTransporte.Name = "lblUtilizoMeioTransporte";
            this.lblUtilizoMeioTransporte.Size = new System.Drawing.Size(280, 20);
            this.lblUtilizoMeioTransporte.TabIndex = 3;
            this.lblUtilizoMeioTransporte.Text = "Utiliza meio de transporte público coletivo?";
            // 
            // checkBoxUtilizoTransporte
            // 
            this.checkBoxUtilizoTransporte.AutoSize = true;
            this.checkBoxUtilizoTransporte.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxUtilizoTransporte.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxUtilizoTransporte.Location = new System.Drawing.Point(30, 51);
            this.checkBoxUtilizoTransporte.Name = "checkBoxUtilizoTransporte";
            this.checkBoxUtilizoTransporte.Size = new System.Drawing.Size(45, 17);
            this.checkBoxUtilizoTransporte.TabIndex = 4;
            this.checkBoxUtilizoTransporte.Text = "SIM";
            this.checkBoxUtilizoTransporte.UseVisualStyleBackColor = false;
            this.checkBoxUtilizoTransporte.CheckedChanged += new System.EventHandler(this.checkBoxUtilizoTransporte_CheckedChanged);
            // 
            // checkBoxNaoUtilizoTransporte
            // 
            this.checkBoxNaoUtilizoTransporte.AutoSize = true;
            this.checkBoxNaoUtilizoTransporte.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxNaoUtilizoTransporte.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxNaoUtilizoTransporte.Location = new System.Drawing.Point(93, 51);
            this.checkBoxNaoUtilizoTransporte.Name = "checkBoxNaoUtilizoTransporte";
            this.checkBoxNaoUtilizoTransporte.Size = new System.Drawing.Size(49, 17);
            this.checkBoxNaoUtilizoTransporte.TabIndex = 5;
            this.checkBoxNaoUtilizoTransporte.Text = "NÃO";
            this.checkBoxNaoUtilizoTransporte.UseVisualStyleBackColor = false;
            this.checkBoxNaoUtilizoTransporte.CheckedChanged += new System.EventHandler(this.checkBoxNaoUtilizoTransporte_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade de vales necessários por dia:";
            // 
            // txtQuantidadeVales
            // 
            this.txtQuantidadeVales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeVales.Location = new System.Drawing.Point(26, 170);
            this.txtQuantidadeVales.Name = "txtQuantidadeVales";
            this.txtQuantidadeVales.Size = new System.Drawing.Size(100, 26);
            this.txtQuantidadeVales.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor da passagem:";
            // 
            // txtValorPassagem
            // 
            this.txtValorPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPassagem.Location = new System.Drawing.Point(25, 235);
            this.txtValorPassagem.Name = "txtValorPassagem";
            this.txtValorPassagem.Size = new System.Drawing.Size(100, 26);
            this.txtValorPassagem.TabIndex = 9;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(170, 278);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(71, 20);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // checkBoxNaoGostaria
            // 
            this.checkBoxNaoGostaria.AutoSize = true;
            this.checkBoxNaoGostaria.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxNaoGostaria.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxNaoGostaria.Location = new System.Drawing.Point(78, 360);
            this.checkBoxNaoGostaria.Name = "checkBoxNaoGostaria";
            this.checkBoxNaoGostaria.Size = new System.Drawing.Size(49, 17);
            this.checkBoxNaoGostaria.TabIndex = 13;
            this.checkBoxNaoGostaria.Text = "NÃO";
            this.checkBoxNaoGostaria.UseVisualStyleBackColor = false;
            this.checkBoxNaoGostaria.CheckedChanged += new System.EventHandler(this.checkBoxNaoGostaria_CheckedChanged);
            // 
            // checkBoxSimGostaria
            // 
            this.checkBoxSimGostaria.AutoSize = true;
            this.checkBoxSimGostaria.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSimGostaria.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxSimGostaria.Location = new System.Drawing.Point(29, 360);
            this.checkBoxSimGostaria.Name = "checkBoxSimGostaria";
            this.checkBoxSimGostaria.Size = new System.Drawing.Size(45, 17);
            this.checkBoxSimGostaria.TabIndex = 12;
            this.checkBoxSimGostaria.Text = "SIM";
            this.checkBoxSimGostaria.UseVisualStyleBackColor = false;
            this.checkBoxSimGostaria.CheckedChanged += new System.EventHandler(this.checkBoxSimGostaria_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(21, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gostaria que o sistema vericasse se \r\nvale a pena utilizar o vale transporte?";
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.download1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 411);
            this.Controls.Add(this.checkBoxNaoGostaria);
            this.Controls.Add(this.checkBoxSimGostaria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtValorPassagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidadeVales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxNaoUtilizoTransporte);
            this.Controls.Add(this.checkBoxUtilizoTransporte);
            this.Controls.Add(this.lblUtilizoMeioTransporte);
            this.Controls.Add(this.btnCalcularValeTransporte);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmBeneficioValeTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benefício Vale Transporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCalcularValeTransporte;
        private System.Windows.Forms.Label lblUtilizoMeioTransporte;
        private System.Windows.Forms.CheckBox checkBoxUtilizoTransporte;
        private System.Windows.Forms.CheckBox checkBoxNaoUtilizoTransporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidadeVales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorPassagem;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.CheckBox checkBoxNaoGostaria;
        private System.Windows.Forms.CheckBox checkBoxSimGostaria;
        private System.Windows.Forms.Label label3;
    }
}