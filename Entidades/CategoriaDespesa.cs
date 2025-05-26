using System.ComponentModel;

namespace SistemaFinanceiro.Entidades
{
    public enum CategoriaDespesa
    {
        [Description("Alimentação")]
        Alimentacao = 0,

        [Description("Transporte")]
        Transporte,

        [Description("Moradia")]
        Moradia,

        [Description("Saúde")]
        Saude,

        [Description("Educação")]
        Educacao,

        [Description("Lazer e Entretenimento")]
        Lazer,

        [Description("Viagens")]
        Viagem,

        [Description("Vestuário")]
        Vestuario,

        [Description("Assinaturas e Streaming")]
        Assinaturas,

        [Description("Contas e Serviços (água, luz, internet)")]
        ContasServicos,

        [Description("Impostos e Taxas")]
        Impostos,

        [Description("Manutenção e Reparos")]
        Manutencao,

        [Description("Presentes e Doações")]
        Presentes,

        [Description("Outras Despesas")]
        Outros
    }
}