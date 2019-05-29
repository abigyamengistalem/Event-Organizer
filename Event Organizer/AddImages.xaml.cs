using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for AddImages.xaml
    /// </summary>
    public partial class AddImages : UserControl
    {
        public AddImages()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            
            op.ShowDialog();
            var sourceFile = op.FileName;
            var newFileName = @"\" + op.SafeFileName;
            var targetPath = @"C:\Users\abigail\Desktop\Event Organizer\Event Organizer\Resource";
            var galleryImagePath = targetPath + newFileName;
            File.Copy(sourceFile, galleryImagePath);
            this.imagePa.Text = galleryImagePath;
           



            //op.Title = "Select a picture";
            //op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
             // "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              //"Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
            }

        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
           
            string connection = "Server=localhost;UserId=root;Database=Pagent;";
            MySqlConnection conn = new MySqlConnection(connection);
            string insertimage = $"INSERT INTO `gallery`(GalleryImages) VALUES('{ this.imagePa.Text.Replace("\\","\\\\")}')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertimage, conn);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("You Have Saved Your Image  Sucessfully  ");

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




