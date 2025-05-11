using SistemaFinanceiro.Entidades;

namespace SistemaFinanceiro.DTOs
{
    internal class ReceitaMapper
    {
        public static ReceitaDTO ToDto(Receita receita) => new()
        {
            Id = receita.Id,
            StatusTransacao = receita.StatusTransacao.ToString(),
            Valor = receita.Valor,
            QuantidadeParcelas = receita.Parcelas.Count,
            Descricao = receita.Descricao,
            CategoriaReceita = receita.CategoriaReceita.ToString(),
            DataRecebimento = receita.DataRecebimento,
            TipoPagamento = receita.TipoPagamento.ToString()
        };

        public static Receita ToDomain(ReceitaDTO dto) =>
            new Receita(
                Enum.Parse<StatusTransacao>(dto.StatusTransacao),
                dto.Valor,
                dto.Descricao,
                dto.QuantidadeParcelas,
                Enum.Parse<CategoriaReceita>(dto.CategoriaReceita),
                dto.DataRecebimento,
                Enum.Parse<TipoPagamento>(dto.TipoPagamento)
            )
            {
                Id = dto.Id
            };
    }
}