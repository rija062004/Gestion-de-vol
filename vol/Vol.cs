using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace vol
{
    internal class Vol
    {
        private string connectionString = "Server=localhost;Port=5432;Database=gestionvol;User Id=postgres;Password=rijaniaina";

        public Vol()
        {
            
        }

        //Insertion :"
        public void insertData(string referencevol, string referenceitineraire, string codecompagnie, DateTime datevol, string heurevol)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande:
            string requete = "INSERT INTO vol(referencevol, referenceitineraire, codecompagnie, datevol, heurevol)" +
                "VALUES (@referencevol, @referenceitineraire, @codecompagnie, @datevol, @heurevol)";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@referencevol", referencevol);
            command.Parameters.AddWithValue("@referenceitineraire", referenceitineraire);
            command.Parameters.AddWithValue("@codecompagnie", codecompagnie);
            command.Parameters.AddWithValue("@datevol", datevol);
            command.Parameters.AddWithValue("@heurevol", heurevol);
            command.ExecuteNonQuery();
        }

        //Modification
        public void updateData(string id, string referencevol, string referenceitineraire, string codecompagnie, DateTime datevol, string heurevol)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande
            string requete = "UPDATE vol SET referencevol = @referencevol, referenceitineraire = @referenceitineraire, codecompagnie = @codecompagnie, " +
                "datevol = @datevol, heurevol = @heurevol WHERE referencevol = @id";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@referencevol", referencevol);
            command.Parameters.AddWithValue("@referenceitineraire", referenceitineraire);
            command.Parameters.AddWithValue("@codecompagnie", codecompagnie);
            command.Parameters.AddWithValue("@datevol", datevol);
            command.Parameters.AddWithValue("@heurevol", heurevol);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        //Suppression:
        public void deleteData(string id)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande
            string requete = "DELETE FROM vol WHERE referencevol = @id";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        public void readData(DataGridView dataGridView)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Comande
            string requete = @"
            SELECT v.referencevol AS ""Reference du vol"",
                   v.referenceitineraire AS ""Itineraire"",
                   v.codecompagnie AS ""Compagnie"",
                   v.datevol AS ""Date"",
                   v.heurevol AS ""Heure"",
                   i.villedepart AS ""Ville de départ"", i.villearriver AS ""Ville d'arriver'"", tarif AS ""Tarif"",
                   c.nomcompagnie AS ""Compagnie Aérienne""
            FROM vol v
            JOIN itineraire i ON v.referenceitineraire = i.referenceitineraire
            JOIN compagnie_aerienne c ON v.codecompagnie = c.codecompagnie ORDER BY v.referencevol ASC ";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = (requete);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }

        public void rechercherData(string date, DataGridView dataGridView)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Com
            string requete = "SELECT * FROM vol WHERE YEAR(datevol) = YEAR(@date)";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = (requete);

            command.Parameters.AddWithValue("@date", date);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataTable.Columns["referencevol"].ColumnName = "Reference du vol";
                dataTable.Columns["referenceitineraire"].ColumnName = "Itineraire";
                dataTable.Columns["codecompagnie"].ColumnName = "Compagnie";
                dataTable.Columns["datevol"].ColumnName = "Date";
                dataTable.Columns["heurevol"].ColumnName = "Heure";

                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }
    }
}
