namespace vol
{
    partial class FormVol
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
            inputReferenceVol = new TextBox();
            inputReferenceItineraire = new TextBox();
            inputCode = new TextBox();
            inputHeure = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAjout = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dgvVol = new DataGridView();
            datePickerVol = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvVol).BeginInit();
            SuspendLayout();
            // 
            // inputReferenceVol
            // 
            inputReferenceVol.BackColor = SystemColors.InactiveCaption;
            inputReferenceVol.Location = new Point(12, 62);
            inputReferenceVol.Margin = new Padding(3, 4, 3, 4);
            inputReferenceVol.Name = "inputReferenceVol";
            inputReferenceVol.Size = new Size(224, 27);
            inputReferenceVol.TabIndex = 7;
            // 
            // inputReferenceItineraire
            // 
            inputReferenceItineraire.BackColor = SystemColors.InactiveCaption;
            inputReferenceItineraire.Location = new Point(12, 134);
            inputReferenceItineraire.Margin = new Padding(3, 4, 3, 4);
            inputReferenceItineraire.Name = "inputReferenceItineraire";
            inputReferenceItineraire.Size = new Size(224, 27);
            inputReferenceItineraire.TabIndex = 8;
            // 
            // inputCode
            // 
            inputCode.BackColor = SystemColors.InactiveCaption;
            inputCode.Location = new Point(12, 212);
            inputCode.Margin = new Padding(3, 4, 3, 4);
            inputCode.Name = "inputCode";
            inputCode.Size = new Size(224, 27);
            inputCode.TabIndex = 9;
            // 
            // inputHeure
            // 
            inputHeure.BackColor = SystemColors.InactiveCaption;
            inputHeure.Location = new Point(12, 366);
            inputHeure.Margin = new Padding(3, 4, 3, 4);
            inputHeure.Name = "inputHeure";
            inputHeure.Size = new Size(224, 27);
            inputHeure.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 35);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 15;
            label4.Text = "Référence Vol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 107);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 16;
            label2.Text = "Référence Itinéraire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 186);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 17;
            label3.Text = "Code Compagnie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 262);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 18;
            label5.Text = "Date Vol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 339);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 19;
            label6.Text = "Heure Vol";
            // 
            // btnAjout
            // 
            btnAjout.BackColor = Color.LightSeaGreen;
            btnAjout.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjout.Location = new Point(308, 435);
            btnAjout.Margin = new Padding(3, 4, 3, 4);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(154, 52);
            btnAjout.TabIndex = 20;
            btnAjout.Text = "Ajouter";
            btnAjout.UseVisualStyleBackColor = false;
            btnAjout.Click += btnAjout_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.ForestGreen;
            btnModifier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.Location = new Point(500, 435);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(154, 52);
            btnModifier.TabIndex = 21;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.Firebrick;
            btnSupprimer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(693, 435);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(154, 52);
            btnSupprimer.TabIndex = 22;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // dgvVol
            // 
            dgvVol.BackgroundColor = Color.OldLace;
            dgvVol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVol.Location = new Point(242, 62);
            dgvVol.Name = "dgvVol";
            dgvVol.RowHeadersWidth = 51;
            dgvVol.Size = new Size(671, 331);
            dgvVol.TabIndex = 23;
            dgvVol.RowHeaderMouseClick += dgvVol_RowHeaderMouseClick;
            // 
            // datePickerVol
            // 
            datePickerVol.Location = new Point(8, 299);
            datePickerVol.Name = "datePickerVol";
            datePickerVol.Size = new Size(228, 27);
            datePickerVol.TabIndex = 26;
            // 
            // FormVol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(925, 545);
            Controls.Add(datePickerVol);
            Controls.Add(dgvVol);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjout);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(inputHeure);
            Controls.Add(inputCode);
            Controls.Add(inputReferenceItineraire);
            Controls.Add(inputReferenceVol);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVol";
            Text = "FormVol";
            ((System.ComponentModel.ISupportInitialize)dgvVol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputReferenceVol;
        private TextBox inputReferenceItineraire;
        private TextBox inputCode;
        private TextBox inputHeure;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btnAjout;
        private Button btnModifier;
        private Button btnSupprimer;
        private DataGridView dgvVol;
        private DateTimePicker datePickerVol;
    }
}