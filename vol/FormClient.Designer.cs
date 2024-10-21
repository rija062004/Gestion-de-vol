namespace vol
{
    partial class FormClient
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
            inputPasseport = new TextBox();
            inputVol = new TextBox();
            inputCin = new TextBox();
            inputNom = new TextBox();
            inputPrenom = new TextBox();
            inputAdresse = new TextBox();
            inputTelephone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAjout = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dgvClient = new DataGridView();
            inputRechercher = new TextBox();
            btnRechercher = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClient).BeginInit();
            SuspendLayout();
            // 
            // inputPasseport
            // 
            inputPasseport.BackColor = SystemColors.InactiveCaption;
            inputPasseport.Location = new Point(12, 42);
            inputPasseport.Margin = new Padding(3, 4, 3, 4);
            inputPasseport.Name = "inputPasseport";
            inputPasseport.Size = new Size(211, 27);
            inputPasseport.TabIndex = 2;
            // 
            // inputVol
            // 
            inputVol.BackColor = SystemColors.InactiveCaption;
            inputVol.Location = new Point(12, 107);
            inputVol.Margin = new Padding(3, 4, 3, 4);
            inputVol.Name = "inputVol";
            inputVol.Size = new Size(211, 27);
            inputVol.TabIndex = 3;
            // 
            // inputCin
            // 
            inputCin.BackColor = SystemColors.InactiveCaption;
            inputCin.Location = new Point(12, 172);
            inputCin.Margin = new Padding(3, 4, 3, 4);
            inputCin.Name = "inputCin";
            inputCin.Size = new Size(211, 27);
            inputCin.TabIndex = 4;
            // 
            // inputNom
            // 
            inputNom.BackColor = SystemColors.InactiveCaption;
            inputNom.Location = new Point(12, 240);
            inputNom.Margin = new Padding(3, 4, 3, 4);
            inputNom.Name = "inputNom";
            inputNom.Size = new Size(211, 27);
            inputNom.TabIndex = 5;
            // 
            // inputPrenom
            // 
            inputPrenom.BackColor = SystemColors.InactiveCaption;
            inputPrenom.Location = new Point(12, 306);
            inputPrenom.Margin = new Padding(3, 4, 3, 4);
            inputPrenom.Name = "inputPrenom";
            inputPrenom.Size = new Size(211, 27);
            inputPrenom.TabIndex = 6;
            // 
            // inputAdresse
            // 
            inputAdresse.BackColor = SystemColors.InactiveCaption;
            inputAdresse.Location = new Point(12, 368);
            inputAdresse.Margin = new Padding(3, 4, 3, 4);
            inputAdresse.Name = "inputAdresse";
            inputAdresse.Size = new Size(211, 27);
            inputAdresse.TabIndex = 7;
            // 
            // inputTelephone
            // 
            inputTelephone.BackColor = SystemColors.InactiveCaption;
            inputTelephone.Location = new Point(12, 430);
            inputTelephone.Margin = new Padding(3, 4, 3, 4);
            inputTelephone.Name = "inputTelephone";
            inputTelephone.Size = new Size(211, 27);
            inputTelephone.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 9;
            label2.Text = "Numéro Passeport";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 10;
            label3.Text = "Reference Vol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 11;
            label4.Text = "Numéro CIN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 214);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 12;
            label5.Text = "Nom Client";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 279);
            label6.Name = "label6";
            label6.Size = new Size(119, 23);
            label6.TabIndex = 13;
            label6.Text = "Prénom Client";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 340);
            label7.Name = "label7";
            label7.Size = new Size(118, 23);
            label7.TabIndex = 14;
            label7.Text = "Adresse Client";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 403);
            label8.Name = "label8";
            label8.Size = new Size(156, 23);
            label8.TabIndex = 15;
            label8.Text = "Numéro Téléphone";
            // 
            // btnAjout
            // 
            btnAjout.BackColor = Color.LightSeaGreen;
            btnAjout.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjout.Location = new Point(280, 464);
            btnAjout.Margin = new Padding(3, 4, 3, 4);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(154, 52);
            btnAjout.TabIndex = 16;
            btnAjout.Text = "Ajouter";
            btnAjout.UseVisualStyleBackColor = false;
            btnAjout.Click += btnAjout_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.ForestGreen;
            btnModifier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.Location = new Point(477, 464);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(154, 52);
            btnModifier.TabIndex = 17;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Firebrick;
            btnSupprimer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(680, 464);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(154, 52);
            btnSupprimer.TabIndex = 18;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // dgvClient
            // 
            dgvClient.BackgroundColor = Color.OldLace;
            dgvClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClient.Location = new Point(235, 79);
            dgvClient.Name = "dgvClient";
            dgvClient.RowHeadersWidth = 51;
            dgvClient.Size = new Size(673, 378);
            dgvClient.TabIndex = 19;
            dgvClient.RowHeaderMouseClick += dgvClient_RowHeaderMouseClick;
            // 
            // inputRechercher
            // 
            inputRechercher.BackColor = SystemColors.InactiveCaption;
            inputRechercher.Location = new Point(537, 48);
            inputRechercher.Margin = new Padding(3, 4, 3, 4);
            inputRechercher.Name = "inputRechercher";
            inputRechercher.Size = new Size(211, 27);
            inputRechercher.TabIndex = 20;
            // 
            // btnRechercher
            // 
            btnRechercher.BackColor = Color.Goldenrod;
            btnRechercher.FlatStyle = FlatStyle.Flat;
            btnRechercher.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechercher.Location = new Point(754, 33);
            btnRechercher.Margin = new Padding(3, 4, 3, 4);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(154, 42);
            btnRechercher.TabIndex = 21;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = false;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(920, 831);
            Controls.Add(btnRechercher);
            Controls.Add(inputRechercher);
            Controls.Add(dgvClient);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjout);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputTelephone);
            Controls.Add(inputAdresse);
            Controls.Add(inputPrenom);
            Controls.Add(inputNom);
            Controls.Add(inputCin);
            Controls.Add(inputVol);
            Controls.Add(inputPasseport);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormClient";
            Text = "FormClient";
            ((System.ComponentModel.ISupportInitialize)dgvClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputPasseport;
        private TextBox inputVol;
        private TextBox inputCin;
        private TextBox inputNom;
        private TextBox inputPrenom;
        private TextBox inputAdresse;
        private TextBox inputTelephone;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAjout;
        private Button btnModifier;
        private Button btnSupprimer;
        private DataGridView dgvClient;
        private TextBox inputRechercher;
        private Button btnRechercher;
    }
}