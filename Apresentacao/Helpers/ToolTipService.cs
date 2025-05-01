namespace SistemaFinanceiro.Apresentacao.Helpers
{
    internal static class ToolTipService
    {
        private static readonly ToolTip _toolTip = new ToolTip
        {
            AutoPopDelay = 5000, // tempo que fica visível (ms)
            InitialDelay = 500,  // atraso antes de aparecer (ms)
            ReshowDelay = 200,   // atraso pra reaparecer (ms)
            ShowAlways = true    // mostra mesmo que o form não tenha foco
        };

        /// <summary>
        /// Associa um texto de dica a qualquer Control.
        /// </summary>
        public static void Set(Control control, string text)
        {
            _toolTip.SetToolTip(control, text);
        }
    }
}