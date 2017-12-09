﻿using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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
                //MessageBox.Show("Connexion Ouverte ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'ouvrir la connexion! \n" + ex.Message);
            }

        }

        public Boolean addUser(UtilisateurDTO user)
        {
            //Data maping object to our database
            Utilisateur temp = new Utilisateur();
            temp.UserName = user.UserName;
            temp.Password = user.Password;
            temp.Prenom = user.Prenom;
            temp.Nom = user.Nom;

            //Adds an entity in a pending insert state to this System.Data.Linq.Table<TEntity>and parameter is the entity which to be added
            _context.Utilisateur.InsertOnSubmit(temp);
            // executes the appropriate commands to implement the changes to the database
            _context.SubmitChanges();

            return true;
        }

        public List<UtilisateurDTO> GetUtilisateur()
        {
            var query = "SELECT * from Utilisateur;";
            try
            {
                List<UtilisateurDTO> list = _context.ExecuteQuery<UtilisateurDTO>(query).Select(u => new UtilisateurDTO
                {
                    UserName = u.UserName,
                    Password = u.Password,
                    Nom = u.Nom,
                    Prenom = u.Prenom
                }).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<UtilisateurDTO>();
            }
        }

        /* private void UpdateCourse()
         {
             OperationDataContext OdContext = new OperationDataContext();
             //Get Single course which need to update
             COURSE objCourse = OdContext.COURSEs.Single(course => course.course_name == "B.Tech");
             //Field which will be update
             objCourse.course_desc = "Bachelor of Technology";
             // executes the appropriate commands to implement the changes to the database
             OdContext.SubmitChanges();
         }*/

    }
}
