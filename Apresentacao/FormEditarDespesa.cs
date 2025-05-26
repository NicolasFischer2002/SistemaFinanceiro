using SistemaFinanceiro.Entidades;
using SistemaFinanceiro.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaFinanceiro.Apresentacao
{
    public partial class FormEditarDespesa : Form
    {
        private Despesa Despesa { get; set; }

        public FormEditarDespesa(Despesa despesa)
        {
            InitializeComponent();
            Despesa = despesa;

            ImpedirMaximizacaoMinimizacaoForm();
            CarregarDespesaGUI();
        }

        private void ImpedirMaximizacaoMinimizacaoForm()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void CarregarDespesaGUI()
        {
            PreencherTextBoxes();
            PreencherComboBoxes();
            PreencherDateTimePickers();
            PreencherRadioButtons();
        }

        private void PreencherComboBoxes()
        {
            PreencherComboBoxStatus();
            PreencherComboBoxCategoria();
            PreencherComboBoxTipoPagamento();
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

            CbBoxStatus.SelectedValue = Despesa.StatusTransacao;
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

            CbBoxCategoria.SelectedValue = Despesa.CategoriaDespesa;
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

            CbBoxTipo.SelectedValue = Despesa.TipoPagamento;
        }

        private void PreencherTextBoxes()
        {
            TxtBoxValor.Text = Despesa.Valor.ToString();
            NumeroParcelas.Value = Despesa.Parcelas.Count();
            CbBoxStatus.SelectedValue = Despesa.StatusTransacao;
            TxtBoxDescricao.Text = Despesa.Descricao;
        }

        private void PreencherDateTimePickers()
        {
            dateTimePickerVencimento.Value = Despesa.DataVencimento;
        }

        private void PreencherRadioButtons()
        {
            if (Despesa.DataPagamento is not null)
            {
                dateTimePickerPagamento.Enabled = true;
                dateTimePickerPagamento.Value = (DateTime)Despesa.DataPagamento;
                radioButtonDespesaQuitada.Checked = true;
            }
            else
            {
                dateTimePickerPagamento.Enabled = false;
                radioButtonDespesaEmAberto.Checked = true;
            }
        }

        private void radioButtonDespesaQuitada_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerPagamento.Enabled = true;
        }

        private void radioButtonDespesaEmAberto_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerPagamento.Enabled = false;
        }

        private async void btnInserirDespesa_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(
                        "Tem certeza que deseja atualizar esta despesa?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var status = (StatusTransacao)CbBoxStatus.SelectedValue!;
                    var categoria = (CategoriaDespesa)CbBoxCategoria.SelectedValue!;
                    var tipoPago = (TipoPagamento)CbBoxTipo.SelectedValue!;

                    Despesa novaDespesa = new Despesa(
                        statusTransacao: status,
                        valor: Convert.ToDecimal(TxtBoxValor.Text),
                        quantidadeParcelas: Convert.ToInt32(NumeroParcelas.Text),
                        descricao: TxtBoxDescricao.Text,
                        categoriaDespesa: categoria,
                        dataVencimento: dateTimePickerVencimento.Value,
                        dataPagamento: dateTimePickerPagamento.Enabled ? dateTimePickerPagamento.Value : null,
                        tipoPagamento: tipoPago
                    );

                    await Despesa.AtualizarAsync(novaDespesa);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Ocorreu um erro ao atualizar a despesa.\n\n" +
                        "Detalhes técnicos:\n" + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}