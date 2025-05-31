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
            InicializarTotalReceitas();
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
            InicializarGraficoReceita();
            InicializarGraficoDespesas();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            InicializarGraficos();
        }

        private async void InicializarGraficoReceita()
        {
            var receitas = await Receita.ObterTodas(); 
            Datas datas = new Datas();

            var dados = new Dictionary<string, double>();

            AdicionarReceitaSePositivo(dados, receitas, datas, "Salário", CategoriaReceita.Salario);
            AdicionarReceitaSePositivo(dados, receitas, datas, "Bonificação", CategoriaReceita.Bonificacao);
            AdicionarReceitaSePositivo(dados, receitas, datas, "Prestação Servicos", CategoriaReceita.PrestacaoServicos);
            AdicionarReceitaSePositivo(dados, receitas, datas, "Comissões", CategoriaReceita.Comissoes);
            AdicionarReceitaSePositivo(dados, receitas, datas, "Reembolso", CategoriaReceita.Reembolso);            
          
            GraficoPizzaService.InicializarExistente(graficoReceita, dados);
        }

        private async void InicializarGraficoDespesas()
        {
            var despesas = await Despesa.ObterTodas(new Datas(dateTimePickerInicial.Value, dateTimePickerFinal.Value));
            Datas datas = new Datas();

            var dados = new Dictionary<string, double>();

            AdicionarDespesaSePositivo(dados, despesas, datas, "Alimentação", CategoriaDespesa.Alimentacao);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Transporte", CategoriaDespesa.Transporte);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Moradia", CategoriaDespesa.Moradia);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Saúde", CategoriaDespesa.Saude);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Educação", CategoriaDespesa.Educacao);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Lazer e Entretenimento", CategoriaDespesa.Lazer);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Viagens", CategoriaDespesa.Viagem);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Vestuário", CategoriaDespesa.Vestuario);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Assinaturas e Streaming", CategoriaDespesa.Assinaturas);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Contas e Serviços (água, luz, internet)", CategoriaDespesa.ContasServicos);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Impostos e Taxas", CategoriaDespesa.Impostos);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Manutenção e Reparos", CategoriaDespesa.Manutencao);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Presentes e Doações", CategoriaDespesa.Presentes);
            AdicionarDespesaSePositivo(dados, despesas, datas, "Outras Despesas", CategoriaDespesa.Outros);

            GraficoPizzaService.InicializarExistente(graficoDespesas, dados);
        }

        private void AdicionarDespesaSePositivo(Dictionary<string, double> dados, List<Despesa> despesas,
            Datas datas, string nome, CategoriaDespesa categoria)
        {
            double valor = (double)Despesa.ValorPorCategoria(despesas, datas, categoria);
            if (valor > 0)
                dados[nome] = valor;
        }

        private void AdicionarReceitaSePositivo(Dictionary<string, double> dados, List<Receita> receitas,
            Datas datas, string nome, CategoriaReceita categoria)
        {
            double valor = (double)Receita.ValorPorCategoria(receitas, datas, categoria);
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

        private async Task InicializarTotalReceitas()
        {
            var receitas = await Receita.ObterTodas();
            decimal totalReceitas = receitas.Sum(d => d.Valor);
            lblTotalReceitas.Text = totalReceitas.ToString("C"); 
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            InicializarGraficos();
        }
    
    }
}