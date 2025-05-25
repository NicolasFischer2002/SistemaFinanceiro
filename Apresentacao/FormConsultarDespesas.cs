using SistemaFinanceiro.Entidades;

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

            PreencherGridDespesas();
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
            DeixarGridSomenteLeitura();
        }

        private void InicializarColunas()
        {
            gridDespesas.Columns.Clear(); // limpar colunas anteriores

            // Colunas de texto
            gridDespesas.Columns.Add("Id", "Id");
            gridDespesas.Columns.Add("Valor", "Valor");
            gridDespesas.Columns.Add("Categoria", "Categoria");
            gridDespesas.Columns.Add("DataPagamento", "Data pag.");
            gridDespesas.Columns.Add("Descricao", "Descrição");

            // Coluna de imagem: Editar
            DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
            colEditar.Name = "Editar";
            colEditar.HeaderText = "Editar";
            colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            gridDespesas.Columns.Add(colEditar);

            // Coluna de imagem: Excluir
            DataGridViewImageColumn colExcluir = new DataGridViewImageColumn();
            colExcluir.Name = "Excluir";
            colExcluir.HeaderText = "Excluir";
            colExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            gridDespesas.Columns.Add(colExcluir);

            // Estilização
            gridDespesas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in gridDespesas.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            InicializarLargurasColunas();
            gridDespesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void InicializarLargurasColunas()
        {
            gridDespesas.Columns[0].Width = 50;
            gridDespesas.Columns[1].Width = 150;
            gridDespesas.Columns[2].Width = 250;
            gridDespesas.Columns[3].Width = 130;
            gridDespesas.Columns[4].Width = 400;
            gridDespesas.Columns[5].Width = 70;
            gridDespesas.Columns[6].Width = 70;
        }

        private async Task PreencherGridDespesas()
        {
            List<Despesa> despesas = await Despesa.ObterTodas();
            gridDespesas.Rows.Clear();

            string caminhoIconeLixo = Path.Combine(Application.StartupPath, "Apresentacao", "Imagens", "icone_lixo.png");
            string caminhoIconeEditar = Path.Combine(Application.StartupPath, "Apresentacao", "Imagens", "icone_editar.png");

            Image iconeLixo = Image.FromFile(caminhoIconeLixo);
            Image iconeEditar = Image.FromFile(caminhoIconeEditar);

            int contador = 1;

            foreach (var despesa in despesas)
            {
                gridDespesas.Rows.Add(
                    contador,
                    despesa.Valor,
                    despesa.CategoriaDespesa,
                    despesa.DataPagamento,
                    despesa.Descricao,
                    iconeEditar,
                    iconeLixo
                );

                contador++;
            }
        }

        private void DeixarGridSomenteLeitura()
        {
            gridDespesas.AllowUserToAddRows = false;
        }
    }
}