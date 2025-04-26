using System.ComponentModel;

namespace SistemaFinanceiro.Entidades
{
    internal enum TipoPagamento
    {
        [Description("Pagamento via PIX")]
        PIX = 0,

        [Description("Depósito bancário")]
        Deposito,

        [Description("Cartão de crédito")]
        Credito,

        [Description("Cartão de débito")]
        Debito
    }
}