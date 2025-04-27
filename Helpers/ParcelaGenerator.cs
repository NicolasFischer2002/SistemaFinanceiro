using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.Helpers
{
    internal class ParcelaGenerator
    {
        private const int QuantidadeMinimaParcelas = 1;
        private const int QuantidadeMaximaParcelas = 120;
        private const decimal ValorMinimo = 0.01m;

        public static IReadOnlyList<Parcela> Gerar(decimal valorTotal, int quantidadeParcelas)
        {
            ValidarEntradas(valorTotal, quantidadeParcelas);

            var valorPorParcela = decimal.Round(valorTotal / quantidadeParcelas, 2);

            return Enumerable
                .Range(1, quantidadeParcelas)
                .Select(i => new Parcela(i, valorPorParcela))
                .ToList();
        }

        private static void ValidarEntradas(decimal valorTotal, int quantidadeParcelas)
        {
            if (valorTotal < ValorMinimo)
                throw new ArgumentException($"Valor total deve ser maior que {ValorMinimo}.", nameof(valorTotal));

            if (quantidadeParcelas < QuantidadeMinimaParcelas || quantidadeParcelas > QuantidadeMaximaParcelas)
                throw new ArgumentOutOfRangeException(nameof(quantidadeParcelas),
                    $"Quantidade de parcelas deve estar entre {QuantidadeMinimaParcelas} e {QuantidadeMaximaParcelas}.");
        }
    }
}