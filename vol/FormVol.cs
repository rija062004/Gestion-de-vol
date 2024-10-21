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
    public partial class FormVol : Form
    {
        private Vol vol;
        private string idVol;
        public FormVol()
        {
            InitializeComponent();
            vol = new Vol();
            idVol = "";
            vol.readData(dgvVol);
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                //Maka données :
                string reference = inputReferenceVol.Text;
                string itineraire = inputReferenceItineraire.Text;
                string code = inputCode.Text;
                DateTime dateTime = datePickerVol.Value;
                string heure = inputHeure.Text;
                //Insertion :
                vol.insertData(reference, itineraire, code, dateTime, heure);
                //Refresh :
                vol.readData(dgvVol);
                //reset :
                inputReferenceVol.Text = "";
                inputReferenceItineraire.Text = "";
                inputCode.Text = "";
                inputHeure.Text = "";
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
                string reference = inputReferenceVol.Text;
                string itineraire = inputReferenceItineraire.Text;
                string code = inputCode.Text;
                DateTime dateTime = datePickerVol.Value;
                string heure = inputHeure.Text;
                string id = idVol;
                //Insertion :
                vol.updateData(id, reference, itineraire, code, dateTime, heure);
                //Refresh :
                vol.readData(dgvVol);
                //reset :
                inputReferenceVol.Text = "";
                inputReferenceItineraire.Text = "";
                inputCode.Text = "";
                inputHeure.Text = "";
                MessageBox.Show("Modification réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVol_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            inputReferenceVol.Text = dgvVol.Rows[index].Cells[0].Value.ToString();
            idVol = dgvVol.Rows[index].Cells[0].Value.ToString();
            inputReferenceItineraire.Text = dgvVol.Rows[index].Cells[1].Value.ToString();
            inputCode.Text = dgvVol.Rows[index].Cells[2].Value.ToString();
            string dateStr = dgvVol.Rows[index].Cells[3].Value.ToString();
            inputHeure.Text = dgvVol.Rows[index].Cells[4].Value.ToString();

            DateTime dateVol;
            if (DateTime.TryParse(dateStr, out dateVol))
            {
                datePickerVol.Value = dateVol;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idVol;
                vol.deleteData(id);
                //reset :
                inputReferenceVol.Text = "";
                inputReferenceItineraire.Text = "";
                inputCode.Text = "";
                inputHeure.Text = "";
                vol.readData(dgvVol);
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
                string id = "";
                vol.rechercherData(id, dgvVol);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
