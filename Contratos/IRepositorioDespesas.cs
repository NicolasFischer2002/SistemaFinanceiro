using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.Contratos
{
    internal interface IRepositorioDespesas
    {
        Task CadastrarAsync();
        Task ObterPorIdAsync(Guid id);
        Task AtualizarAsync();
        Task DeletarAsync(Guid id);
    }
}