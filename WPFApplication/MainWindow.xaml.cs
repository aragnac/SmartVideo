using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using WCFLibrary;
using FilmDTOLibrary;
using System.Collections.Generic;

namespace WPFApplication
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int offset = 0;

        public MainWindow()
        {
            InitializeComponent();
            ServiceHostReference.ToolsBDClient s = new ServiceHostReference.ToolsBDClient();
            ResultDataGrid.ItemsSource = s.GetFilms("Film", offset);
        }


        /*public void fillDataGrid()
        {

            DataRead = ("Film", offset);

            DataTable table = new DataTable("Films");
            DataRead.Fill(table);
            //table.Columns.Remove("posterpath");
            ResultDataGrid.ItemsSource = table.DefaultView;
            
        }*/

        private void previousButton_Click(object sender, RoutedEventArgs e)
        {
            if (offset != 0)
                offset -= 20;
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            offset += 20;
        }

        private void ResultDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            if (ResultDataGrid.SelectedItem != null)
            {
                DataRowView row = (DataRowView)ResultDataGrid.SelectedItems[0];
                int id = (int)row["id"];

                //filmDetails filmdetails = new filmDetails(id, con, (string)row["title"], (string)row["posterpath"], (string)row["trailerpath"]);
                //filmdetails.ShowDialog();
            }

        }
    }
}
