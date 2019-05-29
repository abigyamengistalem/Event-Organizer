using MaterialDesignThemes.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Event_Organizer
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            this.myWorkingSpace.Children.Add(new frontPage());

        }
        

       

        private void Contestants_Selected(object sender, RoutedEventArgs e)
        {
            this.myWorkingSpace.Children.Clear();
            this.myWorkingSpace.Children.Add(new ForContestants());

        }

        private void Judges_Selected(object sender, RoutedEventArgs e)
        {
            this.myWorkingSpace.Children.Clear();
            this.myWorkingSpace.Children.Add(new ForJudges());
        }

        private void Gallery_Selected(object sender, RoutedEventArgs e)
        {
            this.myWorkingSpace.Children.Clear();
            this.myWorkingSpace.Children.Add(new ForGallery());
        }

        private void News_Selected(object sender, RoutedEventArgs e)
        {
            this.myWorkingSpace.Children.Clear();
            this.myWorkingSpace.Children.Add(new ForNews());
        }

        private void Sponsers_Selected(object sender, RoutedEventArgs e)
        {
            this.myWorkingSpace.Children.Clear();
            this.myWorkingSpace.Children.Add(new ForSponsers());
        }

        private void Venue_Selected(object sender, RoutedEventArgs e)
        {
            this.myWorkingSpace.Children.Clear();
            this.myWorkingSpace.Children.Add(new ForVenue());
        }

        private void For_Home_Selected(object sender, RoutedEventArgs e)
        {
            this.myWorkingSpace.Children.Clear();
            this.myWorkingSpace.Children.Add(new frontPage());
        }
    }
}
