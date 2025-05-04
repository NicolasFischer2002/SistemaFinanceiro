using SistemaFinanceiro.Apresentacao;
using SistemaFinanceiro.Apresentacao.Helpers;

namespace SistemaFinanceiro
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            FormDinamicoConteudo.InicializarGUI(this);

            InicializarLabels();
            InicializarGraficoGeral();
        }

        private void InicializarLabels()
        {
            LabelService.InicializarTexto(lblSessaoGeralEsquerda);
        }

        private void InicializarGraficoGeral()
        {
            var dados = new Dictionary<string, double>
            {
                ["Salário"] = 2000,
                ["Alimentação"] = 500,
                ["Transporte"] = 200,
                ["Lazer"] = 300
            };

            GraficoPizzaService.InicializarExistente(graficoGeral, dados);
        }
    }
}