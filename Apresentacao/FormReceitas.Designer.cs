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
            label8 = new Label();
            TxtBoxQtdeParcelas = new TextBox();
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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(TxtBoxQtdeParcelas);
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 661);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(339, 49);
            label8.Name = "label8";
            label8.Size = new Size(121, 30);
            label8.TabIndex = 18;
            label8.Text = "Nº Parcelas";
            // 
            // TxtBoxQtdeParcelas
            // 
            TxtBoxQtdeParcelas.Location = new Point(361, 82);
            TxtBoxQtdeParcelas.Name = "TxtBoxQtdeParcelas";
            TxtBoxQtdeParcelas.Size = new Size(99, 36);
            TxtBoxQtdeParcelas.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 10);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 16;
            label1.Text = "RECEITAS";
            // 
            // button1
            // 
            button1.Location = new Point(133, 584);
            button1.Name = "button1";
            button1.Size = new Size(327, 66);
            button1.TabIndex = 8;
            button1.Text = "INSERIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(131, 341);
            label7.Name = "label7";
            label7.Size = new Size(57, 30);
            label7.TabIndex = 14;
            label7.Text = "Data";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Location = new Point(131, 374);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(329, 32);
            dateTimePicker.TabIndex = 6;
            // 
            // CbBoxCategoria
            // 
            CbBoxCategoria.Font = new Font("Segoe UI", 16F);
            CbBoxCategoria.FormattingEnabled = true;
            CbBoxCategoria.Location = new Point(131, 154);
            CbBoxCategoria.Name = "CbBoxCategoria";
            CbBoxCategoria.Size = new Size(329, 38);
            CbBoxCategoria.TabIndex = 3;
            // 
            // CbBoxTipo
            // 
            CbBoxTipo.Font = new Font("Segoe UI", 16F);
            CbBoxTipo.FormattingEnabled = true;
            CbBoxTipo.Location = new Point(133, 228);
            CbBoxTipo.Name = "CbBoxTipo";
            CbBoxTipo.Size = new Size(327, 38);
            CbBoxTipo.TabIndex = 4;
            // 
            // CbBoxStatus
            // 
            CbBoxStatus.Font = new Font("Segoe UI", 16F);
            CbBoxStatus.FormattingEnabled = true;
            CbBoxStatus.Location = new Point(131, 301);
            CbBoxStatus.Name = "CbBoxStatus";
            CbBoxStatus.Size = new Size(329, 38);
            CbBoxStatus.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(131, 121);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 8;
            label6.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(133, 195);
            label5.Name = "label5";
            label5.Size = new Size(56, 30);
            label5.TabIndex = 6;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(131, 268);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // TxtBoxValor
            // 
            TxtBoxValor.Font = new Font("Segoe UI", 16F);
            TxtBoxValor.Location = new Point(133, 82);
            TxtBoxValor.Name = "TxtBoxValor";
            TxtBoxValor.Size = new Size(222, 36);
            TxtBoxValor.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(133, 49);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 2;
            label3.Text = "Valor";
            // 
            // TxtBoxDescricao
            // 
            TxtBoxDescricao.Font = new Font("Segoe UI", 16F);
            TxtBoxDescricao.Location = new Point(133, 441);
            TxtBoxDescricao.Multiline = true;
            TxtBoxDescricao.Name = "TxtBoxDescricao";
            TxtBoxDescricao.Size = new Size(327, 119);
            TxtBoxDescricao.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(133, 408);
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
            Shown += FormReceitas_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private DateTimePicker dateTimePicker;
        private ComboBox CbBoxCategoria;
        private ComboBox CbBoxTipo;
        private ComboBox CbBoxStatus;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox TxtBoxValor;
        private Label label3;
        private TextBox TxtBoxDescricao;
        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox TxtBoxQtdeParcelas;
        private Label label8;
    }
}