using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace vol
{
    internal class Compagnie
    {
        private string connectionString = "Server=localhost;Port=5432;Database=gestionvol;User Id=postgres;Password=rijaniaina";

        public Compagnie()
        {
            
        }

        //Insertion
        public void insertData(string codecompagnie, string nomcompagnie, string numerotelephonecompagnie, string adressecompagnie)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande
            string requete = "INSERT INTO compagnie_aerienne (codecompagnie, nomcompagnie, numerotelephonecompagnie, adressecompagnie)" +
                "VALUES (@codecompagie, @nomcompagnie, @numerotelephone, @adressecompagnie)";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            //Requete preparer
            command.Parameters.AddWithValue("@codecompagie", codecompagnie);
            command.Parameters.AddWithValue("@nomcompagnie", nomcompagnie);
            command.Parameters.AddWithValue("@numerotelephone", numerotelephonecompagnie);
            command.Parameters.AddWithValue("@adressecompagnie", adressecompagnie);
            //execution
            command.ExecuteNonQuery();
        }

        //Fetch data
        public void readData(DataGridView dataGridView)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            string requete = "SELECT * FROM compagnie_aerienne ORDER BY codecompagnie ASC";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                //Nom des colonnes
                dataTable.Columns["codecompagnie"].ColumnName = "Code";
                dataTable.Columns["nomcompagnie"].ColumnName = "Nom";
                dataTable.Columns["numerotelephonecompagnie"].ColumnName = "Numéro téléphone";
                dataTable.Columns["adressecompagnie"].ColumnName = "Adresse";

                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }

        //Mis à jour
        public void updateData(string id,string codecompagnie, string nomcompagnie, string numerotelephonecompagnie, string adressecompagnie)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            string requete = "UPDATE compagnie_aerienne SET codecompagnie = @codecompagnie, nomcompagnie = @nomcompagnie, numerotelephonecompagnie = @numerotelephone, " +
                "adressecompagnie = @adressecompagnie WHERE codecompagnie = @id ";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            //Requete preparer
            command.Parameters.AddWithValue("@codecompagnie", codecompagnie);
            command.Parameters.AddWithValue("@nomcompagnie", nomcompagnie);
            command.Parameters.AddWithValue("@numerotelephone", numerotelephonecompagnie);
            command.Parameters.AddWithValue("@adressecompagnie", adressecompagnie);
            command.Parameters.AddWithValue("@id", id);
            //execution
            command.ExecuteNonQuery();
        }

        //Delete
        public void deleteData(string id)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            // Définir la commande avec des paramètres
            string requete = "DELETE FROM compagnie_aerienne WHERE codecompagnie = @id";

            // Assigner le type de commande
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@id", id);
            // Exécuter la commande
            command.ExecuteNonQuery();
        }

        public void rechercherData(string id , DataGridView dataGridView)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            string requete = "SELECT * FROM compagnie_aerienne WHERE nomcompagnie ILIKE @id";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@id", "%" + id + "%");
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                //Nom des colonnes
                dataTable.Columns["codecompagnie"].ColumnName = "Code";
                dataTable.Columns["nomcompagnie"].ColumnName = "Nom";
                dataTable.Columns["numerotelephonecompagnie"].ColumnName = "Numéro téléphone";
                dataTable.Columns["adressecompagnie"].ColumnName = "Adresse";

                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }

    }

}
