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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Event_Organizer
{
    /// <summary>
    /// Interaction logic for ForGallery.xaml
    /// </summary>
    public partial class ForGallery : UserControl
    {
        public ForGallery()
        {
            InitializeComponent();
        }

        private void AddImages_Click(object sender, RoutedEventArgs e)
        {
            show.Children.Clear();
            show.Children.Add(new AddImages());

        }
       

        private void ViewImages_Click(object sender, RoutedEventArgs e)
        {
            show.Children.Clear();
            show.Children.Add(new ViewImages());
        }
    }
}
