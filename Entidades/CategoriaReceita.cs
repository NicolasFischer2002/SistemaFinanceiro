using System.ComponentModel;

namespace SistemaFinanceiro.Entidades
{
    public enum CategoriaReceita
    {
        [Description("Salário")]
        Salario = 0,

        [Description("Bonificação")]
        Bonificacao,

        [Description("Venda de Bens")]
        VendaDeBens,

        [Description("Juros e Dividendos")]
        JurosDividendos,

        [Description("Aluguel")]
        Aluguel,

        [Description("Comissões")]
        Comissoes,

        [Description("Prestação de Serviços")]
        PrestacaoServicos,

        [Description("Royalties")]
        Royalties,

        [Description("Reembolso")]
        Reembolso,

        [Description("Outras Receitas")]
        Outros
    }
}