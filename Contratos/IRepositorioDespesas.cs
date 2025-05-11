using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.Contratos
{
    internal interface IRepositorioDespesas
    {
        Task CadastrarAsync();
        Task ObterPorIdAsync(Guid id);
        ValueTask<List<Despesa>> ObterTodas();
        Task AtualizarAsync();
        Task DeletarAsync(Guid id);
    }
}