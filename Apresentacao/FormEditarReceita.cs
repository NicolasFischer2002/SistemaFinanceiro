using SistemaFinanceiro.Entidades;
using SistemaFinanceiro.Helpers;
using System.Data;

namespace SistemaFinanceiro.Apresentacao
{
    public partial class FormEditarReceita : Form
    {
        private Receita Receita { get; set; }

        public FormEditarReceita(Receita receita)
        {
            InitializeComponent();
            Receita = receita;

            ImpedirMaximizacaoMinimizacaoForm();
            CarregarReceitaGUI();
        }

        private void ImpedirMaximizacaoMinimizacaoForm()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void CarregarReceitaGUI()
        {
            PreencherTextBoxes();
            PreencherComboBoxes();
            PreencherDateTimePickers();
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

            CbBoxStatus.SelectedValue = Receita.StatusTransacao;
        }

        private void PreencherComboBoxCategoria()
        {
            var listaCategoria = EnumHelper
                .GetAllValuesAndDescriptions<CategoriaReceita>()
                .Select(t => new { Value = t.Item1, Description = t.Item2 })
                .ToList();

            CbBoxCategoria.DisplayMember = "Description";
            CbBoxCategoria.ValueMember = "Value";
            CbBoxCategoria.DataSource = listaCategoria;

            CbBoxCategoria.SelectedValue = Receita.CategoriaReceita;
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

            CbBoxTipo.SelectedValue = Receita.TipoPagamento;
        }

        private void PreencherTextBoxes()
        {
            TxtBoxValor.Text = Receita.Valor.ToString();
            NumeroParcelas.Value = Receita.Parcelas.Count();
            CbBoxStatus.SelectedValue = Receita.StatusTransacao;
            TxtBoxDescricao.Text = Receita.Descricao;
        }

        private void PreencherDateTimePickers()
        {
            dateTimePicker.Value = Receita.DataRecebimento;
        }

        private async void btnAtualizarReceita_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmResult = MessageBox.Show(
                        "Tem certeza que deseja atualizar esta receita?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    var status = (StatusTransacao)CbBoxStatus.SelectedValue!;
                    var categoria = (CategoriaReceita)CbBoxCategoria.SelectedValue!;
                    var tipoPago = (TipoPagamento)CbBoxTipo.SelectedValue!;

                    Receita novaReceita = new Receita(
                        status,
                        Convert.ToDecimal(TxtBoxValor.Text),
                        TxtBoxDescricao.Text,
                        Convert.ToInt32(NumeroParcelas.Text),
                        categoria,
                        dateTimePicker.Value,
                        tipoPago
                    );

                    await Receita.AtualizarAsync(novaReceita);

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao atualizar a receita.\n\n" +
                    "Detalhes técnicos:\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}