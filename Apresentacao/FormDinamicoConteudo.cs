namespace SistemaFinanceiro.Apresentacao
{
    internal class FormDinamicoConteudo
    {
        public static void InicializarGUI(Form form)
        {
            // Remove os botões de minimizar, maximizar e fechar
            form.ControlBox = false;
            
            // Remove título do form
            form.Text = "";

            // Remove as bordas do form
            form.FormBorderStyle = FormBorderStyle.None;
        }
    }
}