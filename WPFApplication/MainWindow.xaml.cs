﻿using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using WCFLibrary;
using FilmDTOLibrary;
using System.Collections.Generic;
using System;
using WPFApplication.ServiceHostReference;
using System.ServiceModel;

namespace WPFApplication
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ToolsBDClient s;
        
        int offset = 0;

        public MainWindow()
        {
            InitializeComponent();

            s = null;
            try
            {
                s = new ToolsBDClient();

            }
            catch(Exception e)
            {
                MessageBox.Show("Impossible d'atteindre le service WCF! \n" + e.Message);
            }
            //if ((listtemp = s.GetFilms("Film", offset)) != null) ;
            ResultDataGrid.ItemsSource = s.GetFilms("Film", offset);
        }

        private void previousButton_Click(object sender, RoutedEventArgs e)
        {
            if (offset != 0)
                offset -= 10;
            ResultDataGrid.ItemsSource = s.GetFilms("Film", offset);
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            offset += 10;
            ResultDataGrid.ItemsSource = s.GetFilms("Film", offset);
        }

        private void ResultDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            if (ResultDataGrid.SelectedItem != null)
            {
                FilmDTO film = (FilmDTO)ResultDataGrid.SelectedItems[0];
                int id = film.Id;

                filmDetails filmdetails = new filmDetails(id, film.Title, film.Posterpath, film.Trailerpath);
                filmdetails.ShowDialog();
            }

        }
    }
}
