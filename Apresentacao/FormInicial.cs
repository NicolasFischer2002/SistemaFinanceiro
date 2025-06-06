using SistemaFinanceiro.Apresentacao;
using SistemaFinanceiro.Apresentacao.Helpers;

namespace SistemaFinanceiro
{
    public partial class FormInicial : Form
    {
        private Button[] BotoesMenuLateral;
        private string[] CaminhosIconesBotoes;
        private Form? FormularioAtivo = null;

        public FormInicial()
        {
            InitializeComponent();

            BotoesMenuLateral = [
                BtnDashboard,
                BtnCadastrarDespesas,
                BtnReceitas,
                BtnConsultarDespesas,
                BtnConsultarReceitas
            ];

            CaminhosIconesBotoes = [
                "Apresentacao/Imagens/icone_dashboard.png",
                "Apresentacao/Imagens/icone_despesas.png",
                "Apresentacao/Imagens/icone_receitas.png",
                "Apresentacao/Imagens/icone_consultar_receitas.png",
                "Apresentacao/Imagens/icone_consultar_receitas.png"
            ];

            InicializarGUIFormInicial();
            InicializarGUIMenuLateral();
            InicializarRodape();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            // Simula o clique no bot�o Dashboard assim que o form abrir
            BtnDashboard.PerformClick();
        }

        private void InicializarGUIFormInicial()
        {
            PnlMenuLateral.Padding = new Padding(20, 0, 20, 0);

            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;

            MinimumSize = new Size(1500, 800);

            Text = "Sistema Financeiro";
        }

        private void InicializarGUIMenuLateral()
        {
            PnlMenuLateral.BackColor = ColorTranslator.FromHtml("#212429");

            InicializarSessaoLogo();

            InicializarLinhaSeparacao(PnlLinhaLogo);
            InicializarLinhaSeparacao(PnlLinhaRodape);

            InicializarBtnMenuLateral();
        }

        private void InicializarSessaoLogo()
        {
            InicializarLabelNomeSistema();
            InicializarLogo();
        }

        private void InicializarLabelNomeSistema()
        {
            LblTitulo.Text = "Sistema Financeiro";
            LblTitulo.AutoSize = true;

            LblTitulo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            LblTitulo.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void InicializarLogo()
        {
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.Image = Image.FromFile("Apresentacao/Imagens/icone_logo.png");
        }

        private void InicializarLinhaSeparacao(Panel panel)
        {
            panel.BackColor = ColorTranslator.FromHtml("#45494E");
        }

        private void InicializarBtnMenuLateral()
        {
            // Certifique-se de que o tamanho dos dois arrays bate
            if (BotoesMenuLateral.Length != CaminhosIconesBotoes.Length)
                throw new InvalidOperationException("Bot�es e caminhos de �cone devem ter o mesmo tamanho.");

            for (int i = 0; i < BotoesMenuLateral.Length; i++)
            {
                var button = BotoesMenuLateral[i];
                var relPath = CaminhosIconesBotoes[i];

                // Estilo padr�o
                button.Parent = PnlMenuLateral;
                button.UseVisualStyleBackColor = false;
                button.BackColor = Color.Transparent;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                button.ForeColor = Color.White;
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.Padding = new Padding(36, 0, 0, 0); // espa�o para o �cone
                button.Cursor = Cursors.Hand;

                // Carregando o �cone
                var fullPath = Path.Combine(Application.StartupPath, relPath);

                button.Image = Image.FromFile(fullPath);
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void AbrirFormularioNoPanel(Form formulario)
        {
            // Se j� existe um formul�rio aberto, fecha
            if (FormularioAtivo != null)
                FormularioAtivo.Close();

            FormularioAtivo = formulario;

            // Configura o formul�rio para se comportar como "controle" dentro do painel
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Adiciona no Panel e exibe
            PnlTelaDinamica.Controls.Clear();
            PnlTelaDinamica.Controls.Add(formulario);
            formulario.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            DestacarBotao(BtnDashboard);
            AbrirFormularioNoPanel(new FormDashboard());
        }

        private void BtnDespesas_Click(object sender, EventArgs e)
        {
            DestacarBotao(BtnCadastrarDespesas);
            AbrirFormularioNoPanel(new FormCadastrarDespesas());
        }

        private void BtnReceitas_Click(object sender, EventArgs e)
        {
            DestacarBotao(BtnReceitas);
            AbrirFormularioNoPanel(new FormReceitas());
        }

        private void DestacarBotao(Button botaoClicado)
        {
            // Cor de fundo que voc� quer para o selecionado
            var corDestaque = ColorTranslator.FromHtml("#0D6EFD");

            foreach (var btn in BotoesMenuLateral)
            {
                // Define o BackColor normal
                var isSelecionado = btn == botaoClicado;

                btn.BackColor = isSelecionado
                    ? corDestaque
                    : Color.Transparent;

                // Redefine tamb�m as cores de hover / mouse-down
                btn.FlatAppearance.MouseOverBackColor = isSelecionado
                    ? corDestaque
                    : Color.Transparent;
                btn.FlatAppearance.MouseDownBackColor = isSelecionado
                    ? corDestaque
                    : Color.Transparent;
            }
        }

        private void InicializarRodape()
        {
            pictureBoxPower.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPower.Image = Image.FromFile("Apresentacao/Imagens/icone_power.png");

            pictureBoxPower.Cursor = Cursors.Hand;
            ToolTipService.Set(pictureBoxPower, "Sair do Sistema");
        }

        private void pictureBoxPower_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show(
                "Deseja realmente sair do sistema?",
                "Confirma��o",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resp == DialogResult.Yes)
                Application.Exit();
        }

        private void btnConsultarDespesas_Click(object sender, EventArgs e)
        {
            DestacarBotao(BtnConsultarDespesas);
            AbrirFormularioNoPanel(new FormConsultarDespesas());
        }

        private void btnConsultarReceitas_Click(object sender, EventArgs e)
        {
            DestacarBotao(BtnConsultarReceitas);
            AbrirFormularioNoPanel(new FormConsultarReceitas());
        }
    }
}