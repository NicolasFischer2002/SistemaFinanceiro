namespace SistemaFinanceiro.Apresentacao.Helpers
{
    internal class LabelService
    {
        public static void InicializarTitulo(Label label)
        {
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        }

        public static void InicializarTexto(Label label)
        {
            label.Font = new Font("Segoe UI", 18F, FontStyle.Regular);
        }
    }
}