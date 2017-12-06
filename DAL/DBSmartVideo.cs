using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAL
{
    public class DBSmartVideo
    {
        public BDSmartVideoDataContext _context = null;
        private static DBSmartVideo _instance;

        public static DBSmartVideo Singleton()
        {
            return _instance ?? (_instance = new DBSmartVideo("ARAGNAC", "BDSmartVideo"));
        }

        public DBSmartVideo(String servername, String dbname)
        {
            String connectionString = "Data Source = " + servername + " ; Initial Catalog =" + dbname + "; Integrated Security = True";

            try
            {
                _context = new BDSmartVideoDataContext(connectionString);
                MessageBox.Show("Connexion Ouverte ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'ouvrir la connexion! \n" + ex.Message);
            }

        }
    }
}
