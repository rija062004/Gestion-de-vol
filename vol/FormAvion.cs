using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vol
{
    public partial class FormAvion : Form
    {
        private Avion Avion;
        private string idAvion;
        public FormAvion()
        {
            InitializeComponent();
            Avion = new Avion();
            idAvion = "";
            Avion.readData(dvgAvion);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                //Maka valeur
                string code = inputCodeAvion.Text;
                string compagnie = inputCodeCompagnie.Text;
                string vol = inputReferenceVol.Text;
                string modele = inputModel.Text;
                int capacite = int.Parse(inputCapacite.Text);
                //Fonction 
                Avion.insertData(code, compagnie, vol, modele, capacite);
                MessageBox.Show("Insertion réussie", "Succées", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh
                Avion.readData(dvgAvion);
                //Reset form
                inputCodeAvion.Text = "";
                inputCodeCompagnie.Text = "";
                inputReferenceVol.Text = "";
                inputModel.Text = "";
                inputCapacite.Text = "";
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
                //Maka valeur
                string code = inputCodeAvion.Text;
                string compagnie = inputCodeCompagnie.Text;
                string vol = inputReferenceVol.Text;
                string modele = inputModel.Text;
                int capacite = int.Parse(inputCapacite.Text);
                string id = idAvion;
                //Fonction 
                Avion.updateData(id, code, compagnie, vol, modele, capacite);
                MessageBox.Show("Insertion réussie", "Succées", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh
                Avion.readData(dvgAvion);
                //Reset form
                inputCodeAvion.Text = "";
                inputCodeCompagnie.Text = "";
                inputReferenceVol.Text = "";
                inputModel.Text = "";
                inputCapacite.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgAvion_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            inputCodeAvion.Text = dvgAvion.Rows[index].Cells[0].Value.ToString();
            idAvion = dvgAvion.Rows[index].Cells[0].Value.ToString();
            inputCodeCompagnie.Text = dvgAvion.Rows[index].Cells[1].Value.ToString();
            inputReferenceVol.Text = dvgAvion.Rows[index].Cells[2].Value.ToString();
            inputModel.Text = dvgAvion.Rows[index].Cells[3].Value.ToString();
            inputCapacite.Text = dvgAvion.Rows[index].Cells[4].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idAvion;
                Avion.deleteData(id);
                Avion.readData(dvgAvion);
                //Reset form
                inputCodeAvion.Text = "";
                inputCodeCompagnie.Text = "";
                inputReferenceVol.Text = "";
                inputModel.Text = "";
                inputCapacite.Text = "";
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
                Avion.rechercheData(id, dvgAvion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
