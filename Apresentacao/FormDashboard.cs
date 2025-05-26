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
            InicializarDataPickers();
            InicializarTotalDespesas();
        }

        private void InicializarLabels()
        {
            LabelService.InicializarTexto(lblSessaoGeralEsquerda);
            LabelService.InicializarTexto(lblDespesas);

            InicializarLabelTitulo();
        }

        private void InicializarLabelTitulo()
        {
            lblTitulo.Text = "Despesas cadastradas entre as datas";
            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
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
            var despesas = await Despesa.ObterTodas(new Datas(dateTimePickerInicial.Value, dateTimePickerFinal.Value));
            Datas datas = new Datas();

            var dados = new Dictionary<string, double>();

            AdicionarSePositivo(dados, despesas, datas, "Alimentação", CategoriaDespesa.Alimentacao);
            AdicionarSePositivo(dados, despesas, datas, "Transporte", CategoriaDespesa.Transporte);
            AdicionarSePositivo(dados, despesas, datas, "Moradia", CategoriaDespesa.Moradia);
            AdicionarSePositivo(dados, despesas, datas, "Saúde", CategoriaDespesa.Saude);
            AdicionarSePositivo(dados, despesas, datas, "Educação", CategoriaDespesa.Educacao);
            AdicionarSePositivo(dados, despesas, datas, "Lazer e Entretenimento", CategoriaDespesa.Lazer);
            AdicionarSePositivo(dados, despesas, datas, "Viagens", CategoriaDespesa.Viagem);
            AdicionarSePositivo(dados, despesas, datas, "Vestuário", CategoriaDespesa.Vestuario);
            AdicionarSePositivo(dados, despesas, datas, "Assinaturas e Streaming", CategoriaDespesa.Assinaturas);
            AdicionarSePositivo(dados, despesas, datas, "Contas e Serviços (água, luz, internet)", CategoriaDespesa.ContasServicos);
            AdicionarSePositivo(dados, despesas, datas, "Impostos e Taxas", CategoriaDespesa.Impostos);
            AdicionarSePositivo(dados, despesas, datas, "Manutenção e Reparos", CategoriaDespesa.Manutencao);
            AdicionarSePositivo(dados, despesas, datas, "Presentes e Doações", CategoriaDespesa.Presentes);
            AdicionarSePositivo(dados, despesas, datas, "Outras Despesas", CategoriaDespesa.Outros);

            GraficoPizzaService.InicializarExistente(graficoDespesas, dados);
        }

        private void AdicionarSePositivo(Dictionary<string, double> dados, List<Despesa> despesas,
            Datas datas, string nome, CategoriaDespesa categoria)
        {
            double valor = (double)Despesa.ValorPorCategoria(despesas, datas, categoria);
            if (valor > 0)
                dados[nome] = valor;
        }

        private void InicializarDataPickers()
        {
            DateTime primeiroDiaMesCorrente = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime ultimoDiaMesCorrente = primeiroDiaMesCorrente.AddMonths(1).AddDays(-1);

            dateTimePickerInicial.Value = primeiroDiaMesCorrente;
            dateTimePickerFinal.Value = ultimoDiaMesCorrente;
        }

        private async Task InicializarTotalDespesas()
        {
            var despesas = await Despesa.ObterTodas();
            decimal totalDespesas = despesas.Sum(d => d.Valor);
            lblTotalDespesas.Text = totalDespesas.ToString("C");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            InicializarGraficos();
        }
    }
}