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
    public partial class FormClient : Form
    {
        private Client client;
        private string idClient;
        public FormClient()
        {
            InitializeComponent();
            client = new Client();
            idClient = "";
            client.readData(dgvClient);
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                //Maka données :
                string passeport = inputPasseport.Text;
                string vol = inputVol.Text;
                string cin = inputCin.Text;
                string nom = inputNom.Text;
                string prenom = inputPrenom.Text;
                string adresse = inputAdresse.Text;
                string telephone = inputTelephone.Text;
                //Insertion :
                client.insertData(passeport, vol, cin, nom, prenom, adresse, telephone);
                //Refresh :
                client.readData(dgvClient);
                //reset :
                inputPasseport.Text = "";
                inputVol.Text = "";
                inputCin.Text = "";
                inputNom.Text = "";
                inputPrenom.Text = "";
                inputAdresse.Text = "";
                inputTelephone.Text = "";
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
                string passeport = inputPasseport.Text;
                string vol = inputVol.Text;
                string cin = inputCin.Text;
                string nom = inputNom.Text;
                string prenom = inputPrenom.Text;
                string adresse = inputAdresse.Text;
                string telephone = inputTelephone.Text;
                string id = idClient;
                //Insertion :
                client.updateData(id, passeport, vol, cin, nom, prenom, adresse, telephone);
                //Refresh :
                client.readData(dgvClient);
                //reset :
                inputPasseport.Text = "";
                inputVol.Text = "";
                inputCin.Text = "";
                inputNom.Text = "";
                inputPrenom.Text = "";
                inputAdresse.Text = "";
                inputTelephone.Text = "";
                MessageBox.Show("Modification réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            inputPasseport.Text = dgvClient.Rows[index].Cells[0].Value.ToString();
            idClient = dgvClient.Rows[index].Cells[0].Value.ToString();
            inputVol.Text = dgvClient.Rows[index].Cells[1].Value.ToString();
            inputCin.Text = dgvClient.Rows[index].Cells[2].Value.ToString();
            inputNom.Text = dgvClient.Rows[index].Cells[3].Value.ToString();
            inputPrenom.Text = dgvClient.Rows[index].Cells[4].Value.ToString();
            inputAdresse.Text = dgvClient.Rows[index].Cells[5].Value.ToString();
            inputTelephone.Text = dgvClient.Rows[index].Cells[6].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idClient;
                client.deleteData(id);
                client.readData(dgvClient);
                //reset :
                inputPasseport.Text = "";
                inputVol.Text = "";
                inputCin.Text = "";
                inputNom.Text = "";
                inputPrenom.Text = "";
                inputAdresse.Text = "";
                inputTelephone.Text = "";
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
                string id = inputRechercher.Text;
                client.rechercherData(id , dgvClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
