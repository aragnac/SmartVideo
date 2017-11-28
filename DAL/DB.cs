using System;
using System.Data.SqlClient;
using System.Windows;

namespace DAL
{
    public class DB
    {
        private SqlConnection conn;

        public DB(String servername, String dbname)
        {
            String connectionString = "Data Source = " + servername + " ; Initial Catalog =" + dbname + "; Integrated Security = True";

            conn = new SqlConnection(connectionString);

            try {
                conn.Open();
                MessageBox.Show("Connexion Ouverte ");

            }catch (Exception ex) {
                MessageBox.Show("Impossible d'ouvrir la connexion! \n" + ex.Message);
            }



        }

        public void CloseConnexionBD()
        {
            try
            {
                conn.Close();
                MessageBox.Show("Base de données déconnectée");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Déconnexion de la base de données impossible ! \n" + ex.Message);
            }

        }

        public SqlDataAdapter Select(String table, int start)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + " ORDER BY id OFFSET "+ start +" ROWS FETCH NEXT 20 ROWS ONLY;", conn);
            SqlDataAdapter dataread = new SqlDataAdapter(cmd);

            /*while (reader.Read())
            {
                Fruitee.add(reader["aID"], reader["bID"], reader["name"])
            }*/

            return dataread;
        }

        public SqlDataAdapter SelectWithId(String table, int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT "+table+".* FROM Film"+table+" INNER JOIN "+table+" ON Film"+table+".id_"+table.ToLower()+" = "+table+".id WHERE Film"+table+".id_film = "+id+";", conn);
            SqlDataAdapter dataread = new SqlDataAdapter(cmd);

            return dataread;
        }
    }
}
