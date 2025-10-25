using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memória
{
    public partial class FrmNormal : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;
        bool jogoAtivo = false;

        public FrmNormal()
        {
            InitializeComponent();
            AssignIconsToSquares();
            EsconderIcones();
        }

        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k", "k", "b", "b","v","v","w","w","z","z","%","%","$","$","h","h","G","G","l","l","~","~","p","p","P","P","O","O" ,"E","E"
        };
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void EsconderIcones()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.ForeColor = iconLabel.BackColor; // “vira” todas as cartas
                }
            }
        }

        public void label_Click(object sender, EventArgs e)
        {
            if (!jogoAtivo)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show("Você emparelhou todos os icones!", "Parabéns");
            Close();
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            jogoAtivo = true;
            MessageBox.Show("O jogo começou! Boa sorte!");
        }
    }
}
