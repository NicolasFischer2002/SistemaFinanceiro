namespace SistemaFinanceiro.Entidades
{
    internal class Despesa : Transacao
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

        public override Task Atualizar()
        {
            throw new NotImplementedException();
        }

        public override Task Cadastrar()
        {
            throw new NotImplementedException();
        }

        public override Task Deletar()
        {
            throw new NotImplementedException();
        }

        public override Task ObterPorId()
        {
            throw new NotImplementedException();
        }
    }
}