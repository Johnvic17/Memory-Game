namespace Jogo_da_Memória
{
    public partial class FrmFacil : Form
    {
        Label firstClicked = null; // Primeira carta clicada
        Label secondClicked = null; // Segunda carta clicada
        bool jogoAtivo = false;     // Indica se o jogo já começou

        public FrmFacil()
        {
            InitializeComponent();
            AssignIconsToSquares(); // Distribui os ícones nas cartas
            EsconderIcones();  // Esconde todos os ícones (cartas “viradas”)
        }

        Random random = new Random(); // Gera números aleatórios

        // Lista de ícones usados no modo fácil (8 pares)
        List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k", "k", "b", "b","v","v","w","w","z","z"
        };

        // Atribui os ícones de forma aleatória às labels do tabuleiro
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                { 
                    int randomNumber = random.Next(icons.Count); // Escolhe posição aleatória
                    iconLabel.Text = icons[randomNumber];        // Define o ícone na carta
                    icons.RemoveAt(randomNumber);                // Remove o ícone da lista
                }
            }
        }

        // Esconde todos os ícones, deixando as cartas “viradas”
        private void EsconderIcones()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.ForeColor = iconLabel.BackColor; // Mesma cor = ícone invisível
                }
            }
        }

        // Evento acionado quando o jogador clica em uma carta
        public void label_Click(object sender, EventArgs e)
        {
            if (!jogoAtivo) // Impede cliques antes de iniciar o jogo

                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Ignora clique em carta já revelada
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // Primeiro clique: mostra o ícone e guarda a carta
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                // Segundo clique: mostra o ícone e compara com a primeira carta
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner(); // Verifica se o jogo foi concluído

                // Se as duas cartas forem iguais, mantém reveladas
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                // Se forem diferentes, inicia o timer para escondê-las depois
                timer1.Start();
            }
        }

        // Timer que dá tempo para o jogador ver as duas cartas antes de escondê-las
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            // “Vira” novamente as cartas
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        // Verifica se o jogador já encontrou todos os pares
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return; // Ainda existem cartas escondidas
                }
            }

            // Todas as cartas foram reveladas = vitória!
            MessageBox.Show("Você emparelhou todos os icones!", "Parabéns");
            Close(); // Fecha o jogo
        }

        // Botão que inicia o jogo
        private void btnStart_Click(object sender, EventArgs e)
        {
            jogoAtivo = true; // ativa o jogo
            MessageBox.Show("O jogo começou! Boa sorte!");
        }
    }
}
