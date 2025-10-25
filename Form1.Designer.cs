namespace Jogo_da_Memória
{
    partial class Jogo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            txtMemoria = new Label();
            btnFacil = new Button();
            btnNormal = new Button();
            btnDificil = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnMute = new Button();
            SuspendLayout();
            // 
            // txtMemoria
            // 
            txtMemoria.AutoSize = true;
            txtMemoria.BackColor = Color.Transparent;
            txtMemoria.Font = new Font("Minecrafter", 50.25F, FontStyle.Bold);
            txtMemoria.ForeColor = SystemColors.GradientInactiveCaption;
            txtMemoria.Location = new Point(583, 9);
            txtMemoria.Name = "txtMemoria";
            txtMemoria.Size = new Size(36, 58);
            txtMemoria.TabIndex = 0;
            txtMemoria.Text = "'";
            // 
            // btnFacil
            // 
            btnFacil.BackColor = Color.DarkOliveGreen;
            btnFacil.BackgroundImageLayout = ImageLayout.Stretch;
            btnFacil.FlatStyle = FlatStyle.Flat;
            btnFacil.Font = new Font("Minecrafter", 9F, FontStyle.Bold);
            btnFacil.ForeColor = SystemColors.ControlLight;
            btnFacil.Location = new Point(205, 235);
            btnFacil.Name = "btnFacil";
            btnFacil.Size = new Size(84, 92);
            btnFacil.TabIndex = 2;
            btnFacil.Text = "FÁCIL";
            btnFacil.UseVisualStyleBackColor = false;
            btnFacil.Click += btnFrmFacil_Click;
            // 
            // btnNormal
            // 
            btnNormal.BackColor = Color.Chocolate;
            btnNormal.FlatStyle = FlatStyle.Flat;
            btnNormal.Font = new Font("Minecrafter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNormal.ForeColor = SystemColors.ButtonHighlight;
            btnNormal.Location = new Point(310, 235);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(144, 92);
            btnNormal.TabIndex = 2;
            btnNormal.Text = "NORMAL";
            btnNormal.UseVisualStyleBackColor = false;
            btnNormal.Click += btnFrmMedio_Click;
            // 
            // btnDificil
            // 
            btnDificil.BackColor = Color.FromArgb(64, 0, 0);
            btnDificil.FlatStyle = FlatStyle.Flat;
            btnDificil.Font = new Font("Minecrafter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDificil.ForeColor = SystemColors.ControlLightLight;
            btnDificil.Location = new Point(482, 235);
            btnDificil.Name = "btnDificil";
            btnDificil.Size = new Size(75, 92);
            btnDificil.TabIndex = 2;
            btnDificil.Text = "DIFÍCIL";
            btnDificil.UseVisualStyleBackColor = false;
            btnDificil.Click += btnFrmDificil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Minecrafter", 50.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(29, 41);
            label1.Name = "label1";
            label1.Size = new Size(719, 58);
            label1.TabIndex = 3;
            label1.Text = "JOGO DA MEMORIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(180, 190);
            label2.Name = "label2";
            label2.Size = new Size(113, 19);
            label2.TabIndex = 4;
            label2.Text = "Para iniciantes!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(482, 190);
            label3.Name = "label3";
            label3.Size = new Size(126, 19);
            label3.TabIndex = 4;
            label3.Text = "Para profissionais!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(321, 190);
            label4.Name = "label4";
            label4.Size = new Size(124, 19);
            label4.TabIndex = 5;
            label4.Text = "Diversão na certa!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Minecrafter", 15F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ScrollBar;
            label5.Location = new Point(231, 110);
            label5.Name = "label5";
            label5.Size = new Size(302, 18);
            label5.TabIndex = 6;
            label5.Text = "Escolha a dificuldade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Minecrafter", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ScrollBar;
            label6.Location = new Point(531, 418);
            label6.Name = "label6";
            label6.Size = new Size(232, 13);
            label6.TabIndex = 6;
            label6.Text = "Created by Joao Victor";
            // 
            // btnMute
            // 
            btnMute.BackColor = Color.Transparent;
            btnMute.BackgroundImage = Properties.Resources.som_on;
            btnMute.BackgroundImageLayout = ImageLayout.Zoom;
            btnMute.FlatAppearance.BorderSize = 0;
            btnMute.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMute.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMute.FlatStyle = FlatStyle.Flat;
            btnMute.ForeColor = Color.Transparent;
            btnMute.Location = new Point(12, 390);
            btnMute.Name = "btnMute";
            btnMute.Size = new Size(33, 38);
            btnMute.TabIndex = 7;
            btnMute.UseVisualStyleBackColor = false;
            btnMute.Click += btnMute_Click;
            btnMute.MouseEnter += MouseEnter;
            // 
            // Jogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(760, 440);
            Controls.Add(btnMute);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDificil);
            Controls.Add(btnNormal);
            Controls.Add(btnFacil);
            Controls.Add(txtMemoria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Jogo";
            Text = "Jogo da Memória";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtMemoria;
        private Button btnFacil;
        private Button btnNormal;
        private Button btnDificil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnMute;
    }
}
