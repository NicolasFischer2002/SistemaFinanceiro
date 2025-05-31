namespace SistemaFinanceiro.Apresentacao
{
    partial class FormConsultarReceitas
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
            gridReceitas = new DataGridView();
            lblTitulo = new Label();
            panelTop = new Panel();
            buttonBuscar = new Button();
            dateTimePickerFinal = new DateTimePicker();
            dateTimePickerInicial = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)gridReceitas).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // gridReceitas
            // 
            gridReceitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReceitas.Dock = DockStyle.Fill;
            gridReceitas.Location = new Point(0, 0);
            gridReceitas.Name = "gridReceitas";
            gridReceitas.Size = new Size(1370, 685);
            gridReceitas.TabIndex = 1;
            gridReceitas.CellClick += this.gridReceitas_CellClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(29, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Receitas cadastradas entre";
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
            panelTop.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(1107, 28);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 30);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
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
            // FormConsultarReceitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 685);
            Controls.Add(panelTop);
            Controls.Add(gridReceitas);
            Name = "FormConsultarReceitas";
            Text = "FormConsultarReceita";
            ((System.ComponentModel.ISupportInitialize)gridReceitas).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridReceitas;
        private Label lblTitulo;
        private Panel panelTop;
        private Button buttonBuscar;
        private DateTimePicker dateTimePickerFinal;
        private DateTimePicker dateTimePickerInicial;
    }
}