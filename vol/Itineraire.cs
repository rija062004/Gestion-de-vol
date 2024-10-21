using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace vol
{
    internal class Itineraire
    {
        private string connectionString = "Server=localhost;Port=5432;Database=gestionvol;User Id=postgres;Password=rijaniaina";

        public Itineraire() { 
            
        }

        public void insertData (string referenceitineraire, string villedepart, string villearriver, float tarif)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            // Définir la commande avec des paramètres
            string requete = "INSERT INTO itineraire (referenceitineraire, villedepart, villearriver, tarif) " +
                "VALUES (@referenceitineraire, @villedepart, @villearriver, @tarif)";

            // Assigner le type de commande
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;

            // Ajouter les paramètres à la commande
            command.Parameters.AddWithValue("@referenceitineraire", referenceitineraire);
            command.Parameters.AddWithValue("@villedepart", villedepart);
            command.Parameters.AddWithValue("@villearriver", villearriver);
            command.Parameters.AddWithValue("@tarif", tarif);

            // Exécuter la commande
            command.ExecuteNonQuery();
        }
        
        //fonction pour l'affichage des données 
        public void readData (DataGridView dataGridView)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            string requete = "SELECT * FROM itineraire ORDER BY referenceitineraire ASC";
            command.CommandType= System.Data.CommandType.Text;
            command.CommandText= requete;
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();

                // Charger le DataReader dans le DataTable
                dataTable.Load(reader);

                // Nom des colonnes
                dataTable.Columns["referenceitineraire"].ColumnName = "Référence Itinéraire";
                dataTable.Columns["villedepart"].ColumnName = "Ville de départ";
                dataTable.Columns["villearriver"].ColumnName = "Ville d'arriver";
                dataTable.Columns["tarif"].ColumnName = "Tarif";

                // Affecter le DataTable à la source de données du DataGridView
                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }

        //Fonction pour la mis à jour 
        public void updateData (string id, string referenceitineraire, string villedepart, string villearriver, float tarif)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            // Définir la commande avec des paramètres
            string requete = "UPDATE itineraire SET referenceitineraire = @referenceitineraire, " +
                "villedepart = @villedepart,villearriver = @villearriver, tarif = @tarif WHERE referenceitineraire = @id ";

            // Assigner le type de commande
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;

            // Ajouter les paramètres à la commande
            command.Parameters.AddWithValue("@referenceitineraire", referenceitineraire);
            command.Parameters.AddWithValue("@villedepart", villedepart);
            command.Parameters.AddWithValue("@villearriver", villearriver);
            command.Parameters.AddWithValue("@tarif", tarif);
            command.Parameters.AddWithValue("@id", id);

            // Exécuter la commande
            command.ExecuteNonQuery();
        }

        public void deleteData(string id) 
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            // Définir la commande avec des paramètres
            string requete = "DELETE FROM itineraire WHERE referenceitineraire = @id";

            // Assigner le type de commande
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@id", id);
            // Exécuter la commande
            command.ExecuteNonQuery();
        }
        public void rechercherData(string ville, DataGridView dataGridView)
        {
            NpgsqlConnection connection = new NpgsqlConnection( connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(); command.Connection = connection;
            //Commande
            command.Connection = connection;
            string requete = "SELECT * FROM itineraire WHERE villedepart ILIKE @villePattern OR villearriver ILIKE @villePattern";

            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@villePattern", "%" + ville + "%");

            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();

                // Charger le DataReader dans le DataTable
                dataTable.Load(reader);

                // Nom des colonnes
                dataTable.Columns["referenceitineraire"].ColumnName = "Référence Itinéraire";
                dataTable.Columns["villedepart"].ColumnName = "Ville de départ";
                dataTable.Columns["villearriver"].ColumnName = "Ville d'arriver";
                dataTable.Columns["tarif"].ColumnName = "Tarif";

                // Affecter le DataTable à la source de données du DataGridView
                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }

        public void resetTextBox(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4) 
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
        }
    }
}
