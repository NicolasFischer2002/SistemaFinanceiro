using SistemaFinanceiro.Apresentacao;

namespace SistemaFinanceiro
{
    public partial class FormDespesas : Form
    {
        public FormDespesas()
        {
            InitializeComponent();
            FormDinamicoConteudo.InicializarGUI(this);
        }
    }
}
