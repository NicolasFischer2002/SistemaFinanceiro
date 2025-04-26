using System.ComponentModel;

namespace SistemaFinanceiro.Entidades
{
    internal enum StatusTransacao
    {
        [Description("Quitado")]
        Quitado = 0,

        [Description("Em atraso")]
        EmAtraso,

        [Description("Processamento em andamento")]
        EmProcessamento,

        [Description("Valor estornado")]
        Estornado,

        [Description("Pagamento agendado para data futura")]
        Agendado,
    }
}