using AxWMPLib;
using System.IO;
using System.Numerics;
using WMPLib;

namespace Jogo_da_Memória
{
    public partial class Jogo : Form
    {
        AxWindowsMediaPlayer player;

        public Jogo()
        {
            InitializeComponent();

        }

        private void btnFrmFacil_Click(object sender, EventArgs e)
        {
            btnFacil.Enabled = false;
            btnNormal.Enabled = false;
            btnDificil.Enabled = false;
            FrmFacil frmFacil = new FrmFacil();
            frmFacil.FormClosed += (s, args) =>
            {
                btnFacil.Enabled = true;
                btnNormal.Enabled = true;
                btnDificil.Enabled = true;
            };
            frmFacil.Show();

        }

        private void btnFrmMedio_Click(object sender, EventArgs e)
        {
            btnFacil.Enabled = false;
            btnNormal.Enabled = false;
            btnDificil.Enabled = false;
            FrmNormal frmNormal = new FrmNormal();
            frmNormal.FormClosed += (s, args) =>
            {
                btnFacil.Enabled = true;
                btnNormal.Enabled = true;
                btnDificil.Enabled = true;
            };
            frmNormal.Show();
        }

        private void btnFrmDificil_Click(object sender, EventArgs e)
        {
            btnFacil.Enabled = false;
            btnNormal.Enabled = false;
            btnDificil.Enabled = false;
            FrmDificil frmDificil = new FrmDificil();
            frmDificil.FormClosed += (s, args) =>
            {
                btnFacil.Enabled = true;
                btnNormal.Enabled = true;
                btnDificil.Enabled = true;
            };
            frmDificil.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new AxWindowsMediaPlayer();
            player.CreateControl();
            player.Visible = false; // oculta o player na interface
            this.Controls.Add(player);

            // define o caminho da música
            string caminhoMusica = Path.Combine(Application.StartupPath, "Resources", "musica_fundo.mp3");

            player.URL = caminhoMusica;
            player.settings.setMode("loop", true); // repete a música
            player.settings.volume = 40; // volume médio
            player.Ctlcontrols.play();
        }

        bool isMuted = false;

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (player == null) return;

            isMuted = !isMuted;
            player.settings.mute = isMuted;
            btnMute.BackgroundImage = isMuted ? Properties.Resources.som_off : Properties.Resources.som_on;

            btnMute.BackgroundImageLayout = ImageLayout.Zoom;
            btnMute.FlatStyle = FlatStyle.Flat;
            btnMute.FlatAppearance.BorderSize = 0;
            btnMute.BackColor = Color.Transparent;

        }

        private void MouseEnter(object sender, EventArgs e)
        {
            btnMute.BackColor = Color.Transparent;
        }
    }
}
