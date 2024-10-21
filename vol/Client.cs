using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vol
{
    internal class Client
    {
        private string connectionString = "Server=localhost;Port=5432;Database=gestionvol;User Id=postgres;Password=rijaniaina";
        public Client()
        {
            
        }

        //Insertion :
        public void insertData(string numpasseport, string referencevol,string numcin, string nomclient, string prenomclient, string adresseclient, 
            string numerotelephoneclient)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande
            string requete = "INSERT INTO client(numpasseport, referencevol,numcin, nomclient, prenomclient, adresseclient,numerotelephoneclient)" +
                "VALUES (@numpasseport, @referencevol,@numcin, @nomclient, @prenomclient, @adresseclient, @numerotelephoneclient)";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            //Parametrage
            command.Parameters.AddWithValue("@numpasseport", numpasseport);
            command.Parameters.AddWithValue("@referencevol", referencevol);
            command.Parameters.AddWithValue("@numcin", numcin);
            command.Parameters.AddWithValue("@nomclient", nomclient);
            command.Parameters.AddWithValue("@prenomclient", prenomclient);
            command.Parameters.AddWithValue("@adresseclient", adresseclient);
            command.Parameters.AddWithValue("@numerotelephoneclient", numerotelephoneclient);
            //Execution du requete:
            command.ExecuteNonQuery();
        }

        public void updateData(string id,string numpasseport, string referencevol, string numcin, string nomclient, string prenomclient, string adresseclient,
            string numerotelephoneclient)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            //Commande : 
            string requete = "UPDATE client SET numpasseport = @numpasseport, referencevol = @referencevol,numcin = @numcin, nomclient = @nomclient, " +
                "prenomclient = @prenomclient, adresseclient = @adresseclient,numerotelephoneclient = @numerotelephoneclient WHERE numpasseport = @id";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            //Parametrage
            command.Parameters.AddWithValue("@numpasseport", numpasseport);
            command.Parameters.AddWithValue("@referencevol", referencevol);
            command.Parameters.AddWithValue("@numcin", numcin);
            command.Parameters.AddWithValue("@nomclient", nomclient);
            command.Parameters.AddWithValue("@prenomclient", prenomclient);
            command.Parameters.AddWithValue("@adresseclient", adresseclient);
            command.Parameters.AddWithValue("@numerotelephoneclient", numerotelephoneclient);
            command.Parameters.AddWithValue("@id", id);
            //Execution du requete:
            command.ExecuteNonQuery();
        }

        public void deleteData(string id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;


            string requete = "DELETE FROM client WHERE numpasseport = @id";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = requete;
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        //Listage
        public void readData(DataGridView dataGridView)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;


            string requete = "SELECT * FROM client";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = (requete);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataTable.Columns["numpasseport"].ColumnName = "Numéros du passeport";
                dataTable.Columns["referencevol"].ColumnName = "Vol";
                dataTable.Columns["numcin"].ColumnName = "CIN";
                dataTable.Columns["nomclient"].ColumnName = "Nom";
                dataTable.Columns["prenomclient"].ColumnName = "Prénom";
                dataTable.Columns["adresseclient"].ColumnName = "Adresse";
                dataTable.Columns["numerotelephoneclient"].ColumnName = "Téléphone";

                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }

        public void rechercherData(string nom, DataGridView dataGridView)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;


            string requete = "SELECT * FROM client WHERE nomclient ILIKE @nom OR prenomclient ILIKE @nom";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = (requete);
            command.Parameters.AddWithValue("@nom", "%" + nom + "%");
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataTable.Columns["numpasseport"].ColumnName = "Numéros du passeport";
                dataTable.Columns["referencevol"].ColumnName = "Vol";
                dataTable.Columns["numcin"].ColumnName = "CIN";
                dataTable.Columns["nomclient"].ColumnName = "Nom";
                dataTable.Columns["prenomclient"].ColumnName = "Prénom";
                dataTable.Columns["adresseclient"].ColumnName = "Adresse";
                dataTable.Columns["numerotelephoneclient"].ColumnName = "Téléphone";

                dataGridView.DataSource = dataTable;
            }
            reader.Close();
        }
    }
}
