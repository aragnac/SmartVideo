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

namespace WPFApplication
{
    /// <summary>
    /// Logique d'interaction pour AjoutTrailer.xaml
    /// </summary>
    public partial class AjoutTrailer : Window
    {
        String _trailer = "";
        string _titre = "";

        public AjoutTrailer()
        {
            InitializeComponent();
        }

        public AjoutTrailer(String titre, String trailer = "")
        {
            InitializeComponent();
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

        }
    }
}
