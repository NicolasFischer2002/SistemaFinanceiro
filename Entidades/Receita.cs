using SistemaFinanceiro.Contratos;

namespace SistemaFinanceiro.Entidades
{
    internal class Receita : Transacao, IRepositorioReceitas
    {
        public CategoriaReceita CategoriaReceita { get; init; }
        public DateTime DataRecebimento { get; init; }
        public TipoPagamento TipoPagamento { get; init; }
        private const string CaminhoArquivoReceitas = "Arquivos/Receitas.txt";

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
            throw new NotImplementedException();
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

        public async ValueTask<List<Receita>> ObterTodas()
        {
            throw new NotImplementedException();
        }
    }
}