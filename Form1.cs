using AxWMPLib; // Biblioteca usada para controlar o player de música (Windows Media Player)

namespace Jogo_da_Memória
{
    public partial class Jogo : Form
    {
        AxWindowsMediaPlayer player; // Objeto para reproduzir música de fundo

        public Jogo()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário

        }

        // Botão que abre o modo "Fácil" do jogo
        private void btnFrmFacil_Click(object sender, EventArgs e)
        {
            // Desativa os botões de dificuldade enquanto o jogo está aberto
            btnFacil.Enabled = false;
            btnNormal.Enabled = false;
            btnDificil.Enabled = false;
            FrmFacil frmFacil = new FrmFacil(); // Cria o formulário do modo fácil

            // Quando o formulário for fechado, reativa os botões
            frmFacil.FormClosed += (s, args) =>
            {
                btnFacil.Enabled = true;
                btnNormal.Enabled = true;
                btnDificil.Enabled = true;
            };
            frmFacil.Show(); // Exibe o jogo

        }

        // Botão que abre o modo "Normal" do jogo
        private void btnFrmMedio_Click(object sender, EventArgs e)
        {
            btnFacil.Enabled = false;
            btnNormal.Enabled = false;
            btnDificil.Enabled = false;
            FrmNormal frmNormal = new FrmNormal(); // Cria o formulário do modo normal
            frmNormal.FormClosed += (s, args) =>
            {
                btnFacil.Enabled = true;
                btnNormal.Enabled = true;
                btnDificil.Enabled = true;
            };
            frmNormal.Show(); // Exibe o jogo
        }

        // Botão que abre o modo "Difícil" do jogo
        private void btnFrmDificil_Click(object sender, EventArgs e)
        {
            btnFacil.Enabled = false;
            btnNormal.Enabled = false;
            btnDificil.Enabled = false;
            FrmDificil frmDificil = new FrmDificil(); // Cria o formulário do modo difícil
            frmDificil.FormClosed += (s, args) =>
            {
                btnFacil.Enabled = true;
                btnNormal.Enabled = true;
                btnDificil.Enabled = true;
            };
            frmDificil.Show(); // Exibe o jogo
        }

        // Evento disparado quando o formulário principal é carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            player = new AxWindowsMediaPlayer(); // Instancia o player
            player.CreateControl();
            player.Visible = false; // oculta o player na interface
            this.Controls.Add(player); // Adiciona o player ao formulário

            // define o caminho da música
            string caminhoMusica = Path.Combine(Application.StartupPath, "Resources", "musica_fundo.mp3");

            player.URL = caminhoMusica; // Carrega o arquivo de música
            player.settings.setMode("loop", true); // repete a música
            player.settings.volume = 40; // volume médio
            player.Ctlcontrols.play(); // Inicia a reprodução
        }

        bool isMuted = false; // Controla se o som está mudo ou não

        // Botão responsável por mutar/desmutar o som
        private void btnMute_Click(object sender, EventArgs e)
        {
            if (player == null) return;

            isMuted = !isMuted; // Alterna o estado de som (ligado/desligado)
            player.settings.mute = isMuted; // Atualiza no player

            // Altera o ícone do botão conforme o estado do som
            btnMute.BackgroundImage = isMuted ? Properties.Resources.som_off : Properties.Resources.som_on;
            btnMute.BackgroundImageLayout = ImageLayout.Zoom;

            // Deixa o botão com aparência limpa e fundo transparente
            btnMute.FlatStyle = FlatStyle.Flat;
            btnMute.FlatAppearance.BorderSize = 0;
            btnMute.BackColor = Color.Transparent;

        }

        // Garante que o botão não mude de cor quando o mouse passa por cima
        private void MouseEnter(object sender, EventArgs e)
        {
            btnMute.BackColor = Color.Transparent;
        }
    }
}
