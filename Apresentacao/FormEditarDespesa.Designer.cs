namespace SistemaFinanceiro.Apresentacao
{
    partial class FormEditarDespesa
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
            label1 = new Label();
            radioButtonDespesaEmAberto = new RadioButton();
            radioButtonDespesaQuitada = new RadioButton();
            btnAtualizarDespesa = new Button();
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
            TxtBoxValor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TxtBoxDescricao = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumeroParcelas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(NumeroParcelas);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(radioButtonDespesaEmAberto);
            panel1.Controls.Add(radioButtonDespesaQuitada);
            panel1.Controls.Add(btnAtualizarDespesa);
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
            panel1.Controls.Add(TxtBoxValor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtBoxDescricao);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 520);
            panel1.TabIndex = 4;
            // 
            // NumeroParcelas
            // 
            NumeroParcelas.Font = new Font("Segoe UI", 16F);
            NumeroParcelas.Location = new Point(269, 108);
            NumeroParcelas.Name = "NumeroParcelas";
            NumeroParcelas.Size = new Size(120, 36);
            NumeroParcelas.TabIndex = 33;
            NumeroParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 19);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 32;
            label1.Text = "ATUALIZAR DESPESA";
            // 
            // radioButtonDespesaEmAberto
            // 
            radioButtonDespesaEmAberto.AutoSize = true;
            radioButtonDespesaEmAberto.Font = new Font("Segoe UI", 16F);
            radioButtonDespesaEmAberto.Location = new Point(681, 243);
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
            radioButtonDespesaQuitada.Location = new Point(435, 243);
            radioButtonDespesaQuitada.Name = "radioButtonDespesaQuitada";
            radioButtonDespesaQuitada.Size = new Size(181, 34);
            radioButtonDespesaQuitada.TabIndex = 26;
            radioButtonDespesaQuitada.TabStop = true;
            radioButtonDespesaQuitada.Text = "Depesa quitada";
            radioButtonDespesaQuitada.UseVisualStyleBackColor = true;
            radioButtonDespesaQuitada.CheckedChanged += radioButtonDespesaQuitada_CheckedChanged;
            // 
            // btnAtualizarDespesa
            // 
            btnAtualizarDespesa.Font = new Font("Segoe UI", 16F);
            btnAtualizarDespesa.Location = new Point(337, 425);
            btnAtualizarDespesa.Name = "btnAtualizarDespesa";
            btnAtualizarDespesa.Size = new Size(300, 70);
            btnAtualizarDespesa.TabIndex = 30;
            btnAtualizarDespesa.Text = "ATUALIZAR";
            btnAtualizarDespesa.UseVisualStyleBackColor = true;
            btnAtualizarDespesa.Click += btnInserirDespesa_Click;
            // 
            // CbBoxTipo
            // 
            CbBoxTipo.Font = new Font("Segoe UI", 16F);
            CbBoxTipo.FormattingEnabled = true;
            CbBoxTipo.Location = new Point(49, 280);
            CbBoxTipo.Name = "CbBoxTipo";
            CbBoxTipo.Size = new Size(340, 38);
            CbBoxTipo.TabIndex = 25;
            // 
            // CbBoxCategoria
            // 
            CbBoxCategoria.Font = new Font("Segoe UI", 16F);
            CbBoxCategoria.FormattingEnabled = true;
            CbBoxCategoria.Location = new Point(49, 195);
            CbBoxCategoria.Name = "CbBoxCategoria";
            CbBoxCategoria.Size = new Size(340, 38);
            CbBoxCategoria.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(49, 162);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 25;
            label6.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(49, 247);
            label9.Name = "label9";
            label9.Size = new Size(204, 30);
            label9.TabIndex = 31;
            label9.Text = "Tipo de pagamento";
            // 
            // dateTimePickerPagamento
            // 
            dateTimePickerPagamento.CalendarFont = new Font("Segoe UI", 17F);
            dateTimePickerPagamento.Font = new Font("Segoe UI", 17F);
            dateTimePickerPagamento.Location = new Point(435, 280);
            dateTimePickerPagamento.Name = "dateTimePickerPagamento";
            dateTimePickerPagamento.Size = new Size(456, 38);
            dateTimePickerPagamento.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(435, 161);
            label7.Name = "label7";
            label7.Size = new Size(176, 30);
            label7.TabIndex = 28;
            label7.Text = "Data vencimento";
            // 
            // dateTimePickerVencimento
            // 
            dateTimePickerVencimento.CalendarFont = new Font("Segoe UI", 17F);
            dateTimePickerVencimento.Font = new Font("Segoe UI", 17F);
            dateTimePickerVencimento.Location = new Point(435, 195);
            dateTimePickerVencimento.Name = "dateTimePickerVencimento";
            dateTimePickerVencimento.Size = new Size(456, 38);
            dateTimePickerVencimento.TabIndex = 24;
            // 
            // CbBoxStatus
            // 
            CbBoxStatus.Font = new Font("Segoe UI", 16F);
            CbBoxStatus.FormattingEnabled = true;
            CbBoxStatus.Location = new Point(435, 108);
            CbBoxStatus.Name = "CbBoxStatus";
            CbBoxStatus.Size = new Size(456, 38);
            CbBoxStatus.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(435, 75);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 23;
            label4.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(269, 75);
            label8.Name = "label8";
            label8.Size = new Size(90, 30);
            label8.TabIndex = 22;
            label8.Text = "Parcelas";
            // 
            // TxtBoxValor
            // 
            TxtBoxValor.Font = new Font("Segoe UI", 16F);
            TxtBoxValor.Location = new Point(49, 108);
            TxtBoxValor.Name = "TxtBoxValor";
            TxtBoxValor.Size = new Size(193, 36);
            TxtBoxValor.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(49, 75);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 19;
            label3.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(49, 334);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // TxtBoxDescricao
            // 
            TxtBoxDescricao.Font = new Font("Segoe UI", 16F);
            TxtBoxDescricao.Location = new Point(49, 367);
            TxtBoxDescricao.Name = "TxtBoxDescricao";
            TxtBoxDescricao.Size = new Size(842, 36);
            TxtBoxDescricao.TabIndex = 29;
            // 
            // FormEditarDespesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 546);
            Controls.Add(panel1);
            Name = "FormEditarDespesa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Despesa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumeroParcelas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown NumeroParcelas;
        private Label label1;
        private RadioButton radioButtonDespesaEmAberto;
        private RadioButton radioButtonDespesaQuitada;
        private Button btnAtualizarDespesa;
        private ComboBox CbBoxTipo;
        private ComboBox CbBoxCategoria;
        private Label label6;
        private Label label9;
        private DateTimePicker dateTimePickerPagamento;
        private Label label7;
        private DateTimePicker dateTimePickerVencimento;
        private ComboBox CbBoxStatus;
        private Label label4;
        private Label label8;
        private TextBox TxtBoxValor;
        private Label label3;
        private Label label2;
        private TextBox TxtBoxDescricao;
    }
}