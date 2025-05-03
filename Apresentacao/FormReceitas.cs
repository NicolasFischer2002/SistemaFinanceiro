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
                Receita receita = new Receita(
                statusTransacao: StatusTransacao.Quitado,
                descricao: TxtBoxDescricao.Text,
                valor: Convert.ToDecimal(TxtBoxValor.Text),
                quantidadeParcelas: Convert.ToInt32(TxtBoxQtdeParcelas.Text),
                categoriaReceita: (CategoriaReceita)CbBoxCategoria.SelectedItem,
                dataRecebimento: dateTimePicker.Value,
                tipoPagamento: (TipoPagamento)CbBoxTipo.SelectedItem
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
            // Preenchimento dos combobox
            var ListaStatus = EnumHelper.GetAllDescriptions<StatusTransacao>();

            CbBoxStatus.DisplayMember = "Description";
            CbBoxStatus.ValueMember   = "Value";
            CbBoxStatus.DataSource = ListaStatus.ToList();


            var ListaTipoPagamento = EnumHelper.GetAllDescriptions<TipoPagamento>();

            CbBoxTipo.DisplayMember = "Description";
            CbBoxTipo.ValueMember = "Value";
            CbBoxTipo.DataSource = ListaTipoPagamento.ToList();

            
            var ListaCategoria = EnumHelper.GetAllDescriptions<CategoriaReceita>();

            CbBoxCategoria.DisplayMember = "Description";
            CbBoxCategoria.ValueMember = "Value";
            CbBoxCategoria.DataSource = ListaCategoria.ToList();
        }
    }
}
