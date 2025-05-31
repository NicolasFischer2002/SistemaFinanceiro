using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFinanceiro.Apresentacao.Helpers;
using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.Apresentacao
{
    public partial class FormConsultarReceitas : Form
    {
        private IReadOnlyList<Guid> IdsReceitas;

        public FormConsultarReceitas()
        {
            InitializeComponent();

            InicializarLabels();
            InicializarDataPickers();
            InicializarGrid();
            InicializarToolTips();

            PreencherGridReceitas();
        }
        private void InicializarLabels()
        {
            lblTitulo.Text = "Receitas cadastradas entre as datas";
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
            gridReceitas.Columns.Clear(); // limpar colunas anteriores

            // Colunas de texto
            gridReceitas.Columns.Add("Id", "Id");
            gridReceitas.Columns.Add("Valor", "Valor");
            gridReceitas.Columns.Add("Categoria", "Categoria");
            gridReceitas.Columns.Add("Descricao", "Descrição");
            gridReceitas.Columns.Add("Data recebimento", "Data rec.");            
            

            // Coluna de imagem: Editar
            DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
            colEditar.Name = "Editar";
            colEditar.HeaderText = "Editar";
            colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            gridReceitas.Columns.Add(colEditar);

            // Coluna de imagem: Excluir
            DataGridViewImageColumn colExcluir = new DataGridViewImageColumn();           
            colExcluir.Name = "Excluir";
            colExcluir.HeaderText = "Excluir";
            colExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            gridReceitas.Columns.Add(colExcluir);

            // Estilização
            gridReceitas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in gridReceitas.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            InicializarLargurasColunas();
            gridReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void InicializarLargurasColunas()
        {
            gridReceitas.Columns[0].Width = 50;
            gridReceitas.Columns[1].Width = 150;
            gridReceitas.Columns[2].Width = 250;
            gridReceitas.Columns[3].Width = 130;            
            gridReceitas.Columns[4].Width = 400;
            gridReceitas.Columns[5].Width = 70;
            gridReceitas.Columns[6].Width = 70;
        }

        private async Task PreencherGridReceitas()
        {
            List<Receita> receitas = await Receita
                .ObterTodas(new Datas(dateTimePickerInicial.Value, dateTimePickerFinal.Value));
            IdsReceitas = receitas.Select(r => r.Id).ToList();

            gridReceitas.Rows.Clear();

            string caminhoIconeLixo = Path.Combine(Application.StartupPath, "Apresentacao", "Imagens", "icone_lixo.png");
            string caminhoIconeEditar = Path.Combine(Application.StartupPath, "Apresentacao", "Imagens", "icone_editar.png");

            Image iconeLixo = Image.FromFile(caminhoIconeLixo);
            Image iconeEditar = Image.FromFile(caminhoIconeEditar);

            int contador = 1;

            foreach (var receita in receitas)
            {
                gridReceitas.Rows.Add(
                    contador,
                    receita.Id,
                    receita.Valor,
                    receita.CategoriaReceita,
                    receita.Descricao,
                    receita.DataRecebimento,                 
                    iconeEditar,
                    iconeLixo
                );

                contador++;
            }
        }

        private void DeixarGridSomenteLeitura()
        {
            gridReceitas.AllowUserToAddRows = false;
        }

        private async void gridReceitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a linha e coluna clicadas são válidas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (gridReceitas.Columns[e.ColumnIndex].Name == "Editar")
                {
                    Receita? receita = await Receita.ObterPorIdAsync(IdsReceitas[e.RowIndex]);

                    if (receita is not null)
                    {
                        FormEditarReceita formEditarReceita = new FormEditarReceita(receita);

                        if (formEditarReceita.ShowDialog() == DialogResult.OK)
                        {
                            await PreencherGridReceitas();
                        }
                    }
                }
                else if (gridReceitas.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    var confirmResult = MessageBox.Show(
                        "Tem certeza que deseja excluir esta receita?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        Receita? receita = await Receita.ObterPorIdAsync(IdsReceitas[e.RowIndex]);

                        if (receita is not null)
                        {
                            await receita.DeletarAsync();
                            await PreencherGridReceitas();
                        }
                    }
                }
            }
        }

        private async void buttonBuscar_Click(object sender, EventArgs e)
        {
            await PreencherGridReceitas();
        }

        private void InicializarToolTips()
        {
            ToolTipService.Set(buttonBuscar, "Buscar baseado na data de vencimento");
        }


    }
}
