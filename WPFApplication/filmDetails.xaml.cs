﻿using DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WPFApplication
{
    /// <summary>
    /// Logique d'interaction pour filmDetails.xaml
    /// </summary>
    /// 
    //Lien vers les poster des film : http://image.tmdb.org/t/p/w185/gZCJZOn4l0Zj5hAxsMbxoS6CL0u.jpg
    public partial class filmDetails : Window
    {
        SqlDataAdapter DataRead;
        DB con;
        int idFilm;

        public filmDetails()
        {
            InitializeComponent();
          
        }

        public filmDetails(int id, DB conn, string film, string posterpath)
        {
            InitializeComponent();
            con = conn;
            idFilm = id;

            titleLabel.Content = film;
            loadImage(posterpath);
            actorsDataGrid.ItemsSource = fillDataGrid("Actor").DefaultView;
            directorsDataGrid.ItemsSource = fillDataGrid("Realisateur").DefaultView;
           


        }

        public DataTable fillDataGrid(string tempTable)
        {

            DataRead = con.SelectWithId(tempTable, idFilm );

            DataTable table = new DataTable(tempTable);
            DataRead.Fill(table);
            //table.Columns.Remove("posterpath");
            return table;
        }

        public void loadImage(string posterPath)
        {
            var image = new BitmapImage();
            int BytesToRead = 100;

            WebRequest request = WebRequest.Create(new Uri("http://image.tmdb.org/t/p/w185/" + posterPath, UriKind.Absolute));
            request.Timeout = -1;

            WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                BinaryReader reader = new BinaryReader(responseStream);
                MemoryStream memoryStream = new MemoryStream();

                byte[] bytebuffer = new byte[BytesToRead];
                int bytesRead = reader.Read(bytebuffer, 0, BytesToRead);

                while (bytesRead > 0)
                {
                    memoryStream.Write(bytebuffer, 0, bytesRead);
                    bytesRead = reader.Read(bytebuffer, 0, BytesToRead);
                }

                image.BeginInit();
                memoryStream.Seek(0, SeekOrigin.Begin);

                image.StreamSource = memoryStream;
                image.EndInit();

                posterPicture.Source = image;
        }
    }
}
