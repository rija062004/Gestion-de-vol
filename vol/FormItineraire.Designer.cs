namespace vol
{
    partial class FormItineraire
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
            inputReferenceitineraire = new TextBox();
            inputVilleDepart = new TextBox();
            inputVilleArriver = new TextBox();
            inputTarif = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dgvitineraire = new DataGridView();
            inputRechercher = new TextBox();
            btnRechercher = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvitineraire).BeginInit();
            SuspendLayout();
            // 
            // inputReferenceitineraire
            // 
            inputReferenceitineraire.BackColor = SystemColors.InactiveCaption;
            inputReferenceitineraire.Location = new Point(12, 53);
            inputReferenceitineraire.Margin = new Padding(3, 4, 3, 4);
            inputReferenceitineraire.Name = "inputReferenceitineraire";
            inputReferenceitineraire.Size = new Size(270, 27);
            inputReferenceitineraire.TabIndex = 4;
            // 
            // inputVilleDepart
            // 
            inputVilleDepart.BackColor = SystemColors.InactiveCaption;
            inputVilleDepart.Location = new Point(12, 120);
            inputVilleDepart.Margin = new Padding(3, 4, 3, 4);
            inputVilleDepart.Name = "inputVilleDepart";
            inputVilleDepart.Size = new Size(270, 27);
            inputVilleDepart.TabIndex = 5;
            // 
            // inputVilleArriver
            // 
            inputVilleArriver.BackColor = SystemColors.InactiveCaption;
            inputVilleArriver.Location = new Point(12, 186);
            inputVilleArriver.Margin = new Padding(3, 4, 3, 4);
            inputVilleArriver.Name = "inputVilleArriver";
            inputVilleArriver.Size = new Size(270, 27);
            inputVilleArriver.TabIndex = 6;
            // 
            // inputTarif
            // 
            inputTarif.BackColor = SystemColors.InactiveCaption;
            inputTarif.Location = new Point(12, 254);
            inputTarif.Margin = new Padding(3, 4, 3, 4);
            inputTarif.Name = "inputTarif";
            inputTarif.Size = new Size(270, 27);
            inputTarif.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 26);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 13;
            label4.Text = "Référence Itinéraire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 14;
            label2.Text = "Ville de Départ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 15;
            label3.Text = "Ville D'arriver";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 228);
            label5.Name = "label5";
            label5.Size = new Size(41, 23);
            label5.TabIndex = 16;
            label5.Text = "Tarif";
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.LightSeaGreen;
            btnAjouter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.Location = new Point(377, 288);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(154, 52);
            btnAjouter.TabIndex = 18;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.ForestGreen;
            btnModifier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.Location = new Point(570, 288);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(154, 52);
            btnModifier.TabIndex = 19;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Firebrick;
            btnSupprimer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(760, 288);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(154, 52);
            btnSupprimer.TabIndex = 20;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // dgvitineraire
            // 
            dgvitineraire.BackgroundColor = Color.OldLace;
            dgvitineraire.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvitineraire.Location = new Point(326, 93);
            dgvitineraire.Name = "dgvitineraire";
            dgvitineraire.RowHeadersWidth = 51;
            dgvitineraire.Size = new Size(588, 188);
            dgvitineraire.TabIndex = 21;
            dgvitineraire.RowHeaderMouseClick += dgvitineraire_RowHeaderMouseClick;
            // 
            // inputRechercher
            // 
            inputRechercher.BackColor = SystemColors.InactiveCaption;
            inputRechercher.Location = new Point(484, 59);
            inputRechercher.Margin = new Padding(3, 4, 3, 4);
            inputRechercher.Name = "inputRechercher";
            inputRechercher.Size = new Size(270, 27);
            inputRechercher.TabIndex = 23;
            // 
            // btnRechercher
            // 
            btnRechercher.BackColor = Color.Orange;
            btnRechercher.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechercher.Location = new Point(760, 39);
            btnRechercher.Margin = new Padding(3, 4, 3, 4);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(154, 52);
            btnRechercher.TabIndex = 24;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = false;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // FormItineraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(926, 446);
            Controls.Add(btnRechercher);
            Controls.Add(inputRechercher);
            Controls.Add(dgvitineraire);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(inputTarif);
            Controls.Add(inputVilleArriver);
            Controls.Add(inputVilleDepart);
            Controls.Add(inputReferenceitineraire);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormItineraire";
            Text = "FormItineraire";
            ((System.ComponentModel.ISupportInitialize)dgvitineraire).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputReferenceitineraire;
        private TextBox inputVilleDepart;
        private TextBox inputVilleArriver;
        private TextBox inputTarif;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private DataGridView dgvitineraire;
        private TextBox inputRechercher;
        private Button btnRechercher;
    }
}