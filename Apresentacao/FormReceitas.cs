using SistemaFinanceiro.Apresentacao;

namespace SistemaFinanceiro
{
    public partial class FormReceitas : Form
    {
        public FormReceitas()
        {
            InitializeComponent();
            FormDinamicoConteudo.InicializarGUI(this);
        }
    }
}
