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
            this.menuPrincipal.AllowItemReorder = true;
            this.menuPrincipal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuPrincipal.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFuncionarios,
            this.simuladoresToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(839, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem});
            this.menuFuncionarios.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(73, 20);
            this.menuFuncionarios.Text = " Cadastros";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionariosToolStripMenuItem.Image = global::iRh.Windows.Properties.Resources.edit_user_student_staff_person_icon_icons_com_75492;
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.simuladoresToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simuladoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.simuladoresToolStripMenuItem.Name = "simuladoresToolStripMenuItem";
            this.simuladoresToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.simuladoresToolStripMenuItem.Text = "Simuladores";
            // 
            // menuDescontoInss
            // 
            this.menuDescontoInss.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDescontoInss.Image = global::iRh.Windows.Properties.Resources.icons8_buscador_de_desconto_50;
            this.menuDescontoInss.Name = "menuDescontoInss";
            this.menuDescontoInss.Size = new System.Drawing.Size(248, 22);
            this.menuDescontoInss.Text = "Desconto de INSS";
            this.menuDescontoInss.Click += new System.EventHandler(this.menuDescontoInss_Click);
            // 
            // menuDescontoIrrf
            // 
            this.menuDescontoIrrf.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDescontoIrrf.Image = global::iRh.Windows.Properties.Resources.icons8_buscador_de_desconto_50__1_;
            this.menuDescontoIrrf.Name = "menuDescontoIrrf";
            this.menuDescontoIrrf.Size = new System.Drawing.Size(248, 22);
            this.menuDescontoIrrf.Text = "Desconto de IRRF";
            this.menuDescontoIrrf.Click += new System.EventHandler(this.menuDescontoIrrf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // menuBeneficioAdcionalNoturno
            // 
            this.menuBeneficioAdcionalNoturno.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBeneficioAdcionalNoturno.Image = global::iRh.Windows.Properties.Resources._482927;
            this.menuBeneficioAdcionalNoturno.Name = "menuBeneficioAdcionalNoturno";
            this.menuBeneficioAdcionalNoturno.Size = new System.Drawing.Size(248, 22);
            this.menuBeneficioAdcionalNoturno.Text = "Beneficio de Adcional Noturno";
            this.menuBeneficioAdcionalNoturno.Click += new System.EventHandler(this.menuBeneficioAdicionalNoturno_Click);
            // 
            // menuBeneficioDepositoFgts
            // 
            this.menuBeneficioDepositoFgts.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBeneficioDepositoFgts.Image = global::iRh.Windows.Properties.Resources.download__5_;
            this.menuBeneficioDepositoFgts.Name = "menuBeneficioDepositoFgts";
            this.menuBeneficioDepositoFgts.Size = new System.Drawing.Size(248, 22);
            this.menuBeneficioDepositoFgts.Text = "Beneficio de Deposito FGTS";
            this.menuBeneficioDepositoFgts.Click += new System.EventHandler(this.menuBeneficioDepositoFgts_Click);
            // 
            // menuBeneficioFerias
            // 
            this.menuBeneficioFerias.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBeneficioFerias.Image = global::iRh.Windows.Properties.Resources.png_transparent_computer_icons_font_holiday_icon_angle_triangle_logo;
            this.menuBeneficioFerias.Name = "menuBeneficioFerias";
            this.menuBeneficioFerias.Size = new System.Drawing.Size(248, 22);
            this.menuBeneficioFerias.Text = "Beneficio de Férias";
            this.menuBeneficioFerias.Click += new System.EventHandler(this.menuBeneficioFerias_Click);
            // 
            // menuBeneficioHoraExtra
            // 
            this.menuBeneficioHoraExtra.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBeneficioHoraExtra.Image = global::iRh.Windows.Properties.Resources.png_transparent_overtime_computer_icons_others_cdr_text_trademark;
            this.menuBeneficioHoraExtra.Name = "menuBeneficioHoraExtra";
            this.menuBeneficioHoraExtra.Size = new System.Drawing.Size(248, 22);
            this.menuBeneficioHoraExtra.Text = "Beneficio de Hora Extra";
            this.menuBeneficioHoraExtra.Click += new System.EventHandler(this.menuBeneficioHoraExtra_Click);
            // 
            // menuBeneficioPericulosidade
            // 
            this.menuBeneficioPericulosidade.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBeneficioPericulosidade.Image = global::iRh.Windows.Properties.Resources._91357;
            this.menuBeneficioPericulosidade.Name = "menuBeneficioPericulosidade";
            this.menuBeneficioPericulosidade.Size = new System.Drawing.Size(248, 22);
            this.menuBeneficioPericulosidade.Text = "Beneficio de Periculosidade";
            this.menuBeneficioPericulosidade.Click += new System.EventHandler(this.menuBeneficioPericulosidade_Click);
            // 
            // menuBeneficioPis
            // 
            this.menuBeneficioPis.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBeneficioPis.Image = global::iRh.Windows.Properties.Resources.png_clipart_coin_money_bag_computer_icons_coin_text_trademark;
            this.menuBeneficioPis.Name = "menuBeneficioPis";
            this.menuBeneficioPis.Size = new System.Drawing.Size(248, 22);
            this.menuBeneficioPis.Text = "Beneficio de PIS";
            this.menuBeneficioPis.Click += new System.EventHandler(this.menuBeneficioPis_Click);
            // 
            // menuBeneficioSeguroDesemprego
            // 
            this.menuBeneficioSeguroDesemprego.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBeneficioSeguroDesemprego.Image = global::iRh.Windows.Properties.Resources.download__10_;
            this.menuBeneficioSeguroDesemprego.Name = "menuBeneficioSeguroDesemprego";
            this.menuBeneficioSeguroDesemprego.Size = new System.Drawing.Size(248, 22);
            this.menuBeneficioSeguroDesemprego.Text = "Beneficio de Seguro Desemprego";
            this.menuBeneficioSeguroDesemprego.Click += new System.EventHandler(this.menuBeneficioSeguroDesemprego_Click);
            // 
            // menuBeneficioValeTransporte
            // 
            this.menuBeneficioValeTransporte.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBeneficioValeTransporte.Image = global::iRh.Windows.Properties.Resources.download__9_1;
            this.menuBeneficioValeTransporte.Name = "menuBeneficioValeTransporte";
            this.menuBeneficioValeTransporte.Size = new System.Drawing.Size(248, 22);
            this.menuBeneficioValeTransporte.Text = "Beneficio de Vale Transporte";
            this.menuBeneficioValeTransporte.Click += new System.EventHandler(this.menuBeneficioValeTransporte_Click);
            // 
            // PrincipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 413);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "PrincipalMdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  WN SOFTWARE";
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