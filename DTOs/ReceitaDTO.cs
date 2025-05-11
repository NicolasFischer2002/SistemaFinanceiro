namespace SistemaFinanceiro.DTOs
{
    internal class ReceitaDTO
    {
        public Guid Id { get; set; }
        public string StatusTransacao { get; set; } = null!;
        public decimal Valor { get; set; }
        public int QuantidadeParcelas { get; set; }
        public string? Descricao { get; set; }
        public string CategoriaReceita { get; set; } = null!;
        public DateTime DataRecebimento { get; set; }
        public string TipoPagamento { get; set; } = null!;
    }
}