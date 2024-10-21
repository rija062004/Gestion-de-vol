namespace vol
{
    partial class FormCompagnie
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
            inputCodecompagnie = new TextBox();
            inputNomCompagnie = new TextBox();
            inputAdresseCompagie = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dgvCompagnie = new DataGridView();
            inputNumCompagnie = new TextBox();
            inputRechercher = new TextBox();
            btnRechercher = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCompagnie).BeginInit();
            SuspendLayout();
            // 
            // inputCodecompagnie
            // 
            inputCodecompagnie.BackColor = SystemColors.InactiveCaption;
            inputCodecompagnie.Location = new Point(12, 44);
            inputCodecompagnie.Margin = new Padding(3, 4, 3, 4);
            inputCodecompagnie.Name = "inputCodecompagnie";
            inputCodecompagnie.Size = new Size(270, 27);
            inputCodecompagnie.TabIndex = 3;
            // 
            // inputNomCompagnie
            // 
            inputNomCompagnie.BackColor = SystemColors.InactiveCaption;
            inputNomCompagnie.Location = new Point(12, 118);
            inputNomCompagnie.Margin = new Padding(3, 4, 3, 4);
            inputNomCompagnie.Name = "inputNomCompagnie";
            inputNomCompagnie.Size = new Size(270, 27);
            inputNomCompagnie.TabIndex = 4;
            // 
            // inputAdresseCompagie
            // 
            inputAdresseCompagie.BackColor = SystemColors.InactiveCaption;
            inputAdresseCompagie.Location = new Point(12, 189);
            inputAdresseCompagie.Margin = new Padding(3, 4, 3, 4);
            inputAdresseCompagie.Name = "inputAdresseCompagie";
            inputAdresseCompagie.Size = new Size(270, 27);
            inputAdresseCompagie.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 17);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 12;
            label4.Text = "Code Compagnie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 92);
            label2.Name = "label2";
            label2.Size = new Size(214, 23);
            label2.TabIndex = 13;
            label2.Text = "Nom Compagnie Aérienne";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 14;
            label3.Text = "Adresse Compagnie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 236);
            label5.Name = "label5";
            label5.Size = new Size(166, 23);
            label5.TabIndex = 15;
            label5.Text = "Numéro Compagnie";
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.LightSeaGreen;
            btnAjouter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.Location = new Point(369, 296);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(154, 52);
            btnAjouter.TabIndex = 17;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.ForestGreen;
            btnModifier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.Location = new Point(565, 296);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(154, 52);
            btnModifier.TabIndex = 18;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Firebrick;
            btnSupprimer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(757, 296);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(154, 52);
            btnSupprimer.TabIndex = 19;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // dgvCompagnie
            // 
            dgvCompagnie.BackgroundColor = Color.OldLace;
            dgvCompagnie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompagnie.Location = new Point(293, 71);
            dgvCompagnie.Name = "dgvCompagnie";
            dgvCompagnie.RowHeadersWidth = 51;
            dgvCompagnie.Size = new Size(618, 218);
            dgvCompagnie.TabIndex = 20;
            dgvCompagnie.RowHeaderMouseClick += dgvCompagnie_RowHeaderMouseClick;
            // 
            // inputNumCompagnie
            // 
            inputNumCompagnie.BackColor = SystemColors.InactiveCaption;
            inputNumCompagnie.Location = new Point(11, 262);
            inputNumCompagnie.Margin = new Padding(3, 4, 3, 4);
            inputNumCompagnie.Name = "inputNumCompagnie";
            inputNumCompagnie.Size = new Size(270, 27);
            inputNumCompagnie.TabIndex = 6;
            // 
            // inputRechercher
            // 
            inputRechercher.BackColor = SystemColors.InactiveCaption;
            inputRechercher.Location = new Point(481, 33);
            inputRechercher.Margin = new Padding(3, 4, 3, 4);
            inputRechercher.Name = "inputRechercher";
            inputRechercher.Size = new Size(270, 27);
            inputRechercher.TabIndex = 21;
            // 
            // btnRechercher
            // 
            btnRechercher.BackColor = Color.Orange;
            btnRechercher.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechercher.Location = new Point(757, 13);
            btnRechercher.Margin = new Padding(3, 4, 3, 4);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(154, 52);
            btnRechercher.TabIndex = 22;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = false;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // FormCompagnie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(923, 490);
            Controls.Add(btnRechercher);
            Controls.Add(inputRechercher);
            Controls.Add(dgvCompagnie);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(inputNumCompagnie);
            Controls.Add(inputAdresseCompagie);
            Controls.Add(inputNomCompagnie);
            Controls.Add(inputCodecompagnie);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCompagnie";
            Text = "FormCompagnie";
            ((System.ComponentModel.ISupportInitialize)dgvCompagnie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputCodecompagnie;
        private TextBox inputNomCompagnie;
        private TextBox inputAdresseCompagie;
        private TextBox textBox4;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private DataGridView dgvCompagnie;
        private TextBox inputNumCompagnie;
        private TextBox inputRechercher;
        private Button btnRechercher;
    }
}