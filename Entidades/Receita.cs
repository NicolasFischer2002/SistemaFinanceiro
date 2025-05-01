using SistemaFinanceiro.Contratos;

namespace SistemaFinanceiro.Entidades
{
    internal class Receita : Transacao, IRepositorio
    {
        public CategoriaReceita CategoriaReceita { get; private set; }
        public DateTime DataRecebimento { get; private set; }
        public TipoPagamento TipoPagamento { get; private set; }

        public Receita(StatusTransacao statusTransacao, decimal valor, string? descricao, int quantidadeParcelas,
            CategoriaReceita categoriaReceita, DateTime dataRecebimento, TipoPagamento tipoPagamento)
            : base(statusTransacao, valor, quantidadeParcelas, descricao)
        {
            CategoriaReceita = categoriaReceita;
            DataRecebimento = dataRecebimento;
            TipoPagamento = tipoPagamento;
        }

        public Task CadastrarAsync()
        {
            throw new NotImplementedException();
        }

        public Task ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}