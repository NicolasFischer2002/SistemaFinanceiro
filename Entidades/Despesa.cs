
namespace SistemaFinanceiro.Entidades
{
    internal class Despesa : Transacao
    {
        public CategoriaDespesa CategoriaDespesa { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public DateTime? DataPagamento { get; private set; }
        public int IdTipoPagamento { get; private set; }

        public Despesa(int id, StatusTransacao statusTransacao, decimal valor, string? descricao,
            CategoriaDespesa categoriaDespesa, DateTime dataVencimento,
            DateTime? dataPagamento, int idTipoPagamento)
            : base(id, statusTransacao, valor, descricao)
        {
            CategoriaDespesa = categoriaDespesa;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
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