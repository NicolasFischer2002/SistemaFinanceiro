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
            PnlCentral = new Panel();
            PnlTelaDinamica = new Panel();
            PnlMenuLateral = new Panel();
            BtnReceitas = new Button();
            BtnDespesas = new Button();
            BtnDashboard = new Button();
            PnlLinhaRodape = new Panel();
            PnlLinhaLogo = new Panel();
            PnlRodapeMenuLateral = new Panel();
            PnlLogoMenuLateral = new Panel();
            LblTitulo = new Label();
            PnlCentral.SuspendLayout();
            PnlMenuLateral.SuspendLayout();
            PnlLogoMenuLateral.SuspendLayout();
            SuspendLayout();
            // 
            // PnlCentral
            // 
            PnlCentral.Controls.Add(PnlTelaDinamica);
            PnlCentral.Dock = DockStyle.Fill;
            PnlCentral.Location = new Point(0, 0);
            PnlCentral.Name = "PnlCentral";
            PnlCentral.Size = new Size(1395, 724);
            PnlCentral.TabIndex = 0;
            // 
            // PnlTelaDinamica
            // 
            PnlTelaDinamica.Dock = DockStyle.Fill;
            PnlTelaDinamica.Location = new Point(0, 0);
            PnlTelaDinamica.Name = "PnlTelaDinamica";
            PnlTelaDinamica.Size = new Size(1395, 724);
            PnlTelaDinamica.TabIndex = 0;
            // 
            // PnlMenuLateral
            // 
            PnlMenuLateral.Controls.Add(BtnReceitas);
            PnlMenuLateral.Controls.Add(BtnDespesas);
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
            // 
            // BtnDespesas
            // 
            BtnDespesas.Location = new Point(10, 170);
            BtnDespesas.Name = "BtnDespesas";
            BtnDespesas.Size = new Size(330, 45);
            BtnDespesas.TabIndex = 5;
            BtnDespesas.Text = "Despesas";
            BtnDespesas.UseVisualStyleBackColor = true;
            // 
            // BtnDashboard
            // 
            BtnDashboard.Location = new Point(10, 119);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(330, 45);
            BtnDashboard.TabIndex = 4;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.UseVisualStyleBackColor = true;
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
            PnlLinhaLogo.Location = new Point(0, 100);
            PnlLinhaLogo.Name = "PnlLinhaLogo";
            PnlLinhaLogo.Size = new Size(350, 2);
            PnlLinhaLogo.TabIndex = 2;
            // 
            // PnlRodapeMenuLateral
            // 
            PnlRodapeMenuLateral.Dock = DockStyle.Bottom;
            PnlRodapeMenuLateral.Location = new Point(0, 624);
            PnlRodapeMenuLateral.Name = "PnlRodapeMenuLateral";
            PnlRodapeMenuLateral.Size = new Size(350, 100);
            PnlRodapeMenuLateral.TabIndex = 1;
            // 
            // PnlLogoMenuLateral
            // 
            PnlLogoMenuLateral.Controls.Add(LblTitulo);
            PnlLogoMenuLateral.Dock = DockStyle.Top;
            PnlLogoMenuLateral.Location = new Point(0, 0);
            PnlLogoMenuLateral.Name = "PnlLogoMenuLateral";
            PnlLogoMenuLateral.Size = new Size(350, 100);
            PnlLogoMenuLateral.TabIndex = 0;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Location = new Point(135, 46);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(106, 15);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Sistema Financeiro";
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 724);
            Controls.Add(PnlMenuLateral);
            Controls.Add(PnlCentral);
            Name = "FormInicial";
            Text = "Form1";
            PnlCentral.ResumeLayout(false);
            PnlMenuLateral.ResumeLayout(false);
            PnlLogoMenuLateral.ResumeLayout(false);
            PnlLogoMenuLateral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlCentral;
        private Panel PnlMenuLateral;
        private Panel PnlTelaDinamica;
        private Panel PnlLogoMenuLateral;
        private Panel PnlRodapeMenuLateral;
        private Panel PnlLinhaLogo;
        private Panel PnlLinhaRodape;
        private Button BtnDashboard;
        private Button BtnReceitas;
        private Button BtnDespesas;
        private Label LblTitulo;
    }
}