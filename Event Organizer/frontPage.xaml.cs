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
    /// Interaction logic for frontPage.xaml
    /// </summary>
    public partial class frontPage : UserControl
    {
        public frontPage()
        {
            InitializeComponent();
        }
        private void Contestants_Click(object sender, RoutedEventArgs e)
        {

            Button clickedMe = sender as Button;
            StackPanel butParent = (StackPanel)clickedMe.Parent;
            Grid stackParent = (Grid)butParent.Parent;
            Grid gridParent = (Grid)stackParent.Parent;
            UserControl userControlParent = (UserControl)gridParent.Parent;
            Grid workingArea = (Grid)userControlParent.Parent;
            workingArea.Children.Clear();
            workingArea.Children.Add(new ForContestants());
            //  Contestants contestants = new Contestants();
            // contestants.Show();
            // Application.Current.Windows[0].Hide();





        }
        private void Judges_Click(object sender, RoutedEventArgs e)
        {
            Button clickedMe = sender as Button;
            StackPanel butParent = (StackPanel)clickedMe.Parent;
            Grid stackParent = (Grid)butParent.Parent;
            Grid gridParent = (Grid)stackParent.Parent;
            UserControl userControlParent = (UserControl)gridParent.Parent;
            Grid workingArea = (Grid)userControlParent.Parent;
            workingArea.Children.Clear();
            workingArea.Children.Add(new ForJudges());

        }

        private void Gallery_Click(object sender, RoutedEventArgs e)
        {
            Button clickedMe = sender as Button;
            StackPanel butParent = (StackPanel)clickedMe.Parent;
            Grid stackParent = (Grid)butParent.Parent;
            Grid gridParent = (Grid)stackParent.Parent;
            UserControl userControlParent = (UserControl)gridParent.Parent;
            Grid workingArea = (Grid)userControlParent.Parent;
            workingArea.Children.Clear();
            workingArea.Children.Add(new ForGallery());

        }

        private void Sponsers_Click(object sender, RoutedEventArgs e)
        {
            Button clickedMe = sender as Button;
            StackPanel butParent = (StackPanel)clickedMe.Parent;
            Grid stackParent = (Grid)butParent.Parent;
            Grid gridParent = (Grid)stackParent.Parent;
            UserControl userControlParent = (UserControl)gridParent.Parent;
            Grid workingArea = (Grid)userControlParent.Parent;
            workingArea.Children.Clear();
            workingArea.Children.Add(new ForSponsers());

        }
        private void News_Click(object sender, RoutedEventArgs e)
        {
            Button clickedMe = sender as Button;
            StackPanel butParent = (StackPanel)clickedMe.Parent;
            Grid stackParent = (Grid)butParent.Parent;
            Grid gridParent = (Grid)stackParent.Parent;
            UserControl userControlParent = (UserControl)gridParent.Parent;
            Grid workingArea = (Grid)userControlParent.Parent;
            workingArea.Children.Clear();
            workingArea.Children.Add(new ForNews());

        }
        private void Venue_Click(object sender, RoutedEventArgs e)
        {
            Button clickedMe = sender as Button;
            StackPanel butParent = (StackPanel)clickedMe.Parent;
            Grid stackParent = (Grid)butParent.Parent;
            Grid gridParent = (Grid)stackParent.Parent;
            UserControl userControlParent = (UserControl)gridParent.Parent;
            Grid workingArea = (Grid)userControlParent.Parent;
            workingArea.Children.Clear();
            workingArea.Children.Add(new ForVenue());

        }
    }
}
