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
    public partial class FormCompagnie : Form
    {
        private Compagnie compagnie;
        private string idCompagnie;
        public FormCompagnie()
        {
            InitializeComponent();
            compagnie = new Compagnie();
            compagnie.readData(dgvCompagnie);
            idCompagnie = "";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                //Maka données :
                string code = inputCodecompagnie.Text;
                string nom = inputNomCompagnie.Text;
                string adresse = inputAdresseCompagie.Text;
                string num = (inputNumCompagnie.Text);
                //Insertion :
                compagnie.insertData(code, nom, adresse, num);
                //Refresh :
                compagnie.readData(dgvCompagnie);
                //reset :
                inputCodecompagnie.Text = "";
                inputNomCompagnie.Text = "";
                inputAdresseCompagie.Text = "";
                inputNumCompagnie.Text = "";
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
                string code = inputCodecompagnie.Text;
                string nom = inputNomCompagnie.Text;
                string adresse = inputAdresseCompagie.Text;
                string num = (inputNumCompagnie.Text);
                string id = idCompagnie;
                //Insertion :
                compagnie.updateData(id, code, nom, adresse, num);
                //Refresh :
                compagnie.readData(dgvCompagnie);
                //reset :
                inputCodecompagnie.Text = "";
                inputNomCompagnie.Text = "";
                inputAdresseCompagie.Text = "";
                inputNumCompagnie.Text = "";
                MessageBox.Show("Modification réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCompagnie_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            inputCodecompagnie.Text = dgvCompagnie.Rows[index].Cells[0].Value.ToString();
            idCompagnie = dgvCompagnie.Rows[index].Cells[0].Value.ToString();
            inputNomCompagnie.Text = dgvCompagnie.Rows[index].Cells[1].Value.ToString();
            inputAdresseCompagie.Text = dgvCompagnie.Rows[index].Cells[2].Value.ToString();
            inputNumCompagnie.Text = dgvCompagnie.Rows[index].Cells[3].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idCompagnie;
                compagnie.deleteData(id);
                //reset :
                inputCodecompagnie.Text = "";
                inputNomCompagnie.Text = "";
                inputAdresseCompagie.Text = "";
                inputNumCompagnie.Text = "";
                MessageBox.Show("Modification réussie !", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                compagnie.readData(dgvCompagnie);
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
                compagnie.rechercherData(id, dgvCompagnie);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
