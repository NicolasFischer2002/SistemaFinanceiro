using System.Threading.Tasks;
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
                // recupera cada enum diretamente de SelectedValue
                var status = (StatusTransacao)CbBoxStatus.SelectedValue!;
                var categoria = (CategoriaReceita)CbBoxCategoria.SelectedValue!;
                var tipoPago = (TipoPagamento)CbBoxTipo.SelectedValue!;

                var ValorTransacao = Convert.ToDecimal(TxtBoxValor.Text);// TIBET 


                // monta a receita
                Receita receita = new Receita(
                    statusTransacao: status,
                    valor: ValorTransacao,
                    descricao: TxtBoxDescricao.Text,
                    quantidadeParcelas: Convert.ToInt32(TxtBoxQtdeParcelas.Text),
                    categoriaReceita: categoria,
                    dataRecebimento: dateTimePicker.Value,
                    tipoPagamento: tipoPago
                );
                await Task.Run(() => receita.CadastrarAsync());
                MessageBox.Show("Receita cadastrada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar receita: " + ex.Message);
            }
        }


        private void FormReceitas_Shown(object sender, EventArgs e)
        {

        }

        private void FormReceitas_Load(object sender, EventArgs e)
        {
            // StatusTransacao
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

    }
}
