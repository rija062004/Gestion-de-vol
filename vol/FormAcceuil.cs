namespace vol
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Créez une instance de Form2
            FormVol vol = new FormVol();

            // Supprimez tous les contrôles existants dans le panel
            panelPrincipale.Controls.Clear();

            // Configurez Form2 pour qu'il s'affiche dans le panel
            vol.TopLevel = false;
            vol.FormBorderStyle = FormBorderStyle.None;
            vol.Dock = DockStyle.Fill;

            // Ajoutez Form2 au panel
            panelPrincipale.Controls.Add(vol);

            // Affichez Form2
            vol.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // Créez une instance de Form2
            FormPersonnel personnel = new FormPersonnel();

            // Supprimez tous les contrôles existants dans le panel
            panelPrincipale.Controls.Clear();

            // Configurez Form2 pour qu'il s'affiche dans le panel
            personnel.TopLevel = false;
            personnel.FormBorderStyle = FormBorderStyle.None;
            personnel.Dock = DockStyle.Fill;

            // Ajoutez Form2 au panel
            panelPrincipale.Controls.Add(personnel);

            // Affichez Form2
            personnel.Show();
        }

        private void btnItineraire_Click(object sender, EventArgs e)
        {
            // Créez une instance de Form2
            FormItineraire itineraire = new FormItineraire();

            // Supprimez tous les contrôles existants dans le panel
            panelPrincipale.Controls.Clear();

            // Configurez Form2 pour qu'il s'affiche dans le panel
            itineraire.TopLevel = false;
            itineraire.FormBorderStyle = FormBorderStyle.None;
            itineraire.Dock = DockStyle.Fill;

            // Ajoutez Form2 au panel
            panelPrincipale.Controls.Add(itineraire);

            // Affichez Form2
            itineraire.Show();
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            // Créez une instance de Form2
            FormAvion avion = new FormAvion();

            // Supprimez tous les contrôles existants dans le panel
            panelPrincipale.Controls.Clear();

            // Configurez Form2 pour qu'il s'affiche dans le panel
            avion.TopLevel = false;
            avion.FormBorderStyle = FormBorderStyle.None;
            avion.Dock = DockStyle.Fill;

            // Ajoutez Form2 au panel
            panelPrincipale.Controls.Add(avion);

            // Affichez Form2
            avion.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            // Créez une instance de Form2
            FormClient client = new FormClient();

            // Supprimez tous les contrôles existants dans le panel
            panelPrincipale.Controls.Clear();

            // Configurez Form2 pour qu'il s'affiche dans le panel
            client.TopLevel = false;
            client.FormBorderStyle = FormBorderStyle.None;
            client.Dock = DockStyle.Fill;

            // Ajoutez Form2 au panel
            panelPrincipale.Controls.Add(client);

            // Affichez Form2
            client.Show();
        }

        private void btnCompagnie_Click(object sender, EventArgs e)
        {
            // Créez une instance de Form2
            FormCompagnie compagnie = new FormCompagnie();

            // Supprimez tous les contrôles existants dans le panel
            panelPrincipale.Controls.Clear();

            // Configurez Form2 pour qu'il s'affiche dans le panel
            compagnie.TopLevel = false;
            compagnie.FormBorderStyle = FormBorderStyle.None;
            compagnie.Dock = DockStyle.Fill;

            // Ajoutez Form2 au panel
            panelPrincipale.Controls.Add(compagnie);

            // Affichez Form2
            compagnie.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Créez une instance de Form2
            FormImage image = new FormImage();

            // Supprimez tous les contrôles existants dans le panel
            panelPrincipale.Controls.Clear();

            // Configurez Form2 pour qu'il s'affiche dans le panel
            image.TopLevel = false;
            image.FormBorderStyle = FormBorderStyle.None;
            image.Dock = DockStyle.Fill;

            // Ajoutez Form2 au panel
            panelPrincipale.Controls.Add(image);

            // Affichez Form2
            image.Show();
        }
    }
}
