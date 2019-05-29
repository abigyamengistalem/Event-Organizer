using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
    /// Interaction logic for ViewImages.xaml
    /// </summary>
    public partial class ViewImages : UserControl
    {

        public List<SingleGallery> data { get; private set; }
        public ViewImages()
        {
            InitializeComponent();
            // SingleGalleryDataone d = new SingleGalleryDataone();
            data = new List<SingleGallery>();
            DataTable galleryTable = DatabaseG.getGallery();
            DataRow[] dataRows = galleryTable.Select();
            foreach (DataRow singleRow in dataRows)
            {
                data.Add(new SingleGallery()
                {


                    imagePath = singleRow["GalleryImages"].ToString()


                   


                });
                MessageBox.Show(singleRow["GalleryImages"].ToString());
                //  Uri imageUri = new Uri(singleRow["GalleryImages"].ToString());
                //  BitmapImage image = new BitmapImage(imageUri);

            }

            
            
        }
        
    }
    public class SingleGallery
    {

        public string imagePath { get; set; }
        // add the other database column here
    }
}








