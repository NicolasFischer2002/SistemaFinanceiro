namespace SistemaFinanceiro.Apresentacao
{
    partial class FormConsultarDespesas
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
            panelTop = new Panel();
            dateTimePickerFinal = new DateTimePicker();
            dateTimePickerInicial = new DateTimePicker();
            lblTitulo = new Label();
            panelCenter = new Panel();
            gridDespesas = new DataGridView();
            buttonBuscar = new Button();
            panelTop.SuspendLayout();
            panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDespesas).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.LightSkyBlue;
            panelTop.Controls.Add(buttonBuscar);
            panelTop.Controls.Add(dateTimePickerFinal);
            panelTop.Controls.Add(dateTimePickerInicial);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1370, 80);
            panelTop.TabIndex = 0;
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
            lblTitulo.Location = new Point(29, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Despesas cadastradas entre";
            // 
            // panelCenter
            // 
            panelCenter.Controls.Add(gridDespesas);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(0, 80);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(1370, 605);
            panelCenter.TabIndex = 1;
            // 
            // gridDespesas
            // 
            gridDespesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDespesas.Dock = DockStyle.Fill;
            gridDespesas.Location = new Point(0, 0);
            gridDespesas.Name = "gridDespesas";
            gridDespesas.Size = new Size(1370, 605);
            gridDespesas.TabIndex = 0;
            gridDespesas.CellClick += gridDespesas_CellClick;
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
            // FormConsultarDespesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 685);
            Controls.Add(panelCenter);
            Controls.Add(panelTop);
            Name = "FormConsultarDespesas";
            Text = "FormConsultarDespesas";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridDespesas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblTitulo;
        private DateTimePicker dateTimePickerFinal;
        private DateTimePicker dateTimePickerInicial;
        private Panel panelCenter;
        private DataGridView gridDespesas;
        private Button buttonBuscar;
    }
}