using SistemaFinanceiro.Contratos;
using SistemaFinanceiro.DTOs;
using System.Text.Json;

namespace SistemaFinanceiro.Entidades
{
    internal class Receita : Transacao, IRepositorioReceitas
    {
        public CategoriaReceita CategoriaReceita { get; init; }
        public DateTime DataRecebimento { get; init; }
        public TipoPagamento TipoPagamento { get; init; }
        private const string CaminhoArquivoReceitas = "Arquivos/Receitas.json";

        public Receita(StatusTransacao statusTransacao, decimal valor, string? descricao, int quantidadeParcelas,
            CategoriaReceita categoriaReceita, DateTime dataRecebimento, TipoPagamento tipoPagamento)
            : base(statusTransacao, valor, quantidadeParcelas, descricao)
        {
            CategoriaReceita = categoriaReceita;
            DataRecebimento = dataRecebimento;
            TipoPagamento = tipoPagamento;
        }

        public async Task CadastrarAsync()
        {
            var dto = ReceitaMapper.ToDto(this);
            var linhaJson = JsonSerializer.Serialize(dto, new JsonSerializerOptions { WriteIndented = false });
            await File.AppendAllTextAsync(CaminhoArquivoReceitas, linhaJson + Environment.NewLine);
        }

        public Task ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public static async ValueTask<List<Receita>> ObterTodas()
        {
            if (!File.Exists(CaminhoArquivoReceitas))
                return new List<Receita>();

            var receitas = new List<Receita>();
            
            foreach (var linha in await File.ReadAllLinesAsync(CaminhoArquivoReceitas))
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;
                var dto = JsonSerializer.Deserialize<ReceitaDTO>(linha)!;
                receitas.Add(ReceitaMapper.ToDomain(dto));
            }

            return receitas;
        }

        public static decimal ValorSalarios(List<Receita> receitas, Datas datas)
        {
            return receitas
                .Where(r => r.CategoriaReceita == CategoriaReceita.Salario
                    && r.DataRecebimento >= datas.DataInicial
                    && r.DataRecebimento <= datas.DataFinal)
                .Sum(r => r.Valor);
        }


    }
}