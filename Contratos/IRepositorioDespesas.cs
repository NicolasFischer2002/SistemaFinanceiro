using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.Contratos
{
    internal interface IRepositorioDespesas
    {
        Task CadastrarAsync();
        Task AtualizarAsync();
        Task DeletarAsync();
    }
}