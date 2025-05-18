namespace SistemaFinanceiro.DTOs
{
    internal class DespesaDTO
    {
        public Guid Id { get; set; }
        public string StatusTransacao { get; set; } = null!;
        public decimal Valor { get; set; }
        public int QuantidadeParcelas { get; set; }
        public string? Descricao { get; set; }
        public string CategoriaDespesa { get; set; } = null!;
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string TipoPagamento { get; set; } = null!;
    }
}