namespace ProjetoViagem.App.Viagens
{
    partial class ListarPassagens
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
            btnVoltar = new ReaLTaiizor.Controls.HopeSimpleButton();
            btnConfirmar = new ReaLTaiizor.Controls.HopeSimpleButton();
            dataGridViewPassagens = new DataGridView();
            NumVoo = new DataGridViewTextBoxColumn();
            ValorVoo = new DataGridViewTextBoxColumn();
            Data_voo = new DataGridViewTextBoxColumn();
            Horario_saida = new DataGridViewTextBoxColumn();
            Horario_chegada = new DataGridViewTextBoxColumn();
            Origem = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            nightForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPassagens).BeginInit();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.DarkSlateGray;
            nightForm1.Controls.Add(btnVoltar);
            nightForm1.Controls.Add(btnConfirmar);
            nightForm1.Controls.Add(dataGridViewPassagens);
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
            nightForm1.Text = "Lista de Voos";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Center;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            nightForm1.Enter += nightForm1_Enter;
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
            btnVoltar.Location = new Point(264, 313);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PrimaryColor = Color.MediumSpringGreen;
            btnVoltar.Size = new Size(107, 38);
            btnVoltar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.White;
            btnVoltar.WarningColor = Color.FromArgb(230, 162, 60);
            btnVoltar.Click += btnVoltar_Click;
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
            btnConfirmar.Location = new Point(397, 313);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.PrimaryColor = Color.MediumSpringGreen;
            btnConfirmar.Size = new Size(107, 38);
            btnConfirmar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextColor = Color.White;
            btnConfirmar.WarningColor = Color.FromArgb(230, 162, 60);
            btnConfirmar.Click += btnConfirmar_Click;
            btnConfirmar.Enter += btnConfirmar_Click;
            // 
            // dataGridViewPassagens
            // 
            dataGridViewPassagens.AllowUserToAddRows = false;
            dataGridViewPassagens.AllowUserToDeleteRows = false;
            dataGridViewPassagens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPassagens.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPassagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPassagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPassagens.Columns.AddRange(new DataGridViewColumn[] { NumVoo, ValorVoo, Data_voo, Horario_saida, Horario_chegada, Origem, Destino, Empresa });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPassagens.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPassagens.GridColor = Color.DarkSlateGray;
            dataGridViewPassagens.Location = new Point(12, 45);
            dataGridViewPassagens.Name = "dataGridViewPassagens";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPassagens.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPassagens.RowTemplate.Height = 25;
            dataGridViewPassagens.Size = new Size(766, 238);
            dataGridViewPassagens.TabIndex = 8;
            dataGridViewPassagens.CellContentClick += dataGridViewPassagens_CellContentClick;
            dataGridViewPassagens.CellEnter += dataGridViewPassagens_CellContentClick;
            // 
            // NumVoo
            // 
            NumVoo.HeaderText = "nº voo";
            NumVoo.Name = "NumVoo";
            // 
            // ValorVoo
            // 
            ValorVoo.HeaderText = "Preço";
            ValorVoo.Name = "ValorVoo";
            // 
            // Data_voo
            // 
            Data_voo.HeaderText = "Data do Voo";
            Data_voo.Name = "Data_voo";
            // 
            // Horario_saida
            // 
            Horario_saida.HeaderText = "Horário de saída";
            Horario_saida.Name = "Horario_saida";
            // 
            // Horario_chegada
            // 
            Horario_chegada.HeaderText = "Horario de chegada";
            Horario_chegada.Name = "Horario_chegada";
            // 
            // Origem
            // 
            Origem.HeaderText = "Origem";
            Origem.Name = "Origem";
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.Name = "Destino";
            // 
            // Empresa
            // 
            Empresa.HeaderText = "Empresa";
            Empresa.Name = "Empresa";
            // 
            // ListarPassagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 380);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 728);
            Name = "ListarPassagens";
            Text = "ListarPassagens";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPassagens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private DataGridView dataGridViewPassagens;
        private ReaLTaiizor.Controls.HopeSimpleButton btnVoltar;
        private ReaLTaiizor.Controls.HopeSimpleButton btnConfirmar;
        private DataGridViewTextBoxColumn NumVoo;
        private DataGridViewTextBoxColumn ValorVoo;
        private DataGridViewTextBoxColumn Data_voo;
        private DataGridViewTextBoxColumn Horario_saida;
        private DataGridViewTextBoxColumn Horario_chegada;
        private DataGridViewTextBoxColumn Origem;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Empresa;
    }
}