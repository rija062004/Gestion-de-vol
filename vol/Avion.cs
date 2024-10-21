using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace vol
{
    internal class Avion
    {
        private string connectionString = "Server=localhost;Port=5432;Database=gestionvol;User Id=postgres;Password=rijaniaina";

        public Avion()
        {
            
        }

        //Insertion
        public void insertData(string codeavion, string codecompagnie, string referencevol, string modele, int capacite )
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande :
            string requete = "INSERT INTO avion(codeavion, codecompagnie, referencevol, modele, capacite)" +
                "VALUES (@codeavion, @codecompagnie, @referencevol, @modele, @capacite)";
          command.CommandType = System.Data.CommandType.Text;
          command.CommandText = requete;
          command.Parameters.AddWithValue("@codeavion", codeavion);
          command.Parameters.AddWithValue("@codecompagnie", codecompagnie);
          command.Parameters.AddWithValue("@referencevol", referencevol);
          command.Parameters.AddWithValue("@modele", modele);
          command.Parameters.AddWithValue("@capacite", capacite);
          command.ExecuteNonQuery();
        }

        //Modification
        public void updateData( string id, string codeavion, string codecompagnie, string referencevol, string modele, int capacite)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande :
            string requete = "UPDATE avion SET codeavion = @codeavion, codecompagnie = @codecompagnie, referencevol = @referencevol, modele = @modele, " +
                "capacite = @capacite WHERE codeavion = @id";

          command.CommandType = System.Data.CommandType.Text;
          command.CommandText = requete;
          command.Parameters.AddWithValue("@codeavion", codeavion);
          command.Parameters.AddWithValue("@codecompagnie", codecompagnie);
          command.Parameters.AddWithValue("@referencevol", referencevol);
          command.Parameters.AddWithValue("@modele", modele);
          command.Parameters.AddWithValue("@capacite", capacite);
          command.Parameters.AddWithValue("@id", id);
          command.ExecuteNonQuery();
        }

        //Suppression
        public void deleteData(string id)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande :
            string requete = "DELETE FROM avion WHERE codeavion = @id";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@id", id);
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

            //Comma
            string requete = "SELECT * FROM avion";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = (requete);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataTable.Columns["codeavion"].ColumnName = "Code de l'avion";
                dataTable.Columns["codecompagnie"].ColumnName = "Compagnie Aerienne";
                dataTable.Columns["referencevol"].ColumnName = "Vol";
                dataTable.Columns["modele"].ColumnName = "Modéle";
                dataTable.Columns["capacite"].ColumnName = "capacite";

                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }

        public void rechercheData(string modele,  DataGridView dataGridView)
        {
            //Connection 
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Comma
            string requete = "SELECT * FROM avion WHERE modele ILIKE @modele";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = (requete);
            command.Parameters.AddWithValue("@modele", "%" + modele + "%");
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataTable.Columns["codeavion"].ColumnName = "Code de l'avion";
                dataTable.Columns["codecompagnie"].ColumnName = "Compagnie Aerienne";
                dataTable.Columns["referencevol"].ColumnName = "Vol";
                dataTable.Columns["modele"].ColumnName = "Modéle";
                dataTable.Columns["capacite"].ColumnName = "capacite";

                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }
    }
}
