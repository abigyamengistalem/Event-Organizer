

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            

            
            InitializeComponent();
        }
      

      

       

        private void Contestants_Click(object sender, RoutedEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();




        }
        private void Judges_Click(object sender, RoutedEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();

        }

        private void Gallery_Click(object sender, RoutedEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();

        }

        private void Sponsers_Click(object sender, RoutedEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();

        }
        private void News_Click(object sender, RoutedEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();

        }
        private void Venue_Click(object sender, RoutedEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();

        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();
        }

        private void ListViewItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();
        }

        private void ListViewItem_MouseDoubleClick_2(object sender, MouseButtonEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();
        }

        private void ListViewItem_MouseDoubleClick_3(object sender, MouseButtonEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();
        }

        private void ListViewItem_MouseDoubleClick_4(object sender, MouseButtonEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();
        }

        private void ListViewItem_MouseDoubleClick_5(object sender, MouseButtonEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();
        }

        private void ListViewItem_MouseDoubleClick_6(object sender, MouseButtonEventArgs e)
        {
            Contestants contestants = new Contestants();
            contestants.Show();
        }
    }

        
        
    }

