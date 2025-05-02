using System.Threading.Tasks;
using SistemaFinanceiro.Apresentacao;
using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro
{
    public partial class FormReceitas : Form
    {
        public FormReceitas()
        {
            InitializeComponent();
            FormDinamicoConteudo.InicializarGUI(this);
        }

        private async Task button1_Click(object sender, EventArgs e)
        {
            // validação de campos em branco 
            if (string.IsNullOrEmpty(TxtBoxDescricao.Text))
            {
                MessageBox.Show("Informe um valor válido");
                return;
            }

            var receita = new Receita(
                statusTransacao: StatusTransacao.Quitado,
                descricao: TxtBoxDescricao.Text,
                valor: Convert.ToDecimal(TxtBoxValor.Text),
                quantidadeParcelas: Convert.ToInt32(TxtBoxQtdeParcelas.Text),
                categoriaReceita: (CategoriaReceita)CbBoxCategoria.SelectedItem,
                dataRecebimento: dateTimePicker.Value,
                tipoPagamento: (TipoPagamento)CbBoxTipo.SelectedItem
                );
            try
            {
                await receita.CadastrarAsync();
                MessageBox.Show("Receita cadastrada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar receita: " + ex.Message);
            }
        }
    }
}
