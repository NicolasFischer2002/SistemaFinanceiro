using SistemaFinanceiro.Contratos;
using SistemaFinanceiro.DTOs;
using System.Text.Json;

namespace SistemaFinanceiro.Entidades
{
    public class Despesa : Transacao, IRepositorio, IRepositorioDespesas
    {
        public CategoriaDespesa CategoriaDespesa { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public DateTime? DataPagamento { get; private set; }
        public TipoPagamento TipoPagamento { get; private set; }
        private const string CaminhoArquivoDespesas = "Arquivos/Despesas.json";

        public Despesa(StatusTransacao statusTransacao, decimal valor, int quantidadeParcelas, string? descricao,
            CategoriaDespesa categoriaDespesa, DateTime dataVencimento,
            DateTime? dataPagamento, TipoPagamento tipoPagamento)
            : base(statusTransacao, valor, quantidadeParcelas, descricao)
        {
            CategoriaDespesa = categoriaDespesa;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            TipoPagamento = tipoPagamento;
        }

        public async Task CadastrarAsync()
        {
            var dto = DespesaMapper.ToDto(this);
            var linhaJson = JsonSerializer.Serialize(dto, new JsonSerializerOptions { WriteIndented = false });
            await File.AppendAllTextAsync(CaminhoArquivoDespesas, linhaJson + Environment.NewLine);
        }

        public static async ValueTask<Despesa?> ObterPorIdAsync(Guid id)
        {
            var despesas = await ObterTodas();
            return despesas.Where(d => d.Id == id).FirstOrDefault();
        }

        public async Task AtualizarAsync(Despesa novaDespesa)
        {
            await DeletarAsync();
            await novaDespesa.CadastrarAsync();
        }

        public async Task DeletarAsync()
        {
            List<Despesa> despesas = await ObterTodas();
            despesas.Remove(despesas.Where(d => d.Id == Id).Single());

            File.WriteAllText(CaminhoArquivoDespesas, string.Empty);
            await SalvarTodasAsync(despesas);
        }

        private static async Task SalvarTodasAsync(List<Despesa> despesas)
        {
            var linhas = despesas.Select(d =>
                JsonSerializer.Serialize(DespesaMapper.ToDto(d), new JsonSerializerOptions { WriteIndented = false })
            );

            await File.WriteAllLinesAsync(CaminhoArquivoDespesas, linhas);
        }

        public static async ValueTask<List<Despesa>> ObterTodas(Datas? intervalo = null)
        {
            if (!File.Exists(CaminhoArquivoDespesas))
                return new List<Despesa>();

            var despesas = new List<Despesa>();

            foreach (var linha in await File.ReadAllLinesAsync(CaminhoArquivoDespesas))
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                var dto = JsonSerializer.Deserialize<DespesaDTO>(linha)!;
                var despesa = DespesaMapper.ToDomain(dto);

                // Se intervalo foi passado, aplica o filtro
                if (intervalo == null ||
                    (despesa.DataVencimento >= intervalo.DataInicial && despesa.DataVencimento <= intervalo.DataFinal))
                {
                    despesas.Add(despesa);
                }
            }

            return despesas;
        }

        public static decimal ValorPorCategoria(List<Despesa> despesas, Datas datas, CategoriaDespesa categoria)
        {
            return despesas
                .Where(d =>
                    d.CategoriaDespesa == categoria
                    && d.DataVencimento >= datas.DataInicial
                    && d.DataVencimento <= datas.DataFinal)
                .Sum(d => d.Valor);
        }
    }
}