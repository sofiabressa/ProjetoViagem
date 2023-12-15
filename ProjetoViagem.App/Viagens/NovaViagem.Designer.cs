namespace ProjetoViagem.App.Viagens
{
    partial class NovaViagem
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
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            panel4 = new ReaLTaiizor.Controls.Panel();
            nightHeaderLabel2 = new ReaLTaiizor.Controls.NightHeaderLabel();
            panel5 = new Panel();
            panel7 = new Panel();
            materialMaskedTextBoxIda = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnBuscar = new ReaLTaiizor.Controls.HopeSimpleButton();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            txtDestino = new ReaLTaiizor.Controls.HopeTextBox();
            txtOrigem = new ReaLTaiizor.Controls.HopeTextBox();
            nightForm1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.DarkSlateGray;
            nightForm1.Controls.Add(panel4);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(0, 0);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(790, 380);
            nightForm1.TabIndex = 0;
            nightForm1.Text = "Nova Viagem";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Center;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Controls.Add(nightHeaderLabel2);
            panel4.Controls.Add(panel5);
            panel4.EdgeColor = Color.FromArgb(32, 41, 50);
            panel4.Location = new Point(8, 50);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(777, 291);
            panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel4.TabIndex = 7;
            panel4.Text = "panel4";
            // 
            // nightHeaderLabel2
            // 
            nightHeaderLabel2.AutoSize = true;
            nightHeaderLabel2.BackColor = Color.Transparent;
            nightHeaderLabel2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            nightHeaderLabel2.ForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel2.LeftSideForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel2.Location = new Point(268, 14);
            nightHeaderLabel2.Name = "nightHeaderLabel2";
            nightHeaderLabel2.RightSideForeColor = Color.FromArgb(170, 171, 176);
            nightHeaderLabel2.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            nightHeaderLabel2.Size = new Size(269, 40);
            nightHeaderLabel2.TabIndex = 6;
            nightHeaderLabel2.Text = "Passagens Aéreas";
            nightHeaderLabel2.TextAlign = ContentAlignment.BottomLeft;
            nightHeaderLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nightHeaderLabel2.UseCompatibleTextRendering = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 58, 61);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(btnBuscar);
            panel5.Controls.Add(crownLabel2);
            panel5.Controls.Add(txtDestino);
            panel5.Controls.Add(txtOrigem);
            panel5.Location = new Point(172, 57);
            panel5.Name = "panel5";
            panel5.Size = new Size(443, 216);
            panel5.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlDarkDark;
            panel7.Controls.Add(materialMaskedTextBoxIda);
            panel7.Location = new Point(37, 118);
            panel7.Name = "panel7";
            panel7.Size = new Size(179, 48);
            panel7.TabIndex = 14;
            // 
            // materialMaskedTextBoxIda
            // 
            materialMaskedTextBoxIda.AllowPromptAsInput = true;
            materialMaskedTextBoxIda.AnimateReadOnly = false;
            materialMaskedTextBoxIda.AsciiOnly = false;
            materialMaskedTextBoxIda.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBoxIda.BeepOnError = false;
            materialMaskedTextBoxIda.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxIda.Depth = 0;
            materialMaskedTextBoxIda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBoxIda.HidePromptOnLeave = false;
            materialMaskedTextBoxIda.HideSelection = true;
            materialMaskedTextBoxIda.Hint = "Ida";
            materialMaskedTextBoxIda.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBoxIda.LeadingIcon = null;
            materialMaskedTextBoxIda.Location = new Point(0, 0);
            materialMaskedTextBoxIda.Mask = "99/99/9999";
            materialMaskedTextBoxIda.MaxLength = 32767;
            materialMaskedTextBoxIda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBoxIda.Name = "materialMaskedTextBoxIda";
            materialMaskedTextBoxIda.PasswordChar = '\0';
            materialMaskedTextBoxIda.PrefixSuffixText = null;
            materialMaskedTextBoxIda.PromptChar = '_';
            materialMaskedTextBoxIda.ReadOnly = false;
            materialMaskedTextBoxIda.RejectInputOnFirstFailure = false;
            materialMaskedTextBoxIda.ResetOnPrompt = true;
            materialMaskedTextBoxIda.ResetOnSpace = true;
            materialMaskedTextBoxIda.RightToLeft = RightToLeft.No;
            materialMaskedTextBoxIda.SelectedText = "";
            materialMaskedTextBoxIda.SelectionLength = 0;
            materialMaskedTextBoxIda.SelectionStart = 0;
            materialMaskedTextBoxIda.ShortcutsEnabled = true;
            materialMaskedTextBoxIda.Size = new Size(179, 48);
            materialMaskedTextBoxIda.SkipLiterals = true;
            materialMaskedTextBoxIda.TabIndex = 3;
            materialMaskedTextBoxIda.TabStop = false;
            materialMaskedTextBoxIda.Text = "  /  /";
            materialMaskedTextBoxIda.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBoxIda.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxIda.TrailingIcon = null;
            materialMaskedTextBoxIda.UseSystemPasswordChar = false;
            materialMaskedTextBoxIda.ValidatingType = null;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.MediumSeaGreen;
            btnBuscar.BorderColor = Color.FromArgb(220, 223, 230);
            btnBuscar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnBuscar.DangerColor = Color.FromArgb(245, 108, 108);
            btnBuscar.DefaultClickColor = Color.FromArgb(43, 133, 228);
            btnBuscar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.HoverClickTextColor = Color.FromArgb(43, 133, 228);
            btnBuscar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnBuscar.InfoColor = Color.FromArgb(144, 147, 153);
            btnBuscar.Location = new Point(243, 128);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.PrimaryColor = Color.MediumSpringGreen;
            btnBuscar.Size = new Size(167, 38);
            btnBuscar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextColor = Color.White;
            btnBuscar.WarningColor = Color.FromArgb(230, 162, 60);
            btnBuscar.Click += btnBuscar_Click;
            // 
            // crownLabel2
            // 
            crownLabel2.AutoSize = true;
            crownLabel2.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel2.Location = new Point(37, 100);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(107, 15);
            crownLabel2.TabIndex = 8;
            crownLabel2.Text = "Data (somente ida)";
            // 
            // txtDestino
            // 
            txtDestino.BackColor = SystemColors.ControlDarkDark;
            txtDestino.BaseColor = Color.FromArgb(44, 55, 66);
            txtDestino.BorderColorA = Color.FromArgb(64, 158, 255);
            txtDestino.BorderColorB = SystemColors.ControlDarkDark;
            txtDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDestino.ForeColor = Color.FromArgb(48, 49, 51);
            txtDestino.Hint = "Destino";
            txtDestino.Location = new Point(231, 45);
            txtDestino.MaxLength = 32767;
            txtDestino.Multiline = false;
            txtDestino.Name = "txtDestino";
            txtDestino.PasswordChar = '\0';
            txtDestino.ScrollBars = ScrollBars.None;
            txtDestino.SelectedText = "";
            txtDestino.SelectionLength = 0;
            txtDestino.SelectionStart = 0;
            txtDestino.Size = new Size(179, 38);
            txtDestino.TabIndex = 2;
            txtDestino.TabStop = false;
            txtDestino.UseSystemPasswordChar = false;
            // 
            // txtOrigem
            // 
            txtOrigem.BackColor = SystemColors.ControlDarkDark;
            txtOrigem.BaseColor = Color.FromArgb(44, 55, 66);
            txtOrigem.BorderColorA = Color.FromArgb(64, 158, 255);
            txtOrigem.BorderColorB = SystemColors.ControlDarkDark;
            txtOrigem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrigem.ForeColor = Color.FromArgb(48, 49, 51);
            txtOrigem.Hint = "Origem";
            txtOrigem.Location = new Point(37, 45);
            txtOrigem.MaxLength = 32767;
            txtOrigem.Multiline = false;
            txtOrigem.Name = "txtOrigem";
            txtOrigem.PasswordChar = '\0';
            txtOrigem.ScrollBars = ScrollBars.None;
            txtOrigem.SelectedText = "";
            txtOrigem.SelectionLength = 0;
            txtOrigem.SelectionStart = 0;
            txtOrigem.Size = new Size(179, 38);
            txtOrigem.TabIndex = 1;
            txtOrigem.TabStop = false;
            txtOrigem.UseSystemPasswordChar = false;
            // 
            // NovaViagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 380);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 728);
            Name = "NovaViagem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NovaViagem";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.Panel panel4;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel2;
        private Panel panel5;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBoxIda;
        private ReaLTaiizor.Controls.HopeSimpleButton btnBuscar;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.HopeTextBox txtDestino;
        private ReaLTaiizor.Controls.HopeTextBox txtOrigem;
    }
}