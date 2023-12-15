namespace ProjetoViagem.App.Cadastros
{
    partial class cadastroVoo
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
            panel1 = new Panel();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            cboDestino = new ReaLTaiizor.Controls.HopeComboBox();
            cboOrigem = new ReaLTaiizor.Controls.HopeComboBox();
            txtId = new ReaLTaiizor.Controls.HopeTextBox();
            btnCancelar = new ReaLTaiizor.Controls.HopeSimpleButton();
            panel4 = new Panel();
            materialMaskedTextBoxHoraChegada = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnConfirmar = new ReaLTaiizor.Controls.HopeSimpleButton();
            panel3 = new Panel();
            materialMaskedTextBoxHoraSaida = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            panel2 = new Panel();
            materialMaskedTextBoxData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtValor = new ReaLTaiizor.Controls.HopeTextBox();
            txtNumVoo = new ReaLTaiizor.Controls.HopeTextBox();
            txtEmpresa = new ReaLTaiizor.Controls.HopeTextBox();
            nightForm1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.DarkSlateGray;
            nightForm1.Controls.Add(panel1);
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
            nightForm1.Text = "Cadastro de Voos";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Center;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 58, 61);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(crownLabel2);
            panel1.Controls.Add(crownLabel1);
            panel1.Controls.Add(cboDestino);
            panel1.Controls.Add(cboOrigem);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(txtNumVoo);
            panel1.Controls.Add(txtEmpresa);
            panel1.Location = new Point(118, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 239);
            panel1.TabIndex = 4;
            // 
            // crownLabel2
            // 
            crownLabel2.AutoSize = true;
            crownLabel2.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel2.Location = new Point(195, 25);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(50, 15);
            crownLabel2.TabIndex = 20;
            crownLabel2.Text = "Destino:";
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel1.Location = new Point(26, 25);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(50, 15);
            crownLabel1.TabIndex = 19;
            crownLabel1.Text = "Origem:";
            // 
            // cboDestino
            // 
            cboDestino.BackColor = Color.Gray;
            cboDestino.DrawMode = DrawMode.OwnerDrawFixed;
            cboDestino.FlatStyle = FlatStyle.Flat;
            cboDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboDestino.FormattingEnabled = true;
            cboDestino.ItemHeight = 30;
            cboDestino.Location = new Point(195, 43);
            cboDestino.Name = "cboDestino";
            cboDestino.Size = new Size(166, 36);
            cboDestino.TabIndex = 18;
            cboDestino.SelectedIndexChanged += cboDestino_SelectedIndexChanged;
            // 
            // cboOrigem
            // 
            cboOrigem.BackColor = Color.Gray;
            cboOrigem.DrawMode = DrawMode.OwnerDrawFixed;
            cboOrigem.FlatStyle = FlatStyle.Flat;
            cboOrigem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboOrigem.FormattingEnabled = true;
            cboOrigem.ItemHeight = 30;
            cboOrigem.Location = new Point(22, 43);
            cboOrigem.Name = "cboOrigem";
            cboOrigem.Size = new Size(166, 36);
            cboOrigem.TabIndex = 5;
            cboOrigem.SelectedIndexChanged += cboOrigem_SelectedIndexChanged;
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
            txtId.Location = new Point(210, 170);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.ScrollBars = ScrollBars.None;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(62, 38);
            txtId.TabIndex = 17;
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
            btnCancelar.Location = new Point(285, 170);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PrimaryColor = Color.MediumSpringGreen;
            btnCancelar.Size = new Size(121, 38);
            btnCancelar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.White;
            btnCancelar.WarningColor = Color.FromArgb(230, 162, 60);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Controls.Add(materialMaskedTextBoxHoraChegada);
            panel4.Location = new Point(368, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(166, 48);
            panel4.TabIndex = 15;
            // 
            // materialMaskedTextBoxHoraChegada
            // 
            materialMaskedTextBoxHoraChegada.AllowPromptAsInput = true;
            materialMaskedTextBoxHoraChegada.AnimateReadOnly = false;
            materialMaskedTextBoxHoraChegada.AsciiOnly = false;
            materialMaskedTextBoxHoraChegada.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBoxHoraChegada.BeepOnError = false;
            materialMaskedTextBoxHoraChegada.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxHoraChegada.Depth = 0;
            materialMaskedTextBoxHoraChegada.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBoxHoraChegada.HidePromptOnLeave = false;
            materialMaskedTextBoxHoraChegada.HideSelection = true;
            materialMaskedTextBoxHoraChegada.Hint = "Horário de chegada";
            materialMaskedTextBoxHoraChegada.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBoxHoraChegada.LeadingIcon = null;
            materialMaskedTextBoxHoraChegada.Location = new Point(0, 0);
            materialMaskedTextBoxHoraChegada.Mask = "00:00";
            materialMaskedTextBoxHoraChegada.MaxLength = 32767;
            materialMaskedTextBoxHoraChegada.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBoxHoraChegada.Name = "materialMaskedTextBoxHoraChegada";
            materialMaskedTextBoxHoraChegada.PasswordChar = '\0';
            materialMaskedTextBoxHoraChegada.PrefixSuffixText = null;
            materialMaskedTextBoxHoraChegada.PromptChar = '_';
            materialMaskedTextBoxHoraChegada.ReadOnly = false;
            materialMaskedTextBoxHoraChegada.RejectInputOnFirstFailure = false;
            materialMaskedTextBoxHoraChegada.ResetOnPrompt = true;
            materialMaskedTextBoxHoraChegada.ResetOnSpace = true;
            materialMaskedTextBoxHoraChegada.RightToLeft = RightToLeft.No;
            materialMaskedTextBoxHoraChegada.SelectedText = "";
            materialMaskedTextBoxHoraChegada.SelectionLength = 0;
            materialMaskedTextBoxHoraChegada.SelectionStart = 0;
            materialMaskedTextBoxHoraChegada.ShortcutsEnabled = true;
            materialMaskedTextBoxHoraChegada.Size = new Size(166, 48);
            materialMaskedTextBoxHoraChegada.SkipLiterals = true;
            materialMaskedTextBoxHoraChegada.TabIndex = 12;
            materialMaskedTextBoxHoraChegada.TabStop = false;
            materialMaskedTextBoxHoraChegada.Text = "  :";
            materialMaskedTextBoxHoraChegada.TextAlign = HorizontalAlignment.Center;
            materialMaskedTextBoxHoraChegada.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxHoraChegada.TrailingIcon = null;
            materialMaskedTextBoxHoraChegada.UseSystemPasswordChar = false;
            materialMaskedTextBoxHoraChegada.ValidatingType = null;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.MediumSeaGreen;
            btnConfirmar.BorderColor = Color.FromArgb(220, 223, 230);
            btnConfirmar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnConfirmar.DangerColor = Color.FromArgb(245, 108, 108);
            btnConfirmar.DefaultClickColor = Color.FromArgb(43, 133, 228);
            btnConfirmar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmar.HoverClickTextColor = Color.FromArgb(43, 133, 228);
            btnConfirmar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnConfirmar.InfoColor = Color.FromArgb(144, 147, 153);
            btnConfirmar.Location = new Point(413, 170);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.PrimaryColor = Color.MediumSpringGreen;
            btnConfirmar.Size = new Size(121, 38);
            btnConfirmar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextColor = Color.White;
            btnConfirmar.WarningColor = Color.FromArgb(230, 162, 60);
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(materialMaskedTextBoxHoraSaida);
            panel3.Location = new Point(195, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(166, 48);
            panel3.TabIndex = 14;
            // 
            // materialMaskedTextBoxHoraSaida
            // 
            materialMaskedTextBoxHoraSaida.AllowPromptAsInput = true;
            materialMaskedTextBoxHoraSaida.AnimateReadOnly = false;
            materialMaskedTextBoxHoraSaida.AsciiOnly = false;
            materialMaskedTextBoxHoraSaida.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBoxHoraSaida.BeepOnError = false;
            materialMaskedTextBoxHoraSaida.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxHoraSaida.Depth = 0;
            materialMaskedTextBoxHoraSaida.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBoxHoraSaida.HidePromptOnLeave = false;
            materialMaskedTextBoxHoraSaida.HideSelection = true;
            materialMaskedTextBoxHoraSaida.Hint = "Horário de saída";
            materialMaskedTextBoxHoraSaida.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBoxHoraSaida.LeadingIcon = null;
            materialMaskedTextBoxHoraSaida.Location = new Point(0, 0);
            materialMaskedTextBoxHoraSaida.Mask = "00:00";
            materialMaskedTextBoxHoraSaida.MaxLength = 32767;
            materialMaskedTextBoxHoraSaida.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBoxHoraSaida.Name = "materialMaskedTextBoxHoraSaida";
            materialMaskedTextBoxHoraSaida.PasswordChar = '\0';
            materialMaskedTextBoxHoraSaida.PrefixSuffixText = null;
            materialMaskedTextBoxHoraSaida.PromptChar = '_';
            materialMaskedTextBoxHoraSaida.ReadOnly = false;
            materialMaskedTextBoxHoraSaida.RejectInputOnFirstFailure = false;
            materialMaskedTextBoxHoraSaida.ResetOnPrompt = true;
            materialMaskedTextBoxHoraSaida.ResetOnSpace = true;
            materialMaskedTextBoxHoraSaida.RightToLeft = RightToLeft.No;
            materialMaskedTextBoxHoraSaida.SelectedText = "";
            materialMaskedTextBoxHoraSaida.SelectionLength = 0;
            materialMaskedTextBoxHoraSaida.SelectionStart = 0;
            materialMaskedTextBoxHoraSaida.ShortcutsEnabled = true;
            materialMaskedTextBoxHoraSaida.Size = new Size(166, 48);
            materialMaskedTextBoxHoraSaida.SkipLiterals = true;
            materialMaskedTextBoxHoraSaida.TabIndex = 12;
            materialMaskedTextBoxHoraSaida.TabStop = false;
            materialMaskedTextBoxHoraSaida.Text = "  :";
            materialMaskedTextBoxHoraSaida.TextAlign = HorizontalAlignment.Center;
            materialMaskedTextBoxHoraSaida.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxHoraSaida.TrailingIcon = null;
            materialMaskedTextBoxHoraSaida.UseSystemPasswordChar = false;
            materialMaskedTextBoxHoraSaida.ValidatingType = null;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(materialMaskedTextBoxData);
            panel2.Location = new Point(22, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(166, 48);
            panel2.TabIndex = 13;
            // 
            // materialMaskedTextBoxData
            // 
            materialMaskedTextBoxData.AllowPromptAsInput = true;
            materialMaskedTextBoxData.AnimateReadOnly = false;
            materialMaskedTextBoxData.AsciiOnly = false;
            materialMaskedTextBoxData.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBoxData.BeepOnError = false;
            materialMaskedTextBoxData.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxData.Depth = 0;
            materialMaskedTextBoxData.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBoxData.HidePromptOnLeave = false;
            materialMaskedTextBoxData.HideSelection = true;
            materialMaskedTextBoxData.Hint = "Data de voo";
            materialMaskedTextBoxData.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBoxData.LeadingIcon = null;
            materialMaskedTextBoxData.Location = new Point(0, 0);
            materialMaskedTextBoxData.Mask = "99/99/9999";
            materialMaskedTextBoxData.MaxLength = 32767;
            materialMaskedTextBoxData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBoxData.Name = "materialMaskedTextBoxData";
            materialMaskedTextBoxData.PasswordChar = '\0';
            materialMaskedTextBoxData.PrefixSuffixText = null;
            materialMaskedTextBoxData.PromptChar = '_';
            materialMaskedTextBoxData.ReadOnly = false;
            materialMaskedTextBoxData.RejectInputOnFirstFailure = false;
            materialMaskedTextBoxData.ResetOnPrompt = true;
            materialMaskedTextBoxData.ResetOnSpace = true;
            materialMaskedTextBoxData.RightToLeft = RightToLeft.No;
            materialMaskedTextBoxData.SelectedText = "";
            materialMaskedTextBoxData.SelectionLength = 0;
            materialMaskedTextBoxData.SelectionStart = 0;
            materialMaskedTextBoxData.ShortcutsEnabled = true;
            materialMaskedTextBoxData.Size = new Size(166, 48);
            materialMaskedTextBoxData.SkipLiterals = true;
            materialMaskedTextBoxData.TabIndex = 12;
            materialMaskedTextBoxData.TabStop = false;
            materialMaskedTextBoxData.Text = "  /  /";
            materialMaskedTextBoxData.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBoxData.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBoxData.TrailingIcon = null;
            materialMaskedTextBoxData.UseSystemPasswordChar = false;
            materialMaskedTextBoxData.ValidatingType = null;
            // 
            // txtValor
            // 
            txtValor.BackColor = SystemColors.ControlDarkDark;
            txtValor.BaseColor = Color.FromArgb(44, 55, 66);
            txtValor.BorderColorA = Color.FromArgb(64, 158, 255);
            txtValor.BorderColorB = SystemColors.ControlDarkDark;
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.ForeColor = Color.FromArgb(48, 49, 51);
            txtValor.Hint = "Preço";
            txtValor.Location = new Point(122, 170);
            txtValor.MaxLength = 32767;
            txtValor.Multiline = false;
            txtValor.Name = "txtValor";
            txtValor.PasswordChar = '\0';
            txtValor.ScrollBars = ScrollBars.None;
            txtValor.SelectedText = "";
            txtValor.SelectionLength = 0;
            txtValor.SelectionStart = 0;
            txtValor.Size = new Size(82, 38);
            txtValor.TabIndex = 11;
            txtValor.TabStop = false;
            txtValor.UseSystemPasswordChar = false;
            // 
            // txtNumVoo
            // 
            txtNumVoo.BackColor = SystemColors.ControlDarkDark;
            txtNumVoo.BaseColor = Color.FromArgb(44, 55, 66);
            txtNumVoo.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNumVoo.BorderColorB = SystemColors.ControlDarkDark;
            txtNumVoo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumVoo.ForeColor = Color.FromArgb(48, 49, 51);
            txtNumVoo.Hint = "nº voo";
            txtNumVoo.Location = new Point(26, 170);
            txtNumVoo.MaxLength = 32767;
            txtNumVoo.Multiline = false;
            txtNumVoo.Name = "txtNumVoo";
            txtNumVoo.PasswordChar = '\0';
            txtNumVoo.ScrollBars = ScrollBars.None;
            txtNumVoo.SelectedText = "";
            txtNumVoo.SelectionLength = 0;
            txtNumVoo.SelectionStart = 0;
            txtNumVoo.Size = new Size(90, 38);
            txtNumVoo.TabIndex = 10;
            txtNumVoo.TabStop = false;
            txtNumVoo.UseSystemPasswordChar = false;
            // 
            // txtEmpresa
            // 
            txtEmpresa.BackColor = SystemColors.ControlDarkDark;
            txtEmpresa.BaseColor = Color.FromArgb(44, 55, 66);
            txtEmpresa.BorderColorA = Color.FromArgb(64, 158, 255);
            txtEmpresa.BorderColorB = SystemColors.ControlDarkDark;
            txtEmpresa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpresa.ForeColor = Color.FromArgb(48, 49, 51);
            txtEmpresa.Hint = "Empresa";
            txtEmpresa.Location = new Point(368, 43);
            txtEmpresa.MaxLength = 32767;
            txtEmpresa.Multiline = false;
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.PasswordChar = '\0';
            txtEmpresa.ScrollBars = ScrollBars.None;
            txtEmpresa.SelectedText = "";
            txtEmpresa.SelectionLength = 0;
            txtEmpresa.SelectionStart = 0;
            txtEmpresa.Size = new Size(167, 38);
            txtEmpresa.TabIndex = 9;
            txtEmpresa.TabStop = false;
            txtEmpresa.UseSystemPasswordChar = false;
            // 
            // cadastroVoo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 380);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 728);
            Name = "cadastroVoo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "cadastroVoo";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private Panel panel1;
        private ReaLTaiizor.Controls.HopeTextBox txtEmpresa;
        private ReaLTaiizor.Controls.HopeSimpleButton btnConfirmar;
        private ReaLTaiizor.Controls.HopeTextBox txtNumVoo;
        private ReaLTaiizor.Controls.HopeTextBox txtValor;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBoxData;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBoxHoraSaida;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBoxHoraChegada;
        private ReaLTaiizor.Controls.HopeSimpleButton btnCancelar;
        private ReaLTaiizor.Controls.HopeTextBox txtId;
        private ReaLTaiizor.Controls.HopeComboBox cboDestino;
        private ReaLTaiizor.Controls.HopeComboBox cboOrigem;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
    }
}