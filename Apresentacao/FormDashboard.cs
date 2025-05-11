using SistemaFinanceiro.Apresentacao;
using SistemaFinanceiro.Apresentacao.Helpers;
using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            FormDinamicoConteudo.InicializarGUI(this);

            InicializarLabels();
        }

        private void InicializarLabels()
        {
            LabelService.InicializarTexto(lblSessaoGeralEsquerda);
        }

        private async Task InicializarGraficos()
        {
            var receitas = await Receita.ObterTodas();

            var dados = new Dictionary<string, double>
            {
                ["Salário"] = (double)Receita.ValorSalarios(receitas, new Datas()),
                ["Alimentação"] = 500,
                ["Transporte"] = 200,
                ["Lazer"] = 300
            };

            GraficoPizzaService.InicializarExistente(graficoGeral, dados);
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            InicializarGraficos();
        }
    }
}