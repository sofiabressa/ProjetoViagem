namespace ProjetoViagem.App.Outros
{

    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel2 = new Panel();
            btnCadastrar = new ReaLTaiizor.Controls.HopeSimpleButton();
            panel1 = new Panel();
            btnLogin = new ReaLTaiizor.Controls.HopeSimpleButton();
            txtSenha = new ReaLTaiizor.Controls.HopeTextBox();
            txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            nightForm1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.DarkSlateGray;
            nightForm1.Controls.Add(nightControlBox1);
            nightForm1.Controls.Add(panel2);
            nightForm1.Controls.Add(panel1);
            nightForm1.Controls.Add(hopePictureBox1);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(0, 0);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(504, 475);
            nightForm1.TabIndex = 2;
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
            nightControlBox1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 58, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCadastrar);
            panel2.Location = new Point(120, 386);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 66);
            panel2.TabIndex = 5;
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
            btnCadastrar.Location = new Point(24, 17);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.PrimaryColor = Color.LightSeaGreen;
            btnCadastrar.Size = new Size(207, 30);
            btnCadastrar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.WarningColor = Color.FromArgb(230, 162, 60);
            btnCadastrar.Click += btnCadastrar_Click;
            btnCadastrar.Enter += btnCadastrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 58, 61);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(120, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 212);
            panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogin.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogin.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogin.DefaultClickColor = Color.FromArgb(43, 133, 228);
            btnLogin.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.HoverClickTextColor = Color.FromArgb(43, 133, 228);
            btnLogin.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnLogin.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogin.Location = new Point(25, 147);
            btnLogin.Name = "btnLogin";
            btnLogin.PrimaryColor = Color.MediumSpringGreen;
            btnLogin.Size = new Size(207, 30);
            btnLogin.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += btnLogin_Click;
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
            txtSenha.Location = new Point(25, 87);
            txtSenha.MaxLength = 32767;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.ScrollBars = ScrollBars.None;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.Size = new Size(207, 38);
            txtSenha.TabIndex = 1;
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
            txtEmail.Location = new Point(25, 32);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.ScrollBars = ScrollBars.None;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.Size = new Size(207, 38);
            txtEmail.TabIndex = 0;
            txtEmail.TabStop = false;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Enabled = false;
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.InitialImage = null;
            hopePictureBox1.Location = new Point(190, 43);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(116, 109);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 0;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 475);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 728);
            Name = "Login";
            Text = "Login";
            TransparencyKey = Color.Fuchsia;
            Load += Login_Load;
            nightForm1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private Panel panel2;
        private ReaLTaiizor.Controls.HopeSimpleButton btnCadastrar;
        private Panel panel1;
        private ReaLTaiizor.Controls.HopeSimpleButton btnLogin;
        private ReaLTaiizor.Controls.HopeTextBox txtSenha;
        private ReaLTaiizor.Controls.HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}