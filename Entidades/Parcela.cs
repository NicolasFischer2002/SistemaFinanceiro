namespace SistemaFinanceiro.Entidades
{
    internal class Parcela
    {
        public int Numero { get; private set; }
        public decimal Valor { get; private set; }

        public Parcela(int numero, decimal valor)
        {
            ValidarQuantidadeParcelas(numero);
            ValidarValorParcela(valor);

            Numero = numero;
            Valor = valor;
        }

        private void ValidarQuantidadeParcelas(int quantidadeParcelas)
        {
            const int quantidadeMinima = 1;

            if (quantidadeParcelas < quantidadeMinima)
                throw new ArgumentOutOfRangeException(nameof(quantidadeParcelas),
                    $"Número da parcela deve ser maior ou igual a {quantidadeMinima}.");
        }

        private void ValidarValorParcela(decimal valor)
        {
            const int valorMinimo = 0;

            if (valor <= valorMinimo)
                throw new ArgumentOutOfRangeException(nameof(valor),
                    $"Valor da parcela deve ser maior que {valorMinimo}.");
        }
    }
}