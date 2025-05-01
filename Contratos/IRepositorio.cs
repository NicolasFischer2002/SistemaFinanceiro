namespace SistemaFinanceiro.Contratos
{
    internal interface IRepositorio
    {
        Task CadastrarAsync();
        Task ObterPorIdAsync(Guid id);
        Task AtualizarAsync();
        Task DeletarAsync(Guid id);
    }
}