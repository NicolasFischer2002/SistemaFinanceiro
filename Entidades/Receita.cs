using System.Text.Json;
using System.IO;
using SistemaFinanceiro.Contratos;
using System.Threading.Tasks;


namespace SistemaFinanceiro.Entidades
{
    internal class Receita : Transacao, IRepositorio
    {
        public CategoriaReceita CategoriaReceita { get; private set; }
        public DateTime DataRecebimento { get; private set; }
        public TipoPagamento TipoPagamento { get; private set; }

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
            string CaminhoExe = AppDomain.CurrentDomain.BaseDirectory;
            string CaminhoArquivoReceitasJSON = Path.Combine(CaminhoExe, "receitas.json");

            throw new NotImplementedException();

            List<Receita> lista;

            // Ler e desserializar
            if (File.Exists(CaminhoArquivoReceitasJSON))
            {
                var ArquivoJSON = await File.ReadAllTextAsync(CaminhoArquivoReceitasJSON);
                lista = JsonSerializer.Deserialize<List<Receita>>(ArquivoJSON)
                    ?? new List<Receita>();
            }
            else
            {
                lista = new List<Receita>();
            }

            // Adicionando nova receita
            lista.Add(this);

            // Serializa com identação e salva
            var opcoes = new JsonSerializerOptions { WriteIndented = true };
            var ArquivoJSONAtualizado = JsonSerializer.Serialize(lista, opcoes);

            await File.WriteAllTextAsync(CaminhoArquivoReceitasJSON, ArquivoJSONAtualizado);
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
    }
}