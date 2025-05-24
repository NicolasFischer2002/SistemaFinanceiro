namespace SistemaFinanceiro.Apresentacao
{
    public partial class FormConsultarDespesas : Form
    {
        public FormConsultarDespesas()
        {
            InitializeComponent();
            
            InicializarLabels();
            InicializarDataPickers();
            InicializarGrid();
        }

        private void InicializarLabels()
        {
            lblTitulo.Text = "Despesas cadastradas entre as datas";
            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void InicializarDataPickers()
        {
            DateTime primeiroDiaMesCorrente = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime ultimoDiaMesCorrente = primeiroDiaMesCorrente.AddMonths(1).AddDays(-1);

            dateTimePickerInicial.Value = primeiroDiaMesCorrente;
            dateTimePickerFinal.Value = ultimoDiaMesCorrente;
        }

        private void InicializarGrid()
        {
            InicializarColunas();
        }

        private void InicializarColunas()
        {
            gridDespesas.ColumnCount = 6;

            InicializarNomesColunas();
            InicializarLargurasColunas();

            gridDespesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void InicializarNomesColunas()
        {
            gridDespesas.Columns[0].Name = "Id";
            gridDespesas.Columns[1].Name = "Valor";
            gridDespesas.Columns[2].Name = "Categoria";
            gridDespesas.Columns[3].Name = "Data";
            gridDespesas.Columns[4].Name = "Editar";
            gridDespesas.Columns[5].Name = "Excluir";
        }

        private void InicializarLargurasColunas()
        {
            gridDespesas.Columns[0].Width = 80;
            gridDespesas.Columns[1].Width = 150;
            gridDespesas.Columns[2].Width = 250;
            gridDespesas.Columns[3].Width = 150;
            gridDespesas.Columns[4].Width = 100;
            gridDespesas.Columns[5].Width = 100;
        }
    }
}
