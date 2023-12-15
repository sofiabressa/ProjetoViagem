namespace ProjetoViagem.App.Base
{
    partial class CadastroBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            panel1 = new Panel();
            txtId = new ReaLTaiizor.Controls.HopeTextBox();
            btnCancelar = new ReaLTaiizor.Controls.HopeSimpleButton();
            txtNome = new ReaLTaiizor.Controls.HopeTextBox();
            btnCadastrar = new ReaLTaiizor.Controls.HopeSimpleButton();
            txtSenha = new ReaLTaiizor.Controls.HopeTextBox();
            txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1.SuspendLayout();
            nightForm1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 58, 61);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(107, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 261);
            panel1.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlDarkDark;
            txtId.BaseColor = Color.FromArgb(44, 55, 66);
            txtId.BorderColorA = Color.FromArgb(64, 158, 255);
            txtId.BorderColorB = SystemColors.ControlDarkDark;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.ForeColor = Color.FromArgb(48, 49, 51);
            txtId.Hint = "Id";
            txtId.Location = new Point(183, 147);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.ScrollBars = ScrollBars.None;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(62, 38);
            txtId.TabIndex = 6;
            txtId.TabStop = false;
            txtId.UseSystemPasswordChar = false;
            txtId.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.MediumSeaGreen;
            btnCancelar.BorderColor = Color.FromArgb(220, 223, 230);
            btnCancelar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCancelar.DangerColor = Color.FromArgb(245, 108, 108);
            btnCancelar.DefaultClickColor = Color.FromArgb(43, 133, 228);
            btnCancelar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.HoverClickTextColor = Color.FromArgb(43, 133, 228);
            btnCancelar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCancelar.InfoColor = Color.FromArgb(144, 147, 153);
            btnCancelar.Location = new Point(28, 207);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PrimaryColor = Color.LightSeaGreen;
            btnCancelar.Size = new Size(102, 30);
            btnCancelar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.White;
            btnCancelar.WarningColor = Color.FromArgb(230, 162, 60);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlDarkDark;
            txtNome.BaseColor = Color.FromArgb(44, 55, 66);
            txtNome.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNome.BorderColorB = SystemColors.ControlDarkDark;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.FromArgb(48, 49, 51);
            txtNome.Hint = "Nome";
            txtNome.Location = new Point(38, 41);
            txtNome.MaxLength = 32767;
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.ScrollBars = ScrollBars.None;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.Size = new Size(207, 38);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.UseSystemPasswordChar = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.MediumSeaGreen;
            btnCadastrar.BorderColor = Color.FromArgb(220, 223, 230);
            btnCadastrar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCadastrar.DangerColor = Color.FromArgb(245, 108, 108);
            btnCadastrar.DefaultClickColor = Color.FromArgb(43, 133, 228);
            btnCadastrar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.HoverClickTextColor = Color.FromArgb(43, 133, 228);
            btnCadastrar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCadastrar.InfoColor = Color.FromArgb(144, 147, 153);
            btnCadastrar.Location = new Point(150, 207);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.PrimaryColor = Color.MediumSpringGreen;
            btnCadastrar.Size = new Size(106, 30);
            btnCadastrar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.WarningColor = Color.FromArgb(230, 162, 60);
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.ControlDarkDark;
            txtSenha.BaseColor = Color.FromArgb(44, 55, 66);
            txtSenha.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSenha.BorderColorB = SystemColors.ControlDarkDark;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.FromArgb(48, 49, 51);
            txtSenha.Hint = "Senha";
            txtSenha.Location = new Point(38, 147);
            txtSenha.MaxLength = 32767;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.ScrollBars = ScrollBars.None;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.Size = new Size(139, 38);
            txtSenha.TabIndex = 2;
            txtSenha.TabStop = false;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlDarkDark;
            txtEmail.BaseColor = Color.FromArgb(44, 55, 66);
            txtEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            txtEmail.BorderColorB = SystemColors.ControlDarkDark;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.FromArgb(48, 49, 51);
            txtEmail.Hint = "Email";
            txtEmail.Location = new Point(38, 94);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.ScrollBars = ScrollBars.None;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.Size = new Size(207, 38);
            txtEmail.TabIndex = 1;
            txtEmail.TabStop = false;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // nightHeaderLabel1
            // 
            nightHeaderLabel1.AutoSize = true;
            nightHeaderLabel1.BackColor = Color.DarkSlateGray;
            nightHeaderLabel1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            nightHeaderLabel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel1.LeftSideForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel1.Location = new Point(165, 90);
            nightHeaderLabel1.Name = "nightHeaderLabel1";
            nightHeaderLabel1.RightSideForeColor = Color.FromArgb(170, 171, 176);
            nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            nightHeaderLabel1.Size = new Size(174, 50);
            nightHeaderLabel1.TabIndex = 3;
            nightHeaderLabel1.Text = "Cadastro";
            nightHeaderLabel1.TextAlign = ContentAlignment.BottomLeft;
            nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nightHeaderLabel1.UseCompatibleTextRendering = true;
            nightHeaderLabel1.Click += nightHeaderLabel1_Click;
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.DarkSlateGray;
            nightForm1.Controls.Add(nightHeaderLabel1);
            nightForm1.Controls.Add(nightControlBox1);
            nightForm1.Controls.Add(panel1);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(0, 0);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(504, 475);
            nightForm1.TabIndex = 4;
            nightForm1.Text = "Travel";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.Cursor = Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(365, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 8;
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(504, 475);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 728);
            Name = "CadastroBase";
            Text = "CadastroBase";
            TransparencyKey = Color.Fuchsia;
            panel1.ResumeLayout(false);
            nightForm1.ResumeLayout(false);
            nightForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.HopeSimpleButton btnCadastrar;
        private ReaLTaiizor.Controls.HopeTextBox txtSenha;
        private ReaLTaiizor.Controls.HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
        private ReaLTaiizor.Controls.HopeTextBox txtNome;
        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.HopeSimpleButton btnCancelar;
        private ReaLTaiizor.Controls.HopeTextBox txtId;
    }
}