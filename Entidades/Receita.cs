namespace SistemaFinanceiro.Entidades
{
    internal class Receita : Transacao
    {
        public CategoriaReceita CategoriaReceita { get; private set; }
        public DateTime DataRecebimento { get; private set; }
        public int IdTipoPagamento { get; private set; }

        public Receita(int id, StatusTransacao statusTransacao, decimal valor, string? descricao,
            CategoriaReceita categoriaReceita, DateTime dataRecebimento, int idTipoPagamento)
            : base(id, statusTransacao, valor, descricao)
        {
            CategoriaReceita = categoriaReceita;
            DataRecebimento = dataRecebimento;
            IdTipoPagamento = idTipoPagamento;
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