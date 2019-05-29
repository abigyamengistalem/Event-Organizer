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
    /// Interaction logic for AddSponsers.xaml
    /// </summary>
    public partial class AddSponsers : UserControl
    {
        public AddSponsers()
        {
            InitializeComponent();
        }

        private void SubmitU_Click(object sender, RoutedEventArgs e)
        {
            string connection = "Server=localhost;UserId=root;Database=Pagent;";
            MySqlConnection conn = new MySqlConnection(connection);
            string firstname = FirstNameS.Text;
            string lastname = LastNameS.Text;
            string email = EmailS.Text;
            string phonenumber = PhoneNumberS.Text;
            string insertsponsers = $"INSERT INTO `sponsers`(FirstName, LastName, PhoneNumber, Email) VALUES('{firstname}', '{lastname}', '{email}', '{phonenumber}')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertsponsers, conn);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("You Have Registered The Sponser Sucessfully  ");

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
