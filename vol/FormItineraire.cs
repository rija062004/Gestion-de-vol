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
    public partial class FormItineraire : Form
    {
        private Itineraire itineraire;
        private string iditineraire;
        public FormItineraire()
        {
            InitializeComponent();
            itineraire = new Itineraire(); iditineraire = "";
            itineraire.readData(dgvitineraire);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                //Maka données :
                string reference = inputReferenceitineraire.Text;
                string depart = inputVilleDepart.Text;
                string arriver = inputVilleArriver.Text;
                float tarif = float.Parse(inputTarif.Text);
                //Insertion :
                itineraire.insertData(reference, depart, arriver, tarif);
                //Refresh :
                itineraire.readData(dgvitineraire);
                //reset :
                inputReferenceitineraire.ResetText();
                inputVilleDepart.ResetText();
                inputVilleArriver.ResetText();
                inputTarif.ResetText();
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
                string reference = inputReferenceitineraire.Text;
                string depart = inputVilleDepart.Text;
                string arriver = inputVilleArriver.Text;
                float tarif = float.Parse(inputTarif.Text);
                string id = iditineraire;
                //Insertion :
                itineraire.updateData(id, reference, depart, arriver, tarif);
                //Refresh :
                itineraire.readData(dgvitineraire);
                //reset :
                inputReferenceitineraire.ResetText();
                inputVilleDepart.ResetText();
                inputVilleArriver.ResetText();
                inputTarif.ResetText();
                MessageBox.Show("Modification réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvitineraire_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            inputReferenceitineraire.Text = dgvitineraire.Rows[index].Cells[0].Value.ToString();
            iditineraire = dgvitineraire.Rows[index].Cells[0].Value.ToString();
            inputVilleDepart.Text = dgvitineraire.Rows[index].Cells[1].Value.ToString();
            inputVilleArriver.Text = dgvitineraire.Rows[index].Cells[2].Value.ToString();
            inputTarif.Text = dgvitineraire.Rows[index].Cells[3].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string id = iditineraire;
                itineraire.deleteData(id);
                //reset :
                inputReferenceitineraire.ResetText();
                inputVilleDepart.ResetText();
                inputVilleArriver.ResetText();
                inputTarif.ResetText();
                itineraire.readData(dgvitineraire);
                MessageBox.Show("Suppréssion réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                //Maka :
                string recherche = inputRechercher.Text;
                itineraire.rechercherData(recherche, dgvitineraire);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
