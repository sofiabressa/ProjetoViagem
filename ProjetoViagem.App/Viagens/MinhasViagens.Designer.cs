namespace ProjetoViagem.App.Viagens
{
    partial class MinhasViagens
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
            dataGridViewViagens = new DataGridView();
            btnVoltar = new ReaLTaiizor.Controls.HopeSimpleButton();
            nightForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewViagens).BeginInit();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.DarkSlateGray;
            nightForm1.Controls.Add(dataGridViewViagens);
            nightForm1.Controls.Add(btnVoltar);
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
            nightForm1.Text = "Minhas Viagens";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Center;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            nightForm1.Enter += nightForm1_Enter;
            // 
            // dataGridViewViagens
            // 
            dataGridViewViagens.AllowUserToAddRows = false;
            dataGridViewViagens.AllowUserToDeleteRows = false;
            dataGridViewViagens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewViagens.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewViagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewViagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewViagens.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewViagens.GridColor = Color.DarkSlateGray;
            dataGridViewViagens.Location = new Point(12, 59);
            dataGridViewViagens.Name = "dataGridViewViagens";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewViagens.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewViagens.RowTemplate.Height = 25;
            dataGridViewViagens.Size = new Size(766, 238);
            dataGridViewViagens.TabIndex = 9;
            dataGridViewViagens.CellContentClick += dataGridViewViagens_CellContentClick;
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
            btnVoltar.Location = new Point(333, 315);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PrimaryColor = Color.MediumSpringGreen;
            btnVoltar.Size = new Size(120, 30);
            btnVoltar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.White;
            btnVoltar.WarningColor = Color.FromArgb(230, 162, 60);
            btnVoltar.Click += btnVoltar_Click;
            // 
            // MinhasViagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 380);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 728);
            Name = "MinhasViagens";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MinhasViagens";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewViagens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.HopeSimpleButton btnVoltar;
        private DataGridView dataGridViewViagens;
    }
}