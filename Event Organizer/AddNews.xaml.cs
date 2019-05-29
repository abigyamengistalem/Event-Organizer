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
    /// Interaction logic for AddNews.xaml
    /// </summary>
    public partial class AddNews : UserControl
    {
        public AddNews()
        {
            InitializeComponent();
        }

        

        private void SubmitN_Click(object sender, RoutedEventArgs e)
        {
            string connection = "Server=localhost;UserId=root;Database=Pagent;";
            MySqlConnection conn = new MySqlConnection(connection);
            string addnews = News.Text;
            
            string insertnews= $"INSERT INTO `news`(Article) VALUES('{addnews}')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertnews, conn);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("News Submitted Sucessfully");

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
