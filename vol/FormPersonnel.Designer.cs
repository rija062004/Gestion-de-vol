namespace vol
{
    partial class FormPersonnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputFonctionPersonnel = new TextBox();
            inputCodePersonnel = new TextBox();
            inputCodeCompagnie = new TextBox();
            inputNomPersonnel = new TextBox();
            inputPrenomPersonnel = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dgvPersonnel = new DataGridView();
            inputRechercher = new TextBox();
            btnRechercher = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonnel).BeginInit();
            SuspendLayout();
            // 
            // inputFonctionPersonnel
            // 
            inputFonctionPersonnel.BackColor = SystemColors.InactiveCaption;
            inputFonctionPersonnel.Location = new Point(12, 339);
            inputFonctionPersonnel.Margin = new Padding(3, 4, 3, 4);
            inputFonctionPersonnel.Name = "inputFonctionPersonnel";
            inputFonctionPersonnel.Size = new Size(221, 27);
            inputFonctionPersonnel.TabIndex = 5;
            // 
            // inputCodePersonnel
            // 
            inputCodePersonnel.BackColor = SystemColors.InactiveCaption;
            inputCodePersonnel.Location = new Point(12, 54);
            inputCodePersonnel.Margin = new Padding(3, 4, 3, 4);
            inputCodePersonnel.Name = "inputCodePersonnel";
            inputCodePersonnel.Size = new Size(221, 27);
            inputCodePersonnel.TabIndex = 6;
            // 
            // inputCodeCompagnie
            // 
            inputCodeCompagnie.BackColor = SystemColors.InactiveCaption;
            inputCodeCompagnie.Location = new Point(12, 126);
            inputCodeCompagnie.Margin = new Padding(3, 4, 3, 4);
            inputCodeCompagnie.Name = "inputCodeCompagnie";
            inputCodeCompagnie.Size = new Size(221, 27);
            inputCodeCompagnie.TabIndex = 7;
            // 
            // inputNomPersonnel
            // 
            inputNomPersonnel.BackColor = SystemColors.InactiveCaption;
            inputNomPersonnel.Location = new Point(12, 202);
            inputNomPersonnel.Margin = new Padding(3, 4, 3, 4);
            inputNomPersonnel.Name = "inputNomPersonnel";
            inputNomPersonnel.Size = new Size(221, 27);
            inputNomPersonnel.TabIndex = 8;
            // 
            // inputPrenomPersonnel
            // 
            inputPrenomPersonnel.BackColor = SystemColors.InactiveCaption;
            inputPrenomPersonnel.Location = new Point(12, 268);
            inputPrenomPersonnel.Margin = new Padding(3, 4, 3, 4);
            inputPrenomPersonnel.Name = "inputPrenomPersonnel";
            inputPrenomPersonnel.Size = new Size(221, 27);
            inputPrenomPersonnel.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 27);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 14;
            label4.Text = "Code Personnel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 15;
            label2.Text = "Code Compagnie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 16;
            label3.Text = "Nom Personnel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 242);
            label5.Name = "label5";
            label5.Size = new Size(149, 23);
            label5.TabIndex = 17;
            label5.Text = "Prenom Personnel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 312);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 18;
            label6.Text = "Fonction Personnel";
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.LightSeaGreen;
            btnAjouter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.Location = new Point(297, 378);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(154, 52);
            btnAjouter.TabIndex = 19;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.ForestGreen;
            btnModifier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.Location = new Point(487, 378);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(154, 52);
            btnModifier.TabIndex = 20;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Firebrick;
            btnSupprimer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(683, 378);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(154, 52);
            btnSupprimer.TabIndex = 21;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // dgvPersonnel
            // 
            dgvPersonnel.BackgroundColor = Color.OldLace;
            dgvPersonnel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonnel.Location = new Point(297, 99);
            dgvPersonnel.Name = "dgvPersonnel";
            dgvPersonnel.RowHeadersWidth = 51;
            dgvPersonnel.Size = new Size(614, 267);
            dgvPersonnel.TabIndex = 22;
            dgvPersonnel.RowHeaderMouseClick += dgvPersonnel_RowHeaderMouseClick;
            // 
            // inputRechercher
            // 
            inputRechercher.BackColor = SystemColors.InactiveCaption;
            inputRechercher.Location = new Point(530, 54);
            inputRechercher.Margin = new Padding(3, 4, 3, 4);
            inputRechercher.Name = "inputRechercher";
            inputRechercher.Size = new Size(221, 27);
            inputRechercher.TabIndex = 23;
            // 
            // btnRechercher
            // 
            btnRechercher.BackColor = Color.Orange;
            btnRechercher.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechercher.Location = new Point(757, 40);
            btnRechercher.Margin = new Padding(3, 4, 3, 4);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(154, 52);
            btnRechercher.TabIndex = 24;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = false;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // FormPersonnel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(923, 739);
            Controls.Add(btnRechercher);
            Controls.Add(inputRechercher);
            Controls.Add(dgvPersonnel);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(inputPrenomPersonnel);
            Controls.Add(inputNomPersonnel);
            Controls.Add(inputCodeCompagnie);
            Controls.Add(inputCodePersonnel);
            Controls.Add(inputFonctionPersonnel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPersonnel";
            Text = "FormPersonnel";
            Load += FormPersonnel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonnel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputFonctionPersonnel;
        private TextBox inputCodePersonnel;
        private TextBox inputCodeCompagnie;
        private TextBox inputNomPersonnel;
        private TextBox inputPrenomPersonnel;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private DataGridView dgvPersonnel;
        private TextBox inputRechercher;
        private Button btnRechercher;
    }
}