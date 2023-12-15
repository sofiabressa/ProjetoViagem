namespace ProjetoViagem.App
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            crownMenuStrip1 = new ReaLTaiizor.Controls.CrownMenuStrip();
            pesquisarViagemToolStripMenuItem = new ToolStripMenuItem();
            criarViagemToolStripMenuItem = new ToolStripMenuItem();
            minhasViagensToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeVoosToolStripMenuItem1 = new ToolStripMenuItem();
            voosCadastradosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new ReaLTaiizor.Controls.Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel3 = new ReaLTaiizor.Controls.Panel();
            nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            crownMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // crownMenuStrip1
            // 
            crownMenuStrip1.BackColor = Color.FromArgb(60, 63, 65);
            crownMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownMenuStrip1.Items.AddRange(new ToolStripItem[] { pesquisarViagemToolStripMenuItem, cadastrosToolStripMenuItem, sairToolStripMenuItem });
            crownMenuStrip1.Location = new Point(3, 64);
            crownMenuStrip1.Name = "crownMenuStrip1";
            crownMenuStrip1.Padding = new Padding(3, 2, 0, 2);
            crownMenuStrip1.Size = new Size(794, 24);
            crownMenuStrip1.TabIndex = 1;
            crownMenuStrip1.Text = "crownMenuStrip1";
            // 
            // pesquisarViagemToolStripMenuItem
            // 
            pesquisarViagemToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            pesquisarViagemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarViagemToolStripMenuItem, minhasViagensToolStripMenuItem });
            pesquisarViagemToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            pesquisarViagemToolStripMenuItem.Name = "pesquisarViagemToolStripMenuItem";
            pesquisarViagemToolStripMenuItem.Size = new Size(59, 20);
            pesquisarViagemToolStripMenuItem.Text = "Viagem";
            // 
            // criarViagemToolStripMenuItem
            // 
            criarViagemToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            criarViagemToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            criarViagemToolStripMenuItem.Name = "criarViagemToolStripMenuItem";
            criarViagemToolStripMenuItem.Size = new Size(157, 22);
            criarViagemToolStripMenuItem.Text = "Nova Viagem";
            criarViagemToolStripMenuItem.Click += criarViagemToolStripMenuItem_Click;
            // 
            // minhasViagensToolStripMenuItem
            // 
            minhasViagensToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            minhasViagensToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            minhasViagensToolStripMenuItem.Name = "minhasViagensToolStripMenuItem";
            minhasViagensToolStripMenuItem.Size = new Size(157, 22);
            minhasViagensToolStripMenuItem.Text = "Minhas Viagens";
            minhasViagensToolStripMenuItem.Click += minhasViagensToolStripMenuItem_Click;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeVoosToolStripMenuItem1, voosCadastradosToolStripMenuItem });
            cadastrosToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeVoosToolStripMenuItem1
            // 
            cadastroDeVoosToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            cadastroDeVoosToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            cadastroDeVoosToolStripMenuItem1.Name = "cadastroDeVoosToolStripMenuItem1";
            cadastroDeVoosToolStripMenuItem1.Size = new Size(180, 22);
            cadastroDeVoosToolStripMenuItem1.Text = "Cadastro de voos";
            cadastroDeVoosToolStripMenuItem1.Click += cadastroDeVoosToolStripMenuItem1_Click;
            // 
            // voosCadastradosToolStripMenuItem
            // 
            voosCadastradosToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            voosCadastradosToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            voosCadastradosToolStripMenuItem.Name = "voosCadastradosToolStripMenuItem";
            voosCadastradosToolStripMenuItem.Size = new Size(180, 22);
            voosCadastradosToolStripMenuItem.Text = "Voos cadastrados";
            voosCadastradosToolStripMenuItem.Click += voosCadastradosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            sairToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 63, 65);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(panel3);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(-5, -4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(809, 92);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 2;
            panel1.Text = "panel1";
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.DimGray;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(670, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Controls.Add(nightHeaderLabel1);
            panel3.EdgeColor = Color.FromArgb(32, 41, 50);
            panel3.Location = new Point(8, 4);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(985, 61);
            panel3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel3.TabIndex = 3;
            panel3.Text = "panel3";
            // 
            // nightHeaderLabel1
            // 
            nightHeaderLabel1.AutoSize = true;
            nightHeaderLabel1.BackColor = Color.DimGray;
            nightHeaderLabel1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            nightHeaderLabel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel1.LeftSideForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel1.Location = new Point(269, 12);
            nightHeaderLabel1.Name = "nightHeaderLabel1";
            nightHeaderLabel1.RightSideForeColor = Color.FromArgb(170, 171, 176);
            nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            nightHeaderLabel1.Size = new Size(245, 44);
            nightHeaderLabel1.TabIndex = 4;
            nightHeaderLabel1.Text = "Projeto Viagem";
            nightHeaderLabel1.TextAlign = ContentAlignment.BottomLeft;
            nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nightHeaderLabel1.UseCompatibleTextRendering = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(crownMenuStrip1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            crownMenuStrip1.ResumeLayout(false);
            crownMenuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownMenuStrip crownMenuStrip1;
        private ToolStripMenuItem pesquisarViagemToolStripMenuItem;
        private ToolStripMenuItem criarViagemToolStripMenuItem;
        private ToolStripMenuItem minhasViagensToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeVoosToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
        private ReaLTaiizor.Controls.Panel panel3;
        private ToolStripMenuItem voosCadastradosToolStripMenuItem;
    }
}