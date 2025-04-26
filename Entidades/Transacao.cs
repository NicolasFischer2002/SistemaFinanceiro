namespace SistemaFinanceiro.Entidades
{
    internal abstract class Transacao
    {
        public int Id { get; private set; }
        public StatusTransacao StatusTransacao { get; private set; }
        public decimal Valor { get; private set; }
        public string? Descricao { get; private set; }

        public Transacao(int id, StatusTransacao statusTransacao, decimal valor, string? descricao)
        {
            Id = id;
            StatusTransacao = statusTransacao;
            Valor = valor;
            Descricao = descricao;
        }

        public abstract Task Cadastrar();
        public abstract Task ObterPorId();
        public abstract Task Atualizar();
        public abstract Task Deletar();
    }
}