using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.Contratos
{
    internal interface IRepositorioReceitas
    {
        Task AtualizarAsync(Receita novaReceita);
    }
}