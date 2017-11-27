using DAL;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace WPFApplication
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB con;
        SqlDataAdapter DataRead;
        int offset = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnexionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ConnexionDB connexiondb = new ConnexionDB();
            if (connexiondb.ShowDialog() == true)
            {
                con = new DB(connexiondb.serveurTB.Text, connexiondb.nomdbTB.Text);

            }

            fillDataGrid();
        }

        private void DeconnexionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            con.CloseConnexionBD();
        }

        public void fillDataGrid()
        {

            DataRead = con.Select("Film", offset);

            DataTable table = new DataTable("Films");
            DataRead.Fill(table);
            table.Columns.Remove("posterpath");
            table.Columns.Remove("id");
            ResultDataGrid.ItemsSource = table.DefaultView;
        }

        private void previousButton_Click(object sender, RoutedEventArgs e)
        {
            if (offset != 0)
                offset -= 20;
            fillDataGrid();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            offset += 20;
            fillDataGrid();
        }
    }
}
