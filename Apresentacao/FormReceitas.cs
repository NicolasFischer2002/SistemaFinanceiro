using SistemaFinanceiro.Apresentacao;
using SistemaFinanceiro.Entidades;
using SistemaFinanceiro.Helpers;

namespace SistemaFinanceiro
{
    public partial class FormReceitas : Form
    {
        public FormReceitas()
        {
            InitializeComponent();
            FormDinamicoConteudo.InicializarGUI(this);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var status = (StatusTransacao)CbBoxStatus.SelectedValue!;
                var categoria = (CategoriaReceita)CbBoxCategoria.SelectedValue!;
                var tipoPago = (TipoPagamento)CbBoxTipo.SelectedValue!;

                Receita receita = new Receita(
                    statusTransacao: status,
                    valor: Convert.ToDecimal(TxtBoxValor.Text),
                    descricao: TxtBoxDescricao.Text,
                    quantidadeParcelas: Convert.ToInt32(NumeroParcelas.Text),
                    categoriaReceita: categoria,
                    dataRecebimento: dateTimePicker.Value,
                    tipoPagamento: tipoPago
                );


                await receita.CadastrarAsync();
               
                LimparCampos();

                MessageBox.Show(
                    $"Receita registrada com sucesso!\n\n" +
                    "Tudo certo, continue assim!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar receita: " + ex.Message);
            }
        }

        private void FormReceitas_Load(object sender, EventArgs e)
        {
            var listaStatus = EnumHelper
            .GetAllValuesAndDescriptions<StatusTransacao>()
            .Select(t => new { Value = t.Item1, Description = t.Item2 })
            .ToList();

            CbBoxStatus.DisplayMember = "Description";
            CbBoxStatus.ValueMember = "Value";
            CbBoxStatus.DataSource = listaStatus;

            // TipoPagamento           
            var listaTipoPagamento = EnumHelper
            .GetAllValuesAndDescriptions<TipoPagamento>()
            .Select(t => new { Value = t.Item1, Description = t.Item2 })
            .ToList();
            CbBoxTipo.DisplayMember = "Description";
            CbBoxTipo.ValueMember = "Value";
            CbBoxTipo.DataSource = listaTipoPagamento;

            // CategoriaReceita
            var listaCategoria = EnumHelper
            .GetAllValuesAndDescriptions<CategoriaReceita>()
            .Select(t => new { Value = t.Item1, Description = t.Item2 })
            .ToList();
            CbBoxCategoria.DisplayMember = "Description";
            CbBoxCategoria.ValueMember = "Value";
            CbBoxCategoria.DataSource = listaCategoria;
        }

        private void LimparCampos()
        {
            TxtBoxValor.Text = "";
            CbBoxStatus.SelectedIndex = 0;
            CbBoxCategoria.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
            CbBoxTipo.SelectedIndex = 0;
            TxtBoxDescricao.Text = "";
        }
    }
}