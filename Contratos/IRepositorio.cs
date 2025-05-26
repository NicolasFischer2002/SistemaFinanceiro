namespace SistemaFinanceiro.Contratos
{
    internal interface IRepositorio
    {
        Task CadastrarAsync();
        Task DeletarAsync();
    }
}