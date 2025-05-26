using SistemaFinanceiro.Entidades;

namespace Testes
{
    [TestClass]
    public sealed class DespesaTests
    {
        [DataTestMethod]
        [DataRow(1.0)]
        [DataRow(100.0)]
        [DataRow(50.0)]
        [DataRow(256.0)]
        [DataRow(10000.0)]
        public void ApenasValoresValidosNaoDeveLancarExcecao(double valor)
        {
            decimal valorValido = Convert.ToDecimal(valor);

            StatusTransacao status = StatusTransacao.Quitado;
            int qtdParcelas = 1;
            string descricao = "Teste";
            CategoriaDespesa categoria = CategoriaDespesa.Alimentacao;
            DateTime vencimento = DateTime.Now;
            DateTime? pagamento = null;
            TipoPagamento tipo = TipoPagamento.PIX;

            var despesa = new Despesa(status, valorValido, qtdParcelas, descricao, categoria, vencimento, pagamento, tipo);

            Assert.IsNotNull(despesa);
            Assert.AreEqual(valorValido, despesa.Valor);
        }

        [DataTestMethod]
        [DataRow(0.0)]
        [DataRow(-1.0)]
        [DataRow(-100.0)]
        public void ApenasValoresInvalidosDeveLancarExcecao(double valor)
        {
            decimal valorInvalido = Convert.ToDecimal(valor);

            StatusTransacao status = StatusTransacao.Quitado;
            int qtdParcelas = 1;
            string descricao = "Teste inválido";
            CategoriaDespesa categoria = CategoriaDespesa.Moradia;
            DateTime vencimento = DateTime.Today;
            DateTime? pagamento = null;
            TipoPagamento tipo = TipoPagamento.Credito;

            Assert.ThrowsException<ArgumentException>(() =>
                new Despesa(status, valorInvalido, qtdParcelas, descricao, categoria, vencimento, pagamento, tipo));
        }

        [TestMethod]
        public void DescricaoValidaNaoDeveLancarExcecao()
        {
            var descricaoValida = "Essa é uma descrição válida com menos de 100 caracteres.";

            var despesa = new Despesa(
                StatusTransacao.Quitado,
                150m,
                1,
                descricaoValida,
                CategoriaDespesa.Educacao,
                DateTime.Today,
                null,
                TipoPagamento.Credito
            );

            Assert.IsNotNull(despesa);
            Assert.AreEqual(descricaoValida, despesa.Descricao);
        }

        [TestMethod]
        public void DescricaoMuitoGrandeDeveLancarExcecao()
        {
            var descricaoInvalida = new string('x', 101);

            Assert.ThrowsException<ArgumentException>(() =>
                new Despesa(
                    StatusTransacao.Quitado,
                    150m,
                    1,
                    descricaoInvalida,
                    CategoriaDespesa.Educacao,
                    DateTime.Today,
                    null,
                    TipoPagamento.Credito
                ));
        }
    }
}