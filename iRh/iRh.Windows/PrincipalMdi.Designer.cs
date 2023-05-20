namespace iRh.Windows
{
    partial class PrincipalMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMdi));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoInss = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescontoIrrf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBeneficioAdcionalNoturno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioDepositoFgts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioFerias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioHoraExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPericulosidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioPis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioSeguroDesemprego = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeneficioValeTransporte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFuncionarios,
            this.simuladoresToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(719, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem});
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(74, 20);
            this.menuFuncionarios.Text = " Cadastros";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Image = global::iRh.Windows.Properties.Resources.edit_user_student_staff_person_icon_icons_com_75492;
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionários";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // simuladoresToolStripMenuItem
            // 
            this.simuladoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDescontoInss,
            this.menuDescontoIrrf,
            this.toolStripSeparator1,
            this.menuBeneficioAdcionalNoturno,
            this.menuBeneficioDepositoFgts,
            this.menuBeneficioFerias,
            this.menuBeneficioHoraExtra,
            this.menuBeneficioPericulosidade,
            this.menuBeneficioPis,
            this.menuBeneficioSeguroDesemprego,
            this.menuBeneficioValeTransporte});
            this.simuladoresToolStripMenuItem.Name = "simuladoresToolStripMenuItem";
            this.simuladoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.simuladoresToolStripMenuItem.Text = "Simuladores";
            // 
            // menuDescontoInss
            // 
            this.menuDescontoInss.Image = global::iRh.Windows.Properties.Resources.icons8_buscador_de_desconto_50;
            this.menuDescontoInss.Name = "menuDescontoInss";
            this.menuDescontoInss.Size = new System.Drawing.Size(249, 22);
            this.menuDescontoInss.Text = "Desconto de INSS";
            this.menuDescontoInss.Click += new System.EventHandler(this.menuDescontoInss_Click);
            // 
            // menuDescontoIrrf
            // 
            this.menuDescontoIrrf.Image = global::iRh.Windows.Properties.Resources.icons8_buscador_de_desconto_50__1_;
            this.menuDescontoIrrf.Name = "menuDescontoIrrf";
            this.menuDescontoIrrf.Size = new System.Drawing.Size(249, 22);
            this.menuDescontoIrrf.Text = "Desconto de IRRF";
            this.menuDescontoIrrf.Click += new System.EventHandler(this.menuDescontoIrrf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // menuBeneficioAdcionalNoturno
            // 
            this.menuBeneficioAdcionalNoturno.Name = "menuBeneficioAdcionalNoturno";
            this.menuBeneficioAdcionalNoturno.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioAdcionalNoturno.Text = "Beneficio de Adcional Noturno";
            this.menuBeneficioAdcionalNoturno.Click += new System.EventHandler(this.menuBeneficioAdicionalNoturno_Click);
            // 
            // menuBeneficioDepositoFgts
            // 
            this.menuBeneficioDepositoFgts.Name = "menuBeneficioDepositoFgts";
            this.menuBeneficioDepositoFgts.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioDepositoFgts.Text = "Beneficio de Deposito FGTS";
            this.menuBeneficioDepositoFgts.Click += new System.EventHandler(this.menuBeneficioDepositoFgts_Click);
            // 
            // menuBeneficioFerias
            // 
            this.menuBeneficioFerias.Name = "menuBeneficioFerias";
            this.menuBeneficioFerias.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioFerias.Text = "Beneficio de Férias";
            this.menuBeneficioFerias.Click += new System.EventHandler(this.menuBeneficioFerias_Click);
            // 
            // menuBeneficioHoraExtra
            // 
            this.menuBeneficioHoraExtra.Name = "menuBeneficioHoraExtra";
            this.menuBeneficioHoraExtra.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioHoraExtra.Text = "Beneficio de Hora Extra";
            this.menuBeneficioHoraExtra.Click += new System.EventHandler(this.menuBeneficioHoraExtra_Click);
            // 
            // menuBeneficioPericulosidade
            // 
            this.menuBeneficioPericulosidade.Name = "menuBeneficioPericulosidade";
            this.menuBeneficioPericulosidade.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioPericulosidade.Text = "Beneficio de Periculosidade";
            this.menuBeneficioPericulosidade.Click += new System.EventHandler(this.menuBeneficioPericulosidade_Click);
            // 
            // menuBeneficioPis
            // 
            this.menuBeneficioPis.Name = "menuBeneficioPis";
            this.menuBeneficioPis.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioPis.Text = "Beneficio de PIS";
            this.menuBeneficioPis.Click += new System.EventHandler(this.menuBeneficioPis_Click);
            // 
            // menuBeneficioSeguroDesemprego
            // 
            this.menuBeneficioSeguroDesemprego.Name = "menuBeneficioSeguroDesemprego";
            this.menuBeneficioSeguroDesemprego.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioSeguroDesemprego.Text = "Beneficio de Seguro Desemprego";
            this.menuBeneficioSeguroDesemprego.Click += new System.EventHandler(this.menuBeneficioSeguroDesemprego_Click);
            // 
            // menuBeneficioValeTransporte
            // 
            this.menuBeneficioValeTransporte.Name = "menuBeneficioValeTransporte";
            this.menuBeneficioValeTransporte.Size = new System.Drawing.Size(249, 22);
            this.menuBeneficioValeTransporte.Text = "Beneficio de Vale Transporte";
            this.menuBeneficioValeTransporte.Click += new System.EventHandler(this.menuBeneficioValeTransporte_Click);
            // 
            // PrincipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources._4_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 413);
            this.Controls.Add(this.menuPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "PrincipalMdi";
            this.Text = "WN SOFTWARES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Move += new System.EventHandler(this.PrincipalMdi_Move);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simuladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoInss;
        private System.Windows.Forms.ToolStripMenuItem menuDescontoIrrf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioFerias;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioSeguroDesemprego;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioValeTransporte;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPis;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioDepositoFgts;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioAdcionalNoturno;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioHoraExtra;
        private System.Windows.Forms.ToolStripMenuItem menuBeneficioPericulosidade;
    }
}