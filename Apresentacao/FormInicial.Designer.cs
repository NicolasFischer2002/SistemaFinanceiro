namespace SistemaFinanceiro
{
    partial class FormInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlMenuLateral = new Panel();
            BtnReceitas = new Button();
            BtnCadastrarDespesas = new Button();
            BtnDashboard = new Button();
            PnlLinhaRodape = new Panel();
            PnlLinhaLogo = new Panel();
            PnlRodapeMenuLateral = new Panel();
            pictureBoxPower = new PictureBox();
            PnlLogoMenuLateral = new Panel();
            panel1 = new Panel();
            pictureBoxLogo = new PictureBox();
            LblTitulo = new Label();
            PnlTelaDinamica = new Panel();
            btnConsultarDespesas = new Button();
            PnlMenuLateral.SuspendLayout();
            PnlRodapeMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPower).BeginInit();
            PnlLogoMenuLateral.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // PnlMenuLateral
            // 
            PnlMenuLateral.Controls.Add(btnConsultarDespesas);
            PnlMenuLateral.Controls.Add(BtnReceitas);
            PnlMenuLateral.Controls.Add(BtnCadastrarDespesas);
            PnlMenuLateral.Controls.Add(BtnDashboard);
            PnlMenuLateral.Controls.Add(PnlLinhaRodape);
            PnlMenuLateral.Controls.Add(PnlLinhaLogo);
            PnlMenuLateral.Controls.Add(PnlRodapeMenuLateral);
            PnlMenuLateral.Controls.Add(PnlLogoMenuLateral);
            PnlMenuLateral.Dock = DockStyle.Left;
            PnlMenuLateral.Location = new Point(0, 0);
            PnlMenuLateral.Name = "PnlMenuLateral";
            PnlMenuLateral.Size = new Size(350, 724);
            PnlMenuLateral.TabIndex = 1;
            // 
            // BtnReceitas
            // 
            BtnReceitas.Location = new Point(10, 221);
            BtnReceitas.Name = "BtnReceitas";
            BtnReceitas.Size = new Size(330, 45);
            BtnReceitas.TabIndex = 6;
            BtnReceitas.Text = "Receitas";
            BtnReceitas.UseVisualStyleBackColor = true;
            BtnReceitas.Click += BtnReceitas_Click;
            // 
            // BtnCadastrarDespesas
            // 
            BtnCadastrarDespesas.Location = new Point(10, 170);
            BtnCadastrarDespesas.Name = "BtnCadastrarDespesas";
            BtnCadastrarDespesas.Size = new Size(330, 45);
            BtnCadastrarDespesas.TabIndex = 5;
            BtnCadastrarDespesas.Text = "Cadastrar Despesas";
            BtnCadastrarDespesas.UseVisualStyleBackColor = true;
            BtnCadastrarDespesas.Click += BtnDespesas_Click;
            // 
            // BtnDashboard
            // 
            BtnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDashboard.Location = new Point(10, 119);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(330, 45);
            BtnDashboard.TabIndex = 4;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.UseVisualStyleBackColor = true;
            BtnDashboard.Click += BtnDashboard_Click;
            // 
            // PnlLinhaRodape
            // 
            PnlLinhaRodape.Dock = DockStyle.Bottom;
            PnlLinhaRodape.Location = new Point(0, 622);
            PnlLinhaRodape.Name = "PnlLinhaRodape";
            PnlLinhaRodape.Size = new Size(350, 2);
            PnlLinhaRodape.TabIndex = 3;
            // 
            // PnlLinhaLogo
            // 
            PnlLinhaLogo.Dock = DockStyle.Top;
            PnlLinhaLogo.Location = new Point(0, 90);
            PnlLinhaLogo.Name = "PnlLinhaLogo";
            PnlLinhaLogo.Size = new Size(350, 2);
            PnlLinhaLogo.TabIndex = 2;
            // 
            // PnlRodapeMenuLateral
            // 
            PnlRodapeMenuLateral.Controls.Add(pictureBoxPower);
            PnlRodapeMenuLateral.Dock = DockStyle.Bottom;
            PnlRodapeMenuLateral.Location = new Point(0, 624);
            PnlRodapeMenuLateral.Name = "PnlRodapeMenuLateral";
            PnlRodapeMenuLateral.Size = new Size(350, 100);
            PnlRodapeMenuLateral.TabIndex = 1;
            // 
            // pictureBoxPower
            // 
            pictureBoxPower.Location = new Point(19, 25);
            pictureBoxPower.Name = "pictureBoxPower";
            pictureBoxPower.Size = new Size(50, 50);
            pictureBoxPower.TabIndex = 0;
            pictureBoxPower.TabStop = false;
            pictureBoxPower.Click += pictureBoxPower_Click;
            // 
            // PnlLogoMenuLateral
            // 
            PnlLogoMenuLateral.Controls.Add(panel1);
            PnlLogoMenuLateral.Controls.Add(LblTitulo);
            PnlLogoMenuLateral.Dock = DockStyle.Top;
            PnlLogoMenuLateral.Location = new Point(0, 0);
            PnlLogoMenuLateral.Name = "PnlLogoMenuLateral";
            PnlLogoMenuLateral.Size = new Size(350, 90);
            PnlLogoMenuLateral.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 90);
            panel1.TabIndex = 2;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(19, 11);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(70, 70);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Location = new Point(133, 34);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(106, 15);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Sistema Financeiro";
            // 
            // PnlTelaDinamica
            // 
            PnlTelaDinamica.BackColor = SystemColors.ActiveCaption;
            PnlTelaDinamica.Dock = DockStyle.Fill;
            PnlTelaDinamica.Location = new Point(350, 0);
            PnlTelaDinamica.Name = "PnlTelaDinamica";
            PnlTelaDinamica.Size = new Size(1045, 724);
            PnlTelaDinamica.TabIndex = 2;
            // 
            // btnConsultarDespesas
            // 
            btnConsultarDespesas.Location = new Point(10, 272);
            btnConsultarDespesas.Name = "btnConsultarDespesas";
            btnConsultarDespesas.Size = new Size(330, 45);
            btnConsultarDespesas.TabIndex = 7;
            btnConsultarDespesas.Text = "Consultar Despesas";
            btnConsultarDespesas.UseVisualStyleBackColor = true;
            btnConsultarDespesas.Click += btnConsultarDespesas_Click;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 724);
            Controls.Add(PnlTelaDinamica);
            Controls.Add(PnlMenuLateral);
            Name = "FormInicial";
            Text = "Form1";
            Load += FormInicial_Load;
            PnlMenuLateral.ResumeLayout(false);
            PnlRodapeMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPower).EndInit();
            PnlLogoMenuLateral.ResumeLayout(false);
            PnlLogoMenuLateral.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PnlMenuLateral;
        private Panel PnlLogoMenuLateral;
        private Panel PnlRodapeMenuLateral;
        private Panel PnlLinhaLogo;
        private Panel PnlLinhaRodape;
        private Button BtnDashboard;
        private Button BtnReceitas;
        private Button BtnCadastrarDespesas;
        private Label LblTitulo;
        private Panel PnlTelaDinamica;
        private PictureBox pictureBoxLogo;
        private Panel panel1;
        private PictureBox pictureBoxPower;
        private Button btnConsultarDespesas;
    }
}