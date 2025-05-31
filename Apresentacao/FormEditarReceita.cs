using System.Data;
using SistemaFinanceiro.Entidades;
using SistemaFinanceiro.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                .GetAllValuesAndDescriptions<CategoriaDespesa>()
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
                    var categoria = (CategoriaReceita)CbBoxCategoria.SelectedValue!;
                    var tipoPago = (TipoPagamento)CbBoxTipo.SelectedValue!;

                    Receita novaReceita = new Receita(
                        statusTransacao: status,
                        valor: Convert.ToDecimal(TxtBoxValor.Text),
                        quantidadeParcelas: Convert.ToInt32(NumeroParcelas.Text),
                        descricao: TxtBoxDescricao.Text,
                        categoriaReceita: categoria,
                        dataRecebimento: dateTimePicker.Value,
                  
                        tipoPagamento: tipoPago
                    );

                    await Receita.AtualizarAsync(novaReceita);

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