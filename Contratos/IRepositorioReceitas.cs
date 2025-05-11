using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.Contratos
{
    internal interface IRepositorioReceitas
    {
        Task CadastrarAsync();
        Task ObterPorIdAsync(Guid id);
        ValueTask<List<Receita>> ObterTodas();
        Task AtualizarAsync();
        Task DeletarAsync(Guid id);
    }
}