using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace vol
{
    internal class Personnel
    {
        private string connectionString = "Server=localhost;Port=5432;Database=gestionvol;User Id=postgres;Password=rijaniaina";

        public Personnel()
        {
            
        }

        //Creation
        public void insertData(string codepersonnel, string codecompagnie, string nompersonnel, string prenompersonnel, string fonctionpersonnel)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            
            //Commande
            string requete = "INSERT INTO personnel(codepersonnel, codecompagnie, nompersonnel, prenompersonnel, fonctionpersonnel)" +
                "VALUES (@codepersonnel, @codecompagnie, @nompersonnel, @prenompersonnel, @fonctionpersonnel)";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            //Parametre :
            command.Parameters.AddWithValue("@codepersonnel", codepersonnel);
            command.Parameters.AddWithValue("@codecompagnie", codecompagnie);
            command.Parameters.AddWithValue("@nompersonnel", nompersonnel);
            command.Parameters.AddWithValue("@prenompersonnel", prenompersonnel);
            command.Parameters.AddWithValue("@fonctionpersonnel", fonctionpersonnel);
            //Execution :
            command.ExecuteNonQuery();
        }

        //Modification
        public void updateData(string id, string codepersonnel, string codecompagnie, string nompersonnel, string prenompersonnel, string fonctionpersonnel)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            
            //Commande :
            string requete = "UPDATE personnel SET codepersonnel = @codepersonnel, codecompagnie = @codecompagnie, nompersonnel = @nompersonnel, " +
                "prenompersonnel = @prenompersonnel, fonctionpersonnel = @fonctionpersonnel WHERE codepersonnel = @id ";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            //Parametre :
            command.Parameters.AddWithValue("@codepersonnel", codepersonnel);
            command.Parameters.AddWithValue("@codecompagnie", codecompagnie);
            command.Parameters.AddWithValue("@nompersonnel", nompersonnel);
            command.Parameters.AddWithValue("@prenompersonnel", prenompersonnel);
            command.Parameters.AddWithValue("@fonctionpersonnel", fonctionpersonnel);
            command.Parameters.AddWithValue("@id", id);
            //Execution :
            command.ExecuteNonQuery();
        }

        //Listage
        public void readData(DataGridView dataGridView)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande :
            string requete = "SELECT * FROM personnel ORDER BY codepersonnel ASC";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();

                // Charger le DataReader dans le DataTable
                dataTable.Load(reader);

                // Nom des colonnes
                dataTable.Columns["codepersonnel"].ColumnName = "Référence Itinéraire";
                dataTable.Columns["codecompagnie"].ColumnName = "Compagnie";
                dataTable.Columns["nompersonnel"].ColumnName = "Nom";
                dataTable.Columns["prenompersonnel"].ColumnName = "Prénom";
                dataTable.Columns["fonctionpersonnel"].ColumnName = "Fonction";
                // Affecter le DataTable à la source de données du DataGridView
                dataGridView.DataSource = dataTable;
            }
            command.Dispose();
        }

        //Suppression
        public void deleteData(string id) 
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            // Définir la commande avec des paramètres
            string requete = "DELETE FROM personnel WHERE codepersonnel = @id";

            // Assigner le type de commande
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@id", id);
            // Exécuter la commande
            command.ExecuteNonQuery();
        }

        public void rechercherData(string id, DataGridView dataGridView)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande :
            string requete = "SELECT * FROM personnel WHERE nompersonnel ILIKE @id or prenompersonnel ILIKE @id";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@id", "%" + id + "%");
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();

                // Charger le DataReader dans le DataTable
                dataTable.Load(reader);

                // Nom des colonnes
                dataTable.Columns["codepersonnel"].ColumnName = "Référence Itinéraire";
                dataTable.Columns["codecompagnie"].ColumnName = "Compagnie";
                dataTable.Columns["nompersonnel"].ColumnName = "Nom";
                dataTable.Columns["prenompersonnel"].ColumnName = "Prénom";
                dataTable.Columns["fonctionpersonnel"].ColumnName = "Fonction";
                // Affecter le DataTable à la source de données du DataGridView
                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }
    }
}
