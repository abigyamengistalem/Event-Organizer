using MySql.Data.MySqlClient;
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
    /// Interaction logic for AddVenue.xaml
    /// </summary>
    /// //INSERT INTO `venue`(`Name`, `VenueType`, `VenueLocation`, `VenueSize`, `PhoneNumber`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5])
    public partial class AddVenue : UserControl
    {
        public AddVenue()
        {
            InitializeComponent();
        }

        private void SubmitU_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SubmitV_Click(object sender, RoutedEventArgs e)
        {
            string connection = "Server=localhost;UserId=root;Database=Pagent;";
            MySqlConnection conn = new MySqlConnection(connection);
            string name = NameV.Text;
            string type = TypeV.Text;
            string location = LocationV.Text;
            
            string phonenumber = PhoneNumberV.Text;
            decimal size = decimal.Parse(VenuSizeV.Text);
            string insertvenue = $"INSERT INTO `venue`(`Name`, `VenueType`, `VenueLocation`, `VenueSize`, `PhoneNumber`) VALUES('{name}', '{type}', '{location}', '{size}', '{phonenumber}')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertvenue, conn);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("You Have Registered The Venue Sucessfully  ");

                }
                else
                {
                    MessageBox.Show("data not inserted");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            conn.Close();
        }
    }
}
    

