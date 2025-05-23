namespace SistemaFinanceiro
{
    partial class FormReceitas
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
            panel1 = new Panel();
            NumeroParcelas = new NumericUpDown();
            NumeroParcelas_ = new TextBox();
            label8 = new Label();
            label1 = new Label();
            button1 = new Button();
            label7 = new Label();
            dateTimePicker = new DateTimePicker();
            CbBoxCategoria = new ComboBox();
            CbBoxTipo = new ComboBox();
            CbBoxStatus = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            TxtBoxValor = new TextBox();
            label3 = new Label();
            TxtBoxDescricao = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumeroParcelas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(NumeroParcelas);
            panel1.Controls.Add(NumeroParcelas_);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(CbBoxCategoria);
            panel1.Controls.Add(CbBoxTipo);
            panel1.Controls.Add(CbBoxStatus);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TxtBoxValor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TxtBoxDescricao);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Segoe UI", 16F);
            panel1.Location = new Point(224, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 520);
            panel1.TabIndex = 2;
            // 
            // NumeroParcelas
            // 
            NumeroParcelas.Location = new Point(407, 117);
            NumeroParcelas.Name = "NumeroParcelas";
            NumeroParcelas.Size = new Size(90, 36);
            NumeroParcelas.TabIndex = 3;
            // 
            // NumeroParcelas_
            // 
            NumeroParcelas_.Enabled = false;
            NumeroParcelas_.Font = new Font("Segoe UI", 16F);
            NumeroParcelas_.Location = new Point(-105, 432);
            NumeroParcelas_.Name = "NumeroParcelas_";
            NumeroParcelas_.Size = new Size(190, 36);
            NumeroParcelas_.TabIndex = 3;
            NumeroParcelas_.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(407, 84);
            label8.Name = "label8";
            label8.Size = new Size(90, 30);
            label8.TabIndex = 18;
            label8.Text = "Parcelas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(269, 32);
            label1.TabIndex = 16;
            label1.Text = "CADASTRE SUA RECEITA";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(332, 432);
            button1.Name = "button1";
            button1.Size = new Size(300, 70);
            button1.TabIndex = 8;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(175, 247);
            label7.Name = "label7";
            label7.Size = new Size(57, 30);
            label7.TabIndex = 14;
            label7.Text = "Data";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 16F);
            dateTimePicker.Location = new Point(167, 276);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(376, 36);
            dateTimePicker.TabIndex = 7;
            // 
            // CbBoxCategoria
            // 
            CbBoxCategoria.Font = new Font("Segoe UI", 16F);
            CbBoxCategoria.FormattingEnabled = true;
            CbBoxCategoria.Location = new Point(562, 206);
            CbBoxCategoria.Name = "CbBoxCategoria";
            CbBoxCategoria.Size = new Size(223, 38);
            CbBoxCategoria.TabIndex = 6;
            // 
            // CbBoxTipo
            // 
            CbBoxTipo.Font = new Font("Segoe UI", 16F);
            CbBoxTipo.FormattingEnabled = true;
            CbBoxTipo.Location = new Point(503, 115);
            CbBoxTipo.Name = "CbBoxTipo";
            CbBoxTipo.Size = new Size(211, 38);
            CbBoxTipo.TabIndex = 5;
            // 
            // CbBoxStatus
            // 
            CbBoxStatus.Font = new Font("Segoe UI", 16F);
            CbBoxStatus.FormattingEnabled = true;
            CbBoxStatus.Location = new Point(175, 206);
            CbBoxStatus.Name = "CbBoxStatus";
            CbBoxStatus.Size = new Size(381, 38);
            CbBoxStatus.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(562, 173);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 8;
            label6.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(503, 82);
            label5.Name = "label5";
            label5.Size = new Size(56, 30);
            label5.TabIndex = 6;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(175, 173);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // TxtBoxValor
            // 
            TxtBoxValor.Font = new Font("Segoe UI", 16F);
            TxtBoxValor.Location = new Point(175, 117);
            TxtBoxValor.Name = "TxtBoxValor";
            TxtBoxValor.Size = new Size(223, 36);
            TxtBoxValor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(175, 84);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 2;
            label3.Text = "Valor";
            // 
            // TxtBoxDescricao
            // 
            TxtBoxDescricao.Font = new Font("Segoe UI", 16F);
            TxtBoxDescricao.Location = new Point(175, 356);
            TxtBoxDescricao.Name = "TxtBoxDescricao";
            TxtBoxDescricao.Size = new Size(610, 36);
            TxtBoxDescricao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(175, 323);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 0;
            label2.Text = "Descrição";
            // 
            // FormReceitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1370, 685);
            Controls.Add(panel1);
            Name = "FormReceitas";
            Text = "FormReceitas";
            Load += FormReceitas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumeroParcelas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private DateTimePicker dateTimePicker;
        private ComboBox CbBoxCategoria;
        private ComboBox CbBoxStatus;
        private Label label6;
        private Label label4;
        private TextBox TxtBoxValor;
        private Label label3;
        private TextBox TxtBoxDescricao;
        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox NumeroParcelas_;
        private Label label8;
        private ComboBox CbBoxTipo;
        private Label label5;
        private NumericUpDown NumeroParcelas;
    }
}