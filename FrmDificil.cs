using System.Drawing.Text;

namespace Jogo_da_Memória
{
    public partial class FrmDificil : Form
    {
        Label firstClicked = null; // Primeira carta clicada
        Label secondClicked = null; // Segunda carta clicada
        bool jogoAtivo = false; // Indica se o jogo já começou

        PrivateFontCollection privateFonts = new PrivateFontCollection();

        private void CarregarFonte()
        {
            string fontePath = Path.Combine(Application.StartupPath, "Resources", "Minecrafter.Alt.ttf");
            privateFonts.AddFontFile(fontePath);
            Font minhaFonte = new Font(privateFonts.Families[0], 20F, FontStyle.Regular);
            btnStart.Font = minhaFonte;
        }

        public FrmDificil()
        {
            InitializeComponent();
            AssignIconsToSquares(); // Distribui os ícones nas cartas
            EsconderIcones();  // Esconde os ícones (mostra só o verso)
            CarregarFonte(); // Carrega a fonte externa
        }

        Random random = new Random(); // Gera números aleatórios

        // Lista com os ícones que serão usados nas cartas (pares)
        List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k", "k", "b", "b","v","v","w","w","z","z","%","%","$","$","h","h","G","G","l","l","~","~","p","p","P","P","O","O" ,"E","E","e","e","A","A","@","@","-","-","I","I","B","B","C","C","d","d","f","f","F","F","H","H","j","j","m","m","M","M"
        };

        // Atribui ícones aleatoriamente às labels do tabuleiro
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count); // Escolhe ícone aleatório
                    iconLabel.Text = icons[randomNumber];        // Coloca o ícone na label
                    icons.RemoveAt(randomNumber);                // Remove o ícone da lista (evita repetição)
                }
            }
        }

        // Esconde todos os ícones, “virando” as cartas
        private void EsconderIcones()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.ForeColor = iconLabel.BackColor; // Mesma cor = texto invisível
                }
            }
        }

        // Ação quando o jogador clica em uma carta
        public void label_Click(object sender, EventArgs e)
        {
            if (!jogoAtivo) // Só funciona se o jogo tiver começado
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Ignora clique em carta já revelada
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // Se for o primeiro clique, guarda a carta e mostra o ícone
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                // Segundo clique: revela e compara
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner(); // Verifica se o jogador venceu

                // Se os ícones forem iguais, mantém virados
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                // Se forem diferentes, inicia o timer para "virar" novamente
                timer1.Start();
            }
        }

        // Timer que dá tempo para o jogador ver as duas cartas antes de escondê-las
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            // Esconde as duas cartas novamente
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        // Verifica se todas as cartas foram descobertas
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return; // Ainda há cartas escondidas
                }
            }

            // Se todas foram reveladas, o jogador venceu
            MessageBox.Show("Você emparelhou todos os icones!", "Parabéns");
            Close(); // Fecha o jogo
        }

        // Botão que inicia o jogo
        public void btnStart_Click(object sender, EventArgs e)
        {
            jogoAtivo = true; // Libera os cliques nas cartas
            MessageBox.Show("O jogo começou! Boa sorte!");
        }
    }
}

