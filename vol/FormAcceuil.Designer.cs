namespace vol
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            btnCompagnie = new Button();
            btnItineraire = new Button();
            btnAvion = new Button();
            btnClient = new Button();
            panelPrincipale = new Panel();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnCompagnie);
            panel1.Controls.Add(btnItineraire);
            panel1.Controls.Add(btnAvion);
            panel1.Controls.Add(btnClient);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 225);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 105);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(793, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 46);
            label1.Name = "label1";
            label1.Size = new Size(559, 104);
            label1.TabIndex = 7;
            label1.Text = "Gestion de Vol";
            // 
            // button7
            // 
            button7.BackColor = Color.DarkGray;
            button7.FlatStyle = FlatStyle.System;
            button7.ForeColor = Color.White;
            button7.Location = new Point(365, 174);
            button7.Name = "button7";
            button7.Size = new Size(129, 45);
            button7.TabIndex = 6;
            button7.Text = "PERSONNEL";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkGray;
            button6.FlatStyle = FlatStyle.System;
            button6.ForeColor = Color.White;
            button6.Location = new Point(617, 175);
            button6.Name = "button6";
            button6.Size = new Size(97, 45);
            button6.TabIndex = 5;
            button6.Text = "VOL";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkGray;
            button5.FlatStyle = FlatStyle.System;
            button5.ForeColor = Color.White;
            button5.Location = new Point(500, 174);
            button5.Name = "button5";
            button5.Size = new Size(111, 46);
            button5.TabIndex = 4;
            button5.Text = "ACCUEIL";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnCompagnie
            // 
            btnCompagnie.BackColor = Color.DarkGray;
            btnCompagnie.FlatStyle = FlatStyle.System;
            btnCompagnie.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompagnie.ForeColor = Color.White;
            btnCompagnie.Location = new Point(133, 173);
            btnCompagnie.Name = "btnCompagnie";
            btnCompagnie.Size = new Size(226, 46);
            btnCompagnie.TabIndex = 3;
            btnCompagnie.Text = "COMPAGNIE AERIENNE";
            btnCompagnie.UseVisualStyleBackColor = false;
            btnCompagnie.Click += btnCompagnie_Click;
            // 
            // btnItineraire
            // 
            btnItineraire.BackColor = Color.DarkGray;
            btnItineraire.FlatStyle = FlatStyle.System;
            btnItineraire.ForeColor = Color.White;
            btnItineraire.Location = new Point(3, 173);
            btnItineraire.Name = "btnItineraire";
            btnItineraire.Size = new Size(124, 45);
            btnItineraire.TabIndex = 2;
            btnItineraire.Text = "ITINERAIRE";
            btnItineraire.UseVisualStyleBackColor = false;
            btnItineraire.Click += btnItineraire_Click;
            // 
            // btnAvion
            // 
            btnAvion.BackColor = Color.DarkGray;
            btnAvion.FlatStyle = FlatStyle.System;
            btnAvion.ForeColor = Color.White;
            btnAvion.Location = new Point(720, 175);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(96, 45);
            btnAvion.TabIndex = 1;
            btnAvion.Text = "AVION";
            btnAvion.UseVisualStyleBackColor = false;
            btnAvion.Click += btnAvion_Click;
            // 
            // btnClient
            // 
            btnClient.BackColor = Color.DarkGray;
            btnClient.FlatStyle = FlatStyle.System;
            btnClient.ForeColor = Color.White;
            btnClient.Location = new Point(822, 175);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(96, 45);
            btnClient.TabIndex = 0;
            btnClient.Text = "CLIENT";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // panelPrincipale
            // 
            panelPrincipale.BackColor = Color.White;
            panelPrincipale.Controls.Add(label2);
            panelPrincipale.Controls.Add(pictureBox3);
            panelPrincipale.Dock = DockStyle.Fill;
            panelPrincipale.Location = new Point(0, 225);
            panelPrincipale.Name = "panelPrincipale";
            panelPrincipale.Size = new Size(925, 546);
            panelPrincipale.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(12, 407);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(510, 130);
            label2.TabIndex = 10;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(925, 546);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(925, 771);
            Controls.Add(panelPrincipale);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "mainForm";
            Text = "Gestion de vol";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPrincipale.ResumeLayout(false);
            panelPrincipale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button btnCompagnie;
        private Button btnItineraire;
        private Button btnAvion;
        private Button btnClient;
        private Label label1;
        private Panel panelPrincipale;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label2;
    }
}
