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
            LabelService.InicializarTexto(lblDespesas);
        }

        private async Task InicializarGraficos()
        {
            InicializarGraficoGeral();
            InicializarGraficoDespesas();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            InicializarGraficos();
        }

        private async void InicializarGraficoGeral()
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

        private async void InicializarGraficoDespesas()
        {
            var despesas = await Despesa.ObterTodas();
            Datas datas = new Datas();

            var dados = new Dictionary<string, double>
            {
                ["Alimentação"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Alimentacao),
                ["Transporte"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Transporte),
                ["Moradia"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Moradia),
                ["Saúde"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Saude),
                ["Educação"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Educacao),
                ["Lazer e Entretenimento"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Lazer),
                ["Viagens"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Viagem),
                ["Vestuário"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Vestuario),
                ["Assinaturas e Streaming"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Assinaturas),
                ["Contas e Serviços (água, luz, internet)"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.ContasServicos),
                ["Impostos e Taxas"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Impostos),
                ["Manutenção e Reparos"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Manutencao),
                ["Presentes e Doações"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Presentes),
                ["Outras Despesas"] = (double)Despesa.ValorPorCategoria(despesas, datas, CategoriaDespesa.Outros),
            };

            GraficoPizzaService.InicializarExistente(graficoDespesas, dados);
        }
    }
}