namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtVezesQueJaSolicitou = new System.Windows.Forms.TextBox();
            this.txtMesesTrabalhados = new System.Windows.Forms.TextBox();
            this.btnVerificarAgora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME QUANTAS VEZES \r\nJÁ SOLICITOU O BENEFICIO?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "FAVOR INFORMAR MESES DE CARTEIRA \r\nASSINADA NO EMPREGO ATUAL:";
            // 
            // txtVezesQueJaSolicitou
            // 
            this.txtVezesQueJaSolicitou.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVezesQueJaSolicitou.Location = new System.Drawing.Point(15, 64);
            this.txtVezesQueJaSolicitou.Name = "txtVezesQueJaSolicitou";
            this.txtVezesQueJaSolicitou.Size = new System.Drawing.Size(93, 22);
            this.txtVezesQueJaSolicitou.TabIndex = 2;
            // 
            // txtMesesTrabalhados
            // 
            this.txtMesesTrabalhados.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesesTrabalhados.Location = new System.Drawing.Point(15, 139);
            this.txtMesesTrabalhados.Name = "txtMesesTrabalhados";
            this.txtMesesTrabalhados.Size = new System.Drawing.Size(93, 22);
            this.txtMesesTrabalhados.TabIndex = 3;
            // 
            // btnVerificarAgora
            // 
            this.btnVerificarAgora.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerificarAgora.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarAgora.Location = new System.Drawing.Point(15, 178);
            this.btnVerificarAgora.Name = "btnVerificarAgora";
            this.btnVerificarAgora.Size = new System.Drawing.Size(93, 30);
            this.btnVerificarAgora.TabIndex = 4;
            this.btnVerificarAgora.Text = "Verificar Agora";
            this.btnVerificarAgora.UseVisualStyleBackColor = false;
            this.btnVerificarAgora.Click += new System.EventHandler(this.btnVerificarAgora_Click);
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 248);
            this.Controls.Add(this.btnVerificarAgora);
            this.Controls.Add(this.txtMesesTrabalhados);
            this.Controls.Add(this.txtVezesQueJaSolicitou);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBeneficioSeguroDesemprego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BenefÍcio Seguro Desemprego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVezesQueJaSolicitou;
        private System.Windows.Forms.TextBox txtMesesTrabalhados;
        private System.Windows.Forms.Button btnVerificarAgora;
    }
}