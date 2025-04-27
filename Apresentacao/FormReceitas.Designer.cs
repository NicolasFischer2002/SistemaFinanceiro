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
            label1 = new Label();
            button1 = new Button();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            TxtBoxDescricao = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TxtBoxDescricao);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Segoe UI", 16F);
            panel1.Location = new Point(12, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 603);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 16;
            label1.Text = "TELA RECEITAS";
            // 
            // button1
            // 
            button1.Location = new Point(181, 528);
            button1.Name = "button1";
            button1.Size = new Size(320, 49);
            button1.TabIndex = 15;
            button1.Text = "INSERIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(181, 439);
            label7.Name = "label7";
            label7.Size = new Size(57, 30);
            label7.TabIndex = 14;
            label7.Text = "Data";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14F);
            dateTimePicker1.Location = new Point(181, 472);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 32);
            dateTimePicker1.TabIndex = 13;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 16F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(237, 398);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(190, 38);
            comboBox3.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 16F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(237, 320);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 38);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 16F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(234, 237);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 38);
            comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(237, 365);
            label6.Name = "label6";
            label6.Size = new Size(107, 30);
            label6.TabIndex = 8;
            label6.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(237, 287);
            label5.Name = "label5";
            label5.Size = new Size(56, 30);
            label5.TabIndex = 6;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(237, 204);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(237, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 36);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(237, 123);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 2;
            label3.Text = "Valor";
            // 
            // TxtBoxDescricao
            // 
            TxtBoxDescricao.Font = new Font("Segoe UI", 16F);
            TxtBoxDescricao.Location = new Point(237, 75);
            TxtBoxDescricao.Name = "TxtBoxDescricao";
            TxtBoxDescricao.Size = new Size(190, 36);
            TxtBoxDescricao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(237, 42);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox TxtBoxDescricao;
        private Label label2;
        private Button button1;
        private Label label1;
    }
}