using SistemaFinanceiro.Contratos;

namespace SistemaFinanceiro.Entidades
{
    internal class Despesa : Transacao, IRepositorio
    {
        public CategoriaDespesa CategoriaDespesa { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public DateTime? DataPagamento { get; private set; }
        public TipoPagamento TipoPagamento { get; private set; }

        public Despesa(StatusTransacao statusTransacao, decimal valor, int quantidadeParcelas, string? descricao,
            CategoriaDespesa categoriaDespesa, DateTime dataVencimento,
            DateTime? dataPagamento, TipoPagamento tipoPagamento)
            : base(statusTransacao, valor, quantidadeParcelas, descricao)
        {
            CategoriaDespesa = categoriaDespesa;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
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