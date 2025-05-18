using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.DTOs
{
    internal static class DespesaMapper
    {
        public static DespesaDTO ToDto(Despesa despesa) => new()
        {
            Id = despesa.Id,
            StatusTransacao = despesa.StatusTransacao.ToString(),
            Valor = despesa.Valor,
            QuantidadeParcelas = despesa.Parcelas.Count,
            Descricao = despesa.Descricao,
            CategoriaDespesa = despesa.CategoriaDespesa.ToString(),
            DataVencimento = despesa.DataVencimento,
            DataPagamento = despesa.DataPagamento,
            TipoPagamento = despesa.TipoPagamento.ToString()
        };

        public static Despesa ToDomain(DespesaDTO dto) =>
            new Despesa(
                Enum.Parse<StatusTransacao>(dto.StatusTransacao),
                dto.Valor,
                dto.QuantidadeParcelas,
                dto.Descricao,
                Enum.Parse<CategoriaDespesa>(dto.CategoriaDespesa),
                dto.DataVencimento,
                dto.DataPagamento,
                Enum.Parse<TipoPagamento>(dto.TipoPagamento)
            )
            {
                Id = dto.Id
            };
    }
}