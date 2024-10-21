using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vol
{
    public partial class FormPersonnel : Form
    {
        private Personnel personnel;
        private string idpersonnel;
        public FormPersonnel()
        {
            InitializeComponent();
            personnel = new Personnel();
            personnel.readData(dgvPersonnel);
            idpersonnel = "";
        }

        private void FormPersonnel_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                //Maka données :
                string code = inputCodePersonnel.Text;
                string compagnie = inputCodeCompagnie.Text;
                string nom = inputNomPersonnel.Text;
                string prenom = (inputPrenomPersonnel.Text);
                string fonction = inputFonctionPersonnel.Text;
                //Insertion :
                personnel.insertData(code, compagnie, nom, prenom, fonction);
                //Refresh :
                personnel.readData(dgvPersonnel);
                //reset :
                inputCodePersonnel.Text = "";
                inputCodeCompagnie.Text = "";
                inputNomPersonnel.Text = "";
                inputPrenomPersonnel.Text = "";
                inputFonctionPersonnel.Text = "";
                MessageBox.Show("Insertion réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                //Maka données :
                string code = inputCodePersonnel.Text;
                string compagnie = inputCodeCompagnie.Text;
                string nom = inputNomPersonnel.Text;
                string prenom = (inputPrenomPersonnel.Text);
                string fonction = inputFonctionPersonnel.Text;
                string id = idpersonnel;
                //Insertion :
                personnel.updateData(id, code, compagnie, nom, prenom, fonction);
                //Refresh :
                personnel.readData(dgvPersonnel);
                //reset :
                inputCodePersonnel.Text = "";
                inputCodeCompagnie.Text = "";
                inputNomPersonnel.Text = "";
                inputPrenomPersonnel.Text = "";
                inputFonctionPersonnel.Text = "";
                MessageBox.Show("Modification réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idpersonnel;
                //reset :
                inputCodePersonnel.Text = "";
                inputCodeCompagnie.Text = "";
                inputNomPersonnel.Text = "";
                inputPrenomPersonnel.Text = "";
                inputFonctionPersonnel.Text = "";
                personnel.deleteData(id);
                personnel.readData(dgvPersonnel);
                MessageBox.Show("Suppréssion réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPersonnel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            inputCodePersonnel.Text = dgvPersonnel.Rows[index].Cells[0].Value.ToString();
            idpersonnel = dgvPersonnel.Rows[index].Cells[0].Value.ToString();
            inputCodeCompagnie.Text = dgvPersonnel.Rows[index].Cells[1].Value.ToString();
            inputNomPersonnel.Text = dgvPersonnel.Rows[index].Cells[2].Value.ToString();
            inputPrenomPersonnel.Text = dgvPersonnel.Rows[index].Cells[3].Value.ToString();
            inputFonctionPersonnel.Text = dgvPersonnel.Rows[index].Cells[4].Value.ToString();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                string id = inputRechercher.Text;
                personnel.rechercherData(id, dgvPersonnel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
