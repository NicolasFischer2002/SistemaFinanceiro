using SistemaFinanceiro.Apresentacao.Helpers;
using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.Apresentacao
{
    public partial class FormConsultarDespesas : Form
    {
        private IReadOnlyList<Guid> IdsDespesas;

        public FormConsultarDespesas()
        {
            InitializeComponent();

            InicializarLabels();
            InicializarDataPickers();
            InicializarGrid();
            InicializarToolTips();

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
            gridDespesas.Columns.Add("DataVencimento", "Data venc.");
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
            gridDespesas.Columns[4].Width = 130;
            gridDespesas.Columns[5].Width = 400;
            gridDespesas.Columns[6].Width = 70;
            gridDespesas.Columns[7].Width = 70;
        }

        private async Task PreencherGridDespesas()
        {
            List<Despesa> despesas = await Despesa
                .ObterTodas(new Datas(dateTimePickerInicial.Value, dateTimePickerFinal.Value));
            IdsDespesas = despesas.Select(d => d.Id).ToList();

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
                    despesa.DataVencimento,
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

        private async void gridDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a linha e coluna clicadas são válidas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (gridDespesas.Columns[e.ColumnIndex].Name == "Editar")
                {
                    Despesa? despesa = await Despesa.ObterPorIdAsync(IdsDespesas[e.RowIndex]);

                    if (despesa is not null)
                    {
                        FormEditarDespesa formEditarDespesa = new FormEditarDespesa(despesa);

                        if (formEditarDespesa.ShowDialog() == DialogResult.OK)
                        {
                            await PreencherGridDespesas();
                        }
                    }
                }
                else if (gridDespesas.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    var confirmResult = MessageBox.Show(
                        "Tem certeza que deseja excluir esta despesa?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        Despesa? despesa = await Despesa.ObterPorIdAsync(IdsDespesas[e.RowIndex]);

                        if (despesa is not null)
                        {
                            await despesa.DeletarAsync();
                            await PreencherGridDespesas();
                        }
                    }
                }
            }
        }

        private async void buttonBuscar_Click(object sender, EventArgs e)
        {
            await PreencherGridDespesas();
        }

        private void InicializarToolTips()
        {
            ToolTipService.Set(buttonBuscar, "Buscar baseado na data de vencimento");
        }
    }
}