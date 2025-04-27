namespace SistemaFinanceiro.Entidades
{
    internal class Receita : Transacao
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