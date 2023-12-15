namespace ProjetoViagem.App.Cadastros
{
    partial class voosCadastrados
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            btnNovo = new ReaLTaiizor.Controls.HopeSimpleButton();
            btnDeletar = new ReaLTaiizor.Controls.HopeSimpleButton();
            btnVoltar = new ReaLTaiizor.Controls.HopeSimpleButton();
            dataGridViewVoos = new DataGridView();
            nightForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoos).BeginInit();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.DarkSlateGray;
            nightForm1.Controls.Add(btnNovo);
            nightForm1.Controls.Add(btnDeletar);
            nightForm1.Controls.Add(btnVoltar);
            nightForm1.Controls.Add(dataGridViewVoos);
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
            nightForm1.Text = "Voos Cadastrados";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Center;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            nightForm1.Enter += nightForm1_Enter;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.MediumSeaGreen;
            btnNovo.BorderColor = Color.FromArgb(220, 223, 230);
            btnNovo.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNovo.DangerColor = Color.FromArgb(245, 108, 108);
            btnNovo.DefaultClickColor = Color.FromArgb(43, 133, 228);
            btnNovo.DefaultColor = Color.FromArgb(255, 255, 255);
            btnNovo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.HoverClickTextColor = Color.FromArgb(43, 133, 228);
            btnNovo.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnNovo.InfoColor = Color.FromArgb(144, 147, 153);
            btnNovo.Location = new Point(335, 306);
            btnNovo.Name = "btnNovo";
            btnNovo.PrimaryColor = Color.LightSeaGreen;
            btnNovo.Size = new Size(121, 38);
            btnNovo.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNovo.TabIndex = 20;
            btnNovo.Text = "Novo";
            btnNovo.TextColor = Color.White;
            btnNovo.WarningColor = Color.FromArgb(230, 162, 60);
            btnNovo.Click += btnNovo_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.MediumSeaGreen;
            btnDeletar.BorderColor = Color.FromArgb(220, 223, 230);
            btnDeletar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDeletar.DangerColor = Color.FromArgb(245, 108, 108);
            btnDeletar.DefaultClickColor = Color.FromArgb(43, 133, 228);
            btnDeletar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeletar.HoverClickTextColor = Color.FromArgb(43, 133, 228);
            btnDeletar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnDeletar.InfoColor = Color.FromArgb(144, 147, 153);
            btnDeletar.Location = new Point(462, 306);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.PrimaryColor = Color.MediumSpringGreen;
            btnDeletar.Size = new Size(121, 38);
            btnDeletar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDeletar.TabIndex = 19;
            btnDeletar.Text = "Deletar";
            btnDeletar.TextColor = Color.White;
            btnDeletar.WarningColor = Color.FromArgb(230, 162, 60);
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.MediumSeaGreen;
            btnVoltar.BorderColor = Color.FromArgb(220, 223, 230);
            btnVoltar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnVoltar.DangerColor = Color.FromArgb(245, 108, 108);
            btnVoltar.DefaultClickColor = Color.FromArgb(43, 133, 228);
            btnVoltar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.HoverClickTextColor = Color.FromArgb(43, 133, 228);
            btnVoltar.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnVoltar.InfoColor = Color.FromArgb(144, 147, 153);
            btnVoltar.Location = new Point(208, 306);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PrimaryColor = Color.MediumSpringGreen;
            btnVoltar.Size = new Size(121, 38);
            btnVoltar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.White;
            btnVoltar.WarningColor = Color.FromArgb(230, 162, 60);
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dataGridViewVoos
            // 
            dataGridViewVoos.AllowUserToAddRows = false;
            dataGridViewVoos.AllowUserToDeleteRows = false;
            dataGridViewVoos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVoos.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewVoos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVoos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewVoos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewVoos.GridColor = Color.DarkSlateGray;
            dataGridViewVoos.Location = new Point(23, 52);
            dataGridViewVoos.Name = "dataGridViewVoos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewVoos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewVoos.RowTemplate.Height = 25;
            dataGridViewVoos.Size = new Size(745, 235);
            dataGridViewVoos.TabIndex = 10;
            // 
            // voosCadastrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 380);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 728);
            Name = "voosCadastrados";
            StartPosition = FormStartPosition.CenterParent;
            Text = "voosCadastrados";
            TransparencyKey = Color.Fuchsia;
            Enter += nightForm1_Enter;
            nightForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private DataGridView dataGridViewVoos;
        private ReaLTaiizor.Controls.HopeSimpleButton btnVoltar;
        private ReaLTaiizor.Controls.HopeSimpleButton btnDeletar;
        private ReaLTaiizor.Controls.HopeSimpleButton btnNovo;
    }
}