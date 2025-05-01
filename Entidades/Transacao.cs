using SistemaFinanceiro.Helpers;

namespace SistemaFinanceiro.Entidades
{
    internal abstract class Transacao
    {
        public Guid Id { get; private set; }
        public StatusTransacao StatusTransacao { get; private set; }
        public decimal Valor { get; private set; }
        public IReadOnlyList<Parcela> Parcelas { get; private set; }
        public string? Descricao { get; private set; }

        public Transacao(StatusTransacao statusTransacao, decimal valor, int quantidadeParcelas, string? descricao)
        {
            ValidarValor(valor);
            ValidarDescricao(descricao);

            Id = new Guid();
            StatusTransacao = statusTransacao;
            Valor = valor;
            Parcelas = ParcelaGenerator.Gerar(valor, quantidadeParcelas);
            Descricao = descricao;
        }

        protected virtual void ValidarValor(decimal valor)
        {
            const int valorMinimo = 0;

            if (Valor <= valorMinimo)
                throw new ArgumentException($"O valor da transação deve ser superior a {valorMinimo}.");
        }

        protected virtual void ValidarDescricao(string? descricao)
        {
            const int tamanhoMaximoDescricao = 100;

            if (!string.IsNullOrWhiteSpace(descricao))
                if (descricao.Length > tamanhoMaximoDescricao)
                    throw new ArgumentException($"O tamanho máximo para uma descrição é de {tamanhoMaximoDescricao}.");
        }
    }
}