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
            this.txtAdicionalNoturno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAdicionalNoturno
            // 
            this.lblAdicionalNoturno.AutoSize = true;
            this.lblAdicionalNoturno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionalNoturno.Location = new System.Drawing.Point(12, 9);
            this.lblAdicionalNoturno.Name = "lblAdicionalNoturno";
            this.lblAdicionalNoturno.Size = new System.Drawing.Size(126, 17);
            this.lblAdicionalNoturno.TabIndex = 0;
            this.lblAdicionalNoturno.Text = "Adicional Noturno";
            // 
            // txtAdicionalNoturno
            // 
            this.txtAdicionalNoturno.Location = new System.Drawing.Point(15, 29);
            this.txtAdicionalNoturno.Name = "txtAdicionalNoturno";
            this.txtAdicionalNoturno.Size = new System.Drawing.Size(100, 20);
            this.txtAdicionalNoturno.TabIndex = 1;
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAdicionalNoturno);
            this.Controls.Add(this.lblAdicionalNoturno);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benefício Adicional Noturno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionalNoturno;
        private System.Windows.Forms.TextBox txtAdicionalNoturno;
    }
}