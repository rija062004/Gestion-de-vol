namespace vol
{
    partial class FormAvion
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
            inputCodeAvion = new TextBox();
            inputCodeCompagnie = new TextBox();
            inputModel = new TextBox();
            inputReferenceVol = new TextBox();
            inputCapacite = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dvgAvion = new DataGridView();
            inputRechercher = new TextBox();
            btnRechercher = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgAvion).BeginInit();
            SuspendLayout();
            // 
            // inputCodeAvion
            // 
            inputCodeAvion.BackColor = SystemColors.InactiveCaption;
            inputCodeAvion.Location = new Point(12, 51);
            inputCodeAvion.Margin = new Padding(3, 4, 3, 4);
            inputCodeAvion.Name = "inputCodeAvion";
            inputCodeAvion.Size = new Size(270, 27);
            inputCodeAvion.TabIndex = 2;
            // 
            // inputCodeCompagnie
            // 
            inputCodeCompagnie.BackColor = SystemColors.InactiveCaption;
            inputCodeCompagnie.Location = new Point(12, 117);
            inputCodeCompagnie.Margin = new Padding(3, 4, 3, 4);
            inputCodeCompagnie.Name = "inputCodeCompagnie";
            inputCodeCompagnie.Size = new Size(270, 27);
            inputCodeCompagnie.TabIndex = 3;
            // 
            // inputModel
            // 
            inputModel.BackColor = SystemColors.InactiveCaption;
            inputModel.Location = new Point(10, 248);
            inputModel.Margin = new Padding(3, 4, 3, 4);
            inputModel.Name = "inputModel";
            inputModel.Size = new Size(270, 27);
            inputModel.TabIndex = 4;
            // 
            // inputReferenceVol
            // 
            inputReferenceVol.BackColor = SystemColors.InactiveCaption;
            inputReferenceVol.Location = new Point(12, 183);
            inputReferenceVol.Margin = new Padding(3, 4, 3, 4);
            inputReferenceVol.Name = "inputReferenceVol";
            inputReferenceVol.Size = new Size(269, 27);
            inputReferenceVol.TabIndex = 5;
            // 
            // inputCapacite
            // 
            inputCapacite.BackColor = SystemColors.InactiveCaption;
            inputCapacite.Location = new Point(12, 313);
            inputCapacite.Margin = new Padding(3, 4, 3, 4);
            inputCapacite.Name = "inputCapacite";
            inputCapacite.Size = new Size(270, 27);
            inputCapacite.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 7;
            label2.Text = "Code Avion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 8;
            label3.Text = "Code Compagnie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 152);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 9;
            label4.Text = "Reference Vol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 217);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 10;
            label5.Text = "Modèle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 283);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 11;
            label6.Text = "Capacité";
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.LightSeaGreen;
            btnAjouter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.Location = new Point(363, 398);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(154, 52);
            btnAjouter.TabIndex = 12;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.ForestGreen;
            btnModifier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.Location = new Point(585, 398);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(154, 52);
            btnModifier.TabIndex = 13;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Firebrick;
            btnSupprimer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(779, 398);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(154, 52);
            btnSupprimer.TabIndex = 14;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // dvgAvion
            // 
            dvgAvion.BackgroundColor = Color.OldLace;
            dvgAvion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAvion.Location = new Point(288, 87);
            dvgAvion.Name = "dvgAvion";
            dvgAvion.RowHeadersWidth = 51;
            dvgAvion.Size = new Size(645, 289);
            dvgAvion.TabIndex = 15;
            dvgAvion.RowHeaderMouseClick += dvgAvion_RowHeaderMouseClick;
            // 
            // inputRechercher
            // 
            inputRechercher.BackColor = SystemColors.InactiveCaption;
            inputRechercher.Location = new Point(487, 53);
            inputRechercher.Margin = new Padding(3, 4, 3, 4);
            inputRechercher.Name = "inputRechercher";
            inputRechercher.Size = new Size(270, 27);
            inputRechercher.TabIndex = 16;
            // 
            // btnRechercher
            // 
            btnRechercher.BackColor = Color.PeachPuff;
            btnRechercher.FlatStyle = FlatStyle.Flat;
            btnRechercher.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechercher.Location = new Point(779, 28);
            btnRechercher.Margin = new Padding(3, 4, 3, 4);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(154, 52);
            btnRechercher.TabIndex = 17;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = false;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // FormAvion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1009, 532);
            Controls.Add(btnRechercher);
            Controls.Add(inputRechercher);
            Controls.Add(dvgAvion);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputCapacite);
            Controls.Add(inputReferenceVol);
            Controls.Add(inputModel);
            Controls.Add(inputCodeCompagnie);
            Controls.Add(inputCodeAvion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAvion";
            Text = "FormAvion";
            ((System.ComponentModel.ISupportInitialize)dvgAvion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputCodeAvion;
        private TextBox inputCodeCompagnie;
        private TextBox inputModel;
        private TextBox inputReferenceVol;
        private TextBox inputCapacite;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private DataGridView dvgAvion;
        private TextBox inputRechercher;
        private Button btnRechercher;
    }
}