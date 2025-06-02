using SistemaFinanceiro.Contratos;
using SistemaFinanceiro.DTOs;
using System.Text.Json;

namespace SistemaFinanceiro.Entidades
{
    public class Receita : Transacao, IRepositorio, IRepositorioReceitas
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

        public static async ValueTask<Receita?> ObterPorIdAsync(Guid id)
        {
            var receitas = await ObterTodas();
            return receitas.Where(r => r.Id == id).FirstOrDefault();
        }

        public static async ValueTask<List<Receita>> ObterTodas(Datas? intervalo = null)
        {
            if (!File.Exists(CaminhoArquivoReceitas))
                return new List<Receita>();

            var receitas = new List<Receita>();

            foreach (var linha in await File.ReadAllLinesAsync(CaminhoArquivoReceitas))
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                var dto = JsonSerializer.Deserialize<ReceitaDTO>(linha)!;
                var receita = ReceitaMapper.ToDomain(dto);

                // Se intervalo foi passado, aplica o filtro
                if (intervalo == null ||
                    (receita.DataRecebimento >= intervalo.DataInicial && receita.DataRecebimento <= intervalo.DataFinal))
                {
                    receitas.Add(receita);
                }
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

        public async Task DeletarAsync()
        {
            List<Receita> receitas = await ObterTodas();
            receitas.Remove(receitas.Where(d => d.Id == Id).Single());

            File.WriteAllText(CaminhoArquivoReceitas, string.Empty);
            await SalvarTodasAsync(receitas);
        }

        private static async Task SalvarTodasAsync(List<Receita> receitas)
        {
            var linhas = receitas.Select(r =>
                JsonSerializer.Serialize(ReceitaMapper.ToDto(r), new JsonSerializerOptions { WriteIndented = false })
            );

            await File.WriteAllLinesAsync(CaminhoArquivoReceitas, linhas);
        }

        public async Task AtualizarAsync(Receita novaReceita)
        {
            await DeletarAsync();
            await novaReceita.CadastrarAsync();
        }

        public static decimal ValorPorCategoria(List<Receita> receitas, Datas datas, CategoriaReceita categoria)
        {
            return receitas
                .Where(r =>
                    r.CategoriaReceita == categoria
                    && r.DataRecebimento >= datas.DataInicial
                    && r.DataRecebimento <= datas.DataFinal)
                .Sum(r => r.Valor);
        }
    }
}