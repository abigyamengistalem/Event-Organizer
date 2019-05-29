using System;
using System.Collections.Generic;
using System.Data;
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

namespace Event_Organizer
{
    /// <summary>
    /// Interaction logic for Contestants.xaml
    /// </summary>
    public partial class Contestants : Window
    {
        public Contestants()
        {
            InitializeComponent();
            
           
          
        }
        private void Contestants_Click(object sender, RoutedEventArgs e)
        {
            Contgrid.Children.Clear();
            Contgrid.Children.Add(new ForContestants());
            Home home = new Home();
            home.Hide();

        }
        private void Judges_Click(object sender, RoutedEventArgs e)
        {
            Contgrid.Children.Clear();
            Contgrid.Children.Add(new ForJudges());
        }

        private void Gallery_Click(object sender, RoutedEventArgs e)
        {
            Contgrid.Children.Clear();
            Contgrid.Children.Add(new ForGallery());
        }

        private void Sponsers_Click(object sender, RoutedEventArgs e)
        {
            Contgrid.Children.Clear();
            Contgrid.Children.Add(new ForSponsers());
        }
        private void News_Click(object sender, RoutedEventArgs e)
        {
            Contgrid.Children.Clear();
            Contgrid.Children.Add(new ForNews());
        }
        private void Venue_Click(object sender, RoutedEventArgs e)
        {
            Contgrid.Children.Clear();
            Contgrid.Children.Add(new ForVenue());
        }
    }
}
