using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.Contratos
{
    internal interface IRepositorioDespesas
    {
        Task AtualizarAsync(Despesa novaDespesa);
    }
}