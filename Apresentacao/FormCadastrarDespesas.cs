using SistemaFinanceiro.Apresentacao;
using SistemaFinanceiro.Entidades;
using SistemaFinanceiro.Helpers;

namespace SistemaFinanceiro
{
    public partial class FormCadastrarDespesas : Form
    {
        public FormCadastrarDespesas()
        {
            InitializeComponent();
            FormDinamicoConteudo.InicializarGUI(this);
        }

        private void NumeroParcelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDespesas_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(0xB2, 0xDB, 0xD5);

            PreencherComboBoxStatus();
            PreencherComboBoxTipoPagamento();
            PreencherComboBoxCategoria();

            radioButtonDespesaQuitada.Checked = true;
        }

        private void PreencherComboBoxStatus()
        {
            var listaStatus = EnumHelper
                .GetAllValuesAndDescriptions<StatusTransacao>()
                .Select(t => new { Value = t.Item1, Description = t.Item2 })
                .ToList();

            CbBoxStatus.DisplayMember = "Description";
            CbBoxStatus.ValueMember = "Value";
            CbBoxStatus.DataSource = listaStatus;
        }

        private void PreencherComboBoxTipoPagamento()
        {
            var listaTipoPagamento = EnumHelper
                .GetAllValuesAndDescriptions<TipoPagamento>()
                .Select(t => new { Value = t.Item1, Description = t.Item2 })
                .ToList();

            CbBoxTipo.DisplayMember = "Description";
            CbBoxTipo.ValueMember = "Value";
            CbBoxTipo.DataSource = listaTipoPagamento;
        }

        private void PreencherComboBoxCategoria()
        {
            var listaCategoria = EnumHelper
                .GetAllValuesAndDescriptions<CategoriaDespesa>()
                .Select(t => new { Value = t.Item1, Description = t.Item2 })
                .ToList();

            CbBoxCategoria.DisplayMember = "Description";
            CbBoxCategoria.ValueMember = "Value";
            CbBoxCategoria.DataSource = listaCategoria;
        }

        private void radioButtonDespesaQuitada_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDespesaQuitada.Checked)
            {
                dateTimePickerPagamento.Enabled = true;
            }
        }

        private void radioButtonDespesaEmAberto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDespesaEmAberto.Checked)
            {
                dateTimePickerPagamento.Enabled = false;
            }
        }

        private async void btnInserirDespesa_Click(object sender, EventArgs e)
        {
            try
            {
                var status = (StatusTransacao)CbBoxStatus.SelectedValue!;
                var categoria = (CategoriaDespesa)CbBoxCategoria.SelectedValue!;
                var tipoPago = (TipoPagamento)CbBoxTipo.SelectedValue!;

                Despesa despesa = new Despesa(
                    statusTransacao: status,
                    valor: Convert.ToDecimal(TxtBoxValor.Text),
                    quantidadeParcelas: Convert.ToInt32(NumeroParcelas.Text),
                    descricao: TxtBoxDescricao.Text,
                    categoriaDespesa: categoria,
                    dataVencimento: dateTimePickerVencimento.Value,
                    dataPagamento: dateTimePickerPagamento.Enabled ? dateTimePickerPagamento.Value : null,
                    tipoPagamento: tipoPago
                );

                await despesa.CadastrarAsync();

                LimparCampos();

                MessageBox.Show(
                    $"Despesa registrada com sucesso!\n\n" +
                    "Tudo certo, continue assim!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ops! Não foi possível salvar sua despesa.\n\n" +
                    "Tente novamente ou contate o suporte.\n\n" +
                    $"Erro: {ex.Message}",
                    "Falha ao cadastrar despesa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LimparCampos()
        {
            TxtBoxValor.Text = "";           
            CbBoxStatus.SelectedIndex = 0;
            CbBoxCategoria.SelectedIndex = 0;
            dateTimePickerPagamento.Value = DateTime.Now;
            CbBoxTipo.SelectedIndex = 0;
            dateTimePickerVencimento.Value = DateTime.Now;

            TxtBoxDescricao.Text = "";
        }
    }
}