using SistemaFinanceiro.Helpers;

namespace SistemaFinanceiro.Entidades
{
    internal abstract class Transacao
    {
        public Guid Id { get; init; }
        public StatusTransacao StatusTransacao { get; init; }
        public decimal Valor { get; init; }
        public IReadOnlyList<Parcela> Parcelas { get; init; }
        public string? Descricao { get; init; }

        public Transacao(StatusTransacao statusTransacao, decimal valor, int quantidadeParcelas, string? descricao)
        {
            ValidarValor(valor);
            ValidarDescricao(descricao);

            Id = Guid.NewGuid();
            StatusTransacao = statusTransacao;
            Valor = valor;
            Parcelas = ParcelaGenerator.Gerar(valor, quantidadeParcelas);
            Descricao = descricao;
        }

        protected virtual void ValidarValor(decimal valor)
        {
            const int valorMinimo = 0;

            if (valor <= valorMinimo)
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