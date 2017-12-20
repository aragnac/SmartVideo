using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFApplication.ServiceHostReference;

namespace WPFApplication
{
    /// <summary>
    /// Logique d'interaction pour AjoutTrailer.xaml
    /// </summary>
    public partial class AjoutTrailer : Window
    {
        private string _trailer = "";
        private string _titre = "";
        private int _id;

        ToolsBDClient s;

        public AjoutTrailer()
        {
            InitializeComponent();
        }

        public AjoutTrailer(String titre, int id, String trailer = "")
        {
            InitializeComponent();
            s = new ToolsBDClient();
            _id = id;
            _trailer = trailer;
            _titre = titre;
            filmLabel.Content = "Trailer pour le film : "+ _titre;
            if(trailer != "")
            {
                trailerTextBox.Text = _trailer;
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            s.InsertTrailer(trailerTextBox.Text, _id);
            this.Close();
        }
    }
}
