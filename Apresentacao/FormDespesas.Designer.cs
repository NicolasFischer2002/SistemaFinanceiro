namespace SistemaFinanceiro
{
    partial class FormDespesas
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
            label1 = new Label();
            panel1 = new Panel();
            radioButtonDespesaEmAberto = new RadioButton();
            radioButtonDespesaQuitada = new RadioButton();
            btnInserirDespesa = new Button();
            CbBoxTipo = new ComboBox();
            CbBoxCategoria = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            dateTimePickerPagamento = new DateTimePicker();
            label7 = new Label();
            dateTimePickerVencimento = new DateTimePicker();
            CbBoxStatus = new ComboBox();
            label4 = new Label();
            label8 = new Label();
            TxtBoxNumeroParcelas = new TextBox();
            TxtBoxValor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TxtBoxDescricao = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 32);
            label1.TabIndex = 2;
            label1.Text = "Cadastre sua despesa";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(radioButtonDespesaEmAberto);
            panel1.Controls.Add(radioButtonDespesaQuitada);
            panel1.Controls.Add(btnInserirDespesa);
            panel1.Controls.Add(CbBoxTipo);
            panel1.Controls.Add(CbBoxCategoria);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dateTimePickerPagamento);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePickerVencimento);
            panel1.Controls.Add(CbBoxStatus);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(TxtBoxNumeroParcelas);
            panel1.Controls.Add(TxtBoxValor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtBoxDescricao);
            panel1.Location = new Point(224, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 430);
            panel1.TabIndex = 3;
            // 
            // radioButtonDespesaEmAberto
            // 
            radioButtonDespesaEmAberto.AutoSize = true;
            radioButtonDespesaEmAberto.Font = new Font("Segoe UI", 16F);
            radioButtonDespesaEmAberto.Location = new Point(681, 182);
            radioButtonDespesaEmAberto.Name = "radioButtonDespesaEmAberto";
            radioButtonDespesaEmAberto.Size = new Size(210, 34);
            radioButtonDespesaEmAberto.TabIndex = 27;
            radioButtonDespesaEmAberto.TabStop = true;
            radioButtonDespesaEmAberto.Text = "Depesa em aberto";
            radioButtonDespesaEmAberto.UseVisualStyleBackColor = true;
            radioButtonDespesaEmAberto.CheckedChanged += radioButtonDespesaEmAberto_CheckedChanged;
            // 
            // radioButtonDespesaQuitada
            // 
            radioButtonDespesaQuitada.AutoSize = true;
            radioButtonDespesaQuitada.Font = new Font("Segoe UI", 16F);
            radioButtonDespesaQuitada.Location = new Point(435, 182);
            radioButtonDespesaQuitada.Name = "radioButtonDespesaQuitada";
            radioButtonDespesaQuitada.Size = new Size(181, 34);
            radioButtonDespesaQuitada.TabIndex = 26;
            radioButtonDespesaQuitada.TabStop = true;
            radioButtonDespesaQuitada.Text = "Depesa quitada";
            radioButtonDespesaQuitada.UseVisualStyleBackColor = true;
            radioButtonDespesaQuitada.CheckedChanged += radioButtonDespesaQuitada_CheckedChanged;
            // 
            // btnInserirDespesa
            // 
            btnInserirDespesa.Location = new Point(339, 364);
            btnInserirDespesa.Name = "btnInserirDespesa";
            btnInserirDespesa.Size = new Size(255, 49);
            btnInserirDespesa.TabIndex = 30;
            btnInserirDespesa.Text = "Cadastrar";
            btnInserirDespesa.UseVisualStyleBackColor = true;
            btnInserirDespesa.Click += btnInserirDespesa_Click;
            // 
            // CbBoxTipo
            // 
            CbBoxTipo.Font = new Font("Segoe UI", 16F);
            CbBoxTipo.FormattingEnabled = true;
            CbBoxTipo.Location = new Point(49, 219);
            CbBoxTipo.Name = "CbBoxTipo";
            CbBoxTipo.Size = new Size(310, 38);
            CbBoxTipo.TabIndex = 25;
            // 
            // CbBoxCategoria
            // 
            CbBoxCategoria.Font = new Font("Segoe UI", 16F);
            CbBoxCategoria.FormattingEnabled = true;
            CbBoxCategoria.Location = new Point(49, 134);
            CbBoxCategoria.Name = "CbBoxCategoria";
            CbBoxCategoria.Size = new Size(310, 38);
            CbBoxCategoria.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(49, 101);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 25;
            label6.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(49, 186);
            label9.Name = "label9";
            label9.Size = new Size(56, 30);
            label9.TabIndex = 31;
            label9.Text = "Tipo";
            // 
            // dateTimePickerPagamento
            // 
            dateTimePickerPagamento.CalendarFont = new Font("Segoe UI", 17F);
            dateTimePickerPagamento.Font = new Font("Segoe UI", 17F);
            dateTimePickerPagamento.Location = new Point(435, 219);
            dateTimePickerPagamento.Name = "dateTimePickerPagamento";
            dateTimePickerPagamento.Size = new Size(456, 38);
            dateTimePickerPagamento.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(435, 100);
            label7.Name = "label7";
            label7.Size = new Size(176, 30);
            label7.TabIndex = 28;
            label7.Text = "Data vencimento";
            // 
            // dateTimePickerVencimento
            // 
            dateTimePickerVencimento.CalendarFont = new Font("Segoe UI", 17F);
            dateTimePickerVencimento.Font = new Font("Segoe UI", 17F);
            dateTimePickerVencimento.Location = new Point(435, 134);
            dateTimePickerVencimento.Name = "dateTimePickerVencimento";
            dateTimePickerVencimento.Size = new Size(456, 38);
            dateTimePickerVencimento.TabIndex = 24;
            // 
            // CbBoxStatus
            // 
            CbBoxStatus.Font = new Font("Segoe UI", 16F);
            CbBoxStatus.FormattingEnabled = true;
            CbBoxStatus.Location = new Point(435, 47);
            CbBoxStatus.Name = "CbBoxStatus";
            CbBoxStatus.Size = new Size(456, 38);
            CbBoxStatus.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(435, 14);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 23;
            label4.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(269, 14);
            label8.Name = "label8";
            label8.Size = new Size(90, 30);
            label8.TabIndex = 22;
            label8.Text = "Parcelas";
            // 
            // TxtBoxNumeroParcelas
            // 
            TxtBoxNumeroParcelas.Font = new Font("Segoe UI", 16F);
            TxtBoxNumeroParcelas.Location = new Point(269, 47);
            TxtBoxNumeroParcelas.Name = "TxtBoxNumeroParcelas";
            TxtBoxNumeroParcelas.Size = new Size(90, 36);
            TxtBoxNumeroParcelas.TabIndex = 21;
            TxtBoxNumeroParcelas.TextChanged += NumeroParcelas_TextChanged;
            // 
            // TxtBoxValor
            // 
            TxtBoxValor.Font = new Font("Segoe UI", 16F);
            TxtBoxValor.Location = new Point(49, 47);
            TxtBoxValor.Name = "TxtBoxValor";
            TxtBoxValor.Size = new Size(193, 36);
            TxtBoxValor.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(49, 14);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 19;
            label3.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(49, 273);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // TxtBoxDescricao
            // 
            TxtBoxDescricao.Font = new Font("Segoe UI", 16F);
            TxtBoxDescricao.Location = new Point(49, 306);
            TxtBoxDescricao.Name = "TxtBoxDescricao";
            TxtBoxDescricao.Size = new Size(842, 36);
            TxtBoxDescricao.TabIndex = 29;
            // 
            // FormDespesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1379, 685);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormDespesas";
            Text = "FormDespesas";
            Load += FormDespesas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox TxtBoxDescricao;
        private Label label2;
        private Label label8;
        private TextBox TxtBoxNumeroParcelas;
        private TextBox TxtBoxValor;
        private Label label3;
        private ComboBox CbBoxStatus;
        private Label label4;
        private ComboBox CbBoxCategoria;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePickerVencimento;
        private DateTimePicker dateTimePickerPagamento;
        private ComboBox CbBoxTipo;
        private Label label9;
        private Button btnInserirDespesa;
        private RadioButton radioButtonDespesaQuitada;
        private RadioButton radioButtonDespesaEmAberto;
    }
}