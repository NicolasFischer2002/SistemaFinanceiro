namespace SistemaFinanceiro
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            graficoReceita = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlSessaoGeral = new Panel();
            pnlSessaoGeralDireito = new Panel();
            pnlSessaoGeralEsquerdo = new Panel();
            lblTotalReceitas = new Label();
            lblSessaoGeralEsquerda = new Label();
            panel1 = new Panel();
            lblTotalDespesas = new Label();
            lblDespesas = new Label();
            panel2 = new Panel();
            graficoDespesas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop = new Panel();
            buttonBuscar = new Button();
            dateTimePickerFinal = new DateTimePicker();
            dateTimePickerInicial = new DateTimePicker();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)graficoReceita).BeginInit();
            pnlSessaoGeral.SuspendLayout();
            pnlSessaoGeralDireito.SuspendLayout();
            pnlSessaoGeralEsquerdo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)graficoDespesas).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // graficoReceita
            // 
            chartArea1.Name = "ChartArea1";
            graficoReceita.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            graficoReceita.Legends.Add(legend1);
            graficoReceita.Location = new Point(13, 18);
            graficoReceita.Name = "graficoReceita";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            graficoReceita.Series.Add(series1);
            graficoReceita.Size = new Size(288, 220);
            graficoReceita.TabIndex = 3;
            graficoReceita.Text = "chart1";
            // 
            // pnlSessaoGeral
            // 
            pnlSessaoGeral.Controls.Add(pnlSessaoGeralDireito);
            pnlSessaoGeral.Controls.Add(pnlSessaoGeralEsquerdo);
            pnlSessaoGeral.Location = new Point(1, 127);
            pnlSessaoGeral.Name = "pnlSessaoGeral";
            pnlSessaoGeral.Size = new Size(1378, 251);
            pnlSessaoGeral.TabIndex = 4;
            // 
            // pnlSessaoGeralDireito
            // 
            pnlSessaoGeralDireito.Controls.Add(graficoReceita);
            pnlSessaoGeralDireito.Dock = DockStyle.Right;
            pnlSessaoGeralDireito.Location = new Point(267, 0);
            pnlSessaoGeralDireito.Name = "pnlSessaoGeralDireito";
            pnlSessaoGeralDireito.Size = new Size(1111, 251);
            pnlSessaoGeralDireito.TabIndex = 1;
            // 
            // pnlSessaoGeralEsquerdo
            // 
            pnlSessaoGeralEsquerdo.Controls.Add(lblTotalReceitas);
            pnlSessaoGeralEsquerdo.Controls.Add(lblSessaoGeralEsquerda);
            pnlSessaoGeralEsquerdo.Dock = DockStyle.Left;
            pnlSessaoGeralEsquerdo.Location = new Point(0, 0);
            pnlSessaoGeralEsquerdo.Name = "pnlSessaoGeralEsquerdo";
            pnlSessaoGeralEsquerdo.Size = new Size(261, 251);
            pnlSessaoGeralEsquerdo.TabIndex = 0;
            // 
            // lblTotalReceitas
            // 
            lblTotalReceitas.AutoSize = true;
            lblTotalReceitas.Font = new Font("Segoe UI", 15F);
            lblTotalReceitas.Location = new Point(28, 143);
            lblTotalReceitas.Name = "lblTotalReceitas";
            lblTotalReceitas.Size = new Size(63, 28);
            lblTotalReceitas.TabIndex = 3;
            lblTotalReceitas.Text = "Total: ";
            // 
            // lblSessaoGeralEsquerda
            // 
            lblSessaoGeralEsquerda.AutoSize = true;
            lblSessaoGeralEsquerda.Font = new Font("Segoe UI", 15F);
            lblSessaoGeralEsquerda.Location = new Point(28, 101);
            lblSessaoGeralEsquerda.Name = "lblSessaoGeralEsquerda";
            lblSessaoGeralEsquerda.Size = new Size(82, 28);
            lblSessaoGeralEsquerda.TabIndex = 0;
            lblSessaoGeralEsquerda.Text = "Receitas";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotalDespesas);
            panel1.Controls.Add(lblDespesas);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 395);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 251);
            panel1.TabIndex = 5;
            // 
            // lblTotalDespesas
            // 
            lblTotalDespesas.AutoSize = true;
            lblTotalDespesas.Font = new Font("Segoe UI", 15F);
            lblTotalDespesas.Location = new Point(28, 118);
            lblTotalDespesas.Name = "lblTotalDespesas";
            lblTotalDespesas.Size = new Size(63, 28);
            lblTotalDespesas.TabIndex = 6;
            lblTotalDespesas.Text = "Total: ";
            // 
            // lblDespesas
            // 
            lblDespesas.AutoSize = true;
            lblDespesas.Font = new Font("Segoe UI", 15F);
            lblDespesas.Location = new Point(28, 74);
            lblDespesas.Name = "lblDespesas";
            lblDespesas.Size = new Size(92, 28);
            lblDespesas.TabIndex = 5;
            lblDespesas.Text = "Despesas";
            // 
            // panel2
            // 
            panel2.Controls.Add(graficoDespesas);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(267, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 251);
            panel2.TabIndex = 0;
            // 
            // graficoDespesas
            // 
            chartArea2.Name = "ChartArea1";
            graficoDespesas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            graficoDespesas.Legends.Add(legend2);
            graficoDespesas.Location = new Point(13, 12);
            graficoDespesas.Name = "graficoDespesas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            graficoDespesas.Series.Add(series2);
            graficoDespesas.Size = new Size(288, 220);
            graficoDespesas.TabIndex = 4;
            graficoDespesas.Text = "chart1";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(64, 64, 64);
            panelTop.Controls.Add(buttonBuscar);
            panelTop.Controls.Add(dateTimePickerFinal);
            panelTop.Controls.Add(dateTimePickerInicial);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1370, 80);
            panelTop.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(1107, 28);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 30);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dateTimePickerFinal
            // 
            dateTimePickerFinal.CalendarFont = new Font("Segoe UI", 17F);
            dateTimePickerFinal.Font = new Font("Segoe UI", 12F);
            dateTimePickerFinal.Location = new Point(740, 28);
            dateTimePickerFinal.Name = "dateTimePickerFinal";
            dateTimePickerFinal.Size = new Size(345, 29);
            dateTimePickerFinal.TabIndex = 2;
            // 
            // dateTimePickerInicial
            // 
            dateTimePickerInicial.CalendarFont = new Font("Segoe UI", 17F);
            dateTimePickerInicial.Font = new Font("Segoe UI", 12F);
            dateTimePickerInicial.Location = new Point(379, 28);
            dateTimePickerInicial.Name = "dateTimePickerInicial";
            dateTimePickerInicial.Size = new Size(345, 29);
            dateTimePickerInicial.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.ForeColor = Color.Snow;
            lblTitulo.Location = new Point(29, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(160, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Transações cadastradas entre";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1370, 685);
            Controls.Add(panelTop);
            Controls.Add(panel1);
            Controls.Add(pnlSessaoGeral);
            Name = "FormDashboard";
            Text = "Form1";
            Load += FormDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)graficoReceita).EndInit();
            pnlSessaoGeral.ResumeLayout(false);
            pnlSessaoGeralDireito.ResumeLayout(false);
            pnlSessaoGeralEsquerdo.ResumeLayout(false);
            pnlSessaoGeralEsquerdo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)graficoDespesas).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoReceita;
        private Panel pnlSessaoGeral;
        private Panel pnlSessaoGeralEsquerdo;
        private Panel pnlSessaoGeralDireito;
        private Label lblSessaoGeralEsquerda;
        private Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoDespesas;
        private Panel panelTop;
        private Button buttonBuscar;
        private DateTimePicker dateTimePickerFinal;
        private DateTimePicker dateTimePickerInicial;
        private Label lblTitulo;
        private Label lblTotalReceitas;
        private Label lblTotalDespesas;
        private Label lblDespesas;
    }
}